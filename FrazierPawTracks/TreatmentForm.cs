using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrazierPawTracks.Database;
using System.IO;

namespace FrazierPawTracks
{
    public partial class TreatmentForm : Form
    {
        private SQLiteHelper dbHelper;

        public TreatmentForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadTreatments();
        }

        private void InitializeDatabaseConnection()
        {
            string dbFilePath = Path.Combine(Application.StartupPath, "Database", "pawtracks.db");
            dbHelper = new SQLiteHelper(dbFilePath);
        }


        public void LoadTreatments(string searchKeyword = "")
        {
            try
            {
                dbHelper.OpenConnection();

                string query = "SELECT t.TreatmentID, p.PetName, t.TreatmentName, t.Veterinarian, t.Notes " +
                               "FROM treatments t " +
                               "INNER JOIN patients p ON t.PatientID = p.PatientID " +
                               "WHERE t.TreatmentName LIKE @SearchKeyword OR t.Veterinarian LIKE @SearchKeyword OR t.Notes LIKE @SearchKeyword;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, dbHelper.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    using (DataTable dataTable = new DataTable())
                    {
                        adapter.Fill(dataTable);

                        treatmentsDGV.DataSource = dataTable;

                        treatmentsDGV.AutoGenerateColumns = true;
                        treatmentsDGV.AllowUserToAddRows = false;
                        treatmentsDGV.ReadOnly = true;
                        treatmentsDGV.Refresh();
                    }
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
            string searchKeyword = searchTB.Text.Trim();

            treatmentsDGV.ClearSelection();

            foreach (DataGridViewRow row in treatmentsDGV.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().IndexOf(searchKeyword, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        row.Selected = true;
                        treatmentsDGV.FirstDisplayedScrollingRowIndex = row.Index;
                        return;
                    }
                }
            }

            MessageBox.Show("No matching row found.");
        }

        private void treatmentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addTreatmentButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the BillingForm
            AddTreatmentForm treatmentForm = new AddTreatmentForm();

            // Show the BillingForm
            treatmentForm.Show();
        }
    }
}
