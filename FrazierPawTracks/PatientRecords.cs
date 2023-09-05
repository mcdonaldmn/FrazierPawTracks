using FrazierPawTracks.Database;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrazierPawTracks
{
    public partial class PatientRecords : Form
    {

        private SQLiteHelper dbHelper;

        public PatientRecords()
        {
            InitializeComponent();

            string dbFilePath = Path.Combine(Application.StartupPath, "database", "pawtracks.db");
            dbHelper = new SQLiteHelper(dbFilePath);

            LoadPatients();
        }

        public void LoadPatients()
        {
            try
            {
                dbHelper.OpenConnection();

                string query = "SELECT PatientID, PetName AS Pet, OwnerName AS Owner, PetAge AS `Pet's Age`, Gender, ContactNumber, Address FROM patients;";

                using (SQLiteDataReader reader = dbHelper.ExecuteQuery(query))
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    patientsDGV.DataSource = dataTable;

                    patientsDGV.AutoGenerateColumns = true;
                    patientsDGV.AllowUserToAddRows = false;
                    patientsDGV.ReadOnly = true;
                    patientsDGV.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }


        private void searchTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTB.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                foreach (DataGridViewRow row in patientsDGV.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            row.Selected = true;
                            patientsDGV.CurrentCell = cell;
                            patientsDGV.FirstDisplayedScrollingRowIndex = row.Index;
                            return; // Exit the search once a match is found
                        }
                    }
                }

                // No match found
                MessageBox.Show("No matching record found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void patientsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the PatientForm
            PatientForm patientForm = new PatientForm();

            // Show the PatientForm
            patientForm.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Get the selected row from patientsDGV
            DataGridViewRow selectedRow = patientsDGV.CurrentRow;

            if (selectedRow != null)
            {
                // Get the patient information from the selected row
                int patientID = Convert.ToInt32(selectedRow.Cells["PatientID"].Value);
                string petName = selectedRow.Cells["Pet"].Value.ToString();
                string ownerName = selectedRow.Cells["Owner"].Value.ToString();
                int petAge = Convert.ToInt32(selectedRow.Cells["Pet's Age"].Value);
                string gender = selectedRow.Cells["Gender"].Value.ToString();
                string contactNumber = selectedRow.Cells["ContactNumber"].Value.ToString();
                string address = selectedRow.Cells["Address"].Value.ToString();

                // Create an instance of the UpdatePatients form and pass the patient information
                UpdatePatients updateForm = new UpdatePatients(patientID, petName, ownerName, petAge, gender, contactNumber, address);
                updateForm.Show();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (patientsDGV.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this patient record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int patientID = Convert.ToInt32(patientsDGV.SelectedRows[0].Cells["PatientID"].Value);
                    patientsDGV.ClearSelection();
                    DeletePatientRecord(patientID);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private async void DeletePatientRecord(int patientID)
        {
            try
            {
                dbHelper.OpenConnection();

                string query = "DELETE FROM patients WHERE PatientID = @patientID;";
                using (SQLiteCommand cmd = new SQLiteCommand(query, dbHelper.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@patientID", patientID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Show success message after the DataGridView is refreshed
                        MessageBox.Show("Patient record deleted successfully.");
                        // Refresh the DataGridView after deletion
                        
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete patient record.");
                    }
                    LoadPatients();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }




    }
}
