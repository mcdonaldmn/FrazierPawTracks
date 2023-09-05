using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using FrazierPawTracks.Database;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FrazierPawTracks
{
    public partial class AddTreatmentForm : Form
    {
        private SQLiteConnection connection; 
        private string dbFilePath; 

        public AddTreatmentForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializePatientComboBox();

            dateTimePicker1.Value = DateTime.Now;
        }

        private void InitializeDatabaseConnection()
        {
            
            dbFilePath = Path.Combine(Application.StartupPath, "Database", "pawtracks.db");
            string connectionString = $"Data Source={dbFilePath};Version=3;";
            connection = new SQLiteConnection(connectionString);
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboboxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void InitializePatientComboBox()
        {
            try
            {
                connection.Open();

                // Prepare a SQL query to fetch patient information from the patients table
                string query = "SELECT PatientID, PetName, OwnerName, PetAge, Gender, ContactNumber, Address FROM patients;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        // Clear the existing items in the ComboBox
                        patientCB.Items.Clear();

                        while (reader.Read())
                        {
                            int patientID = reader.GetInt32(reader.GetOrdinal("PatientID"));
                            string petName = reader.GetString(reader.GetOrdinal("PetName"));
                            string ownerName = reader.GetString(reader.GetOrdinal("OwnerName"));
                            int petAge = reader.GetInt32(reader.GetOrdinal("PetAge"));
                            string gender = reader.GetString(reader.GetOrdinal("Gender"));
                            string contactNumber = reader.GetString(reader.GetOrdinal("ContactNumber"));
                            string address = reader.GetString(reader.GetOrdinal("Address"));

                            // Create a formatted patient information string
                            string patientInfo = $"ID: {patientID}, Pet: {petName}, Owner: {ownerName}, Age: {petAge}, Gender: {gender}, Contact: {contactNumber}, Address: {address}";

                            // Add the item to the ComboBox
                            patientCB.Items.Add(new ComboboxItem(patientInfo, patientID));
                        }
                    }
                }

                if (patientCB.Items.Count > 0)
                {
                    patientCB.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void patientCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treatmentTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void vetTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void notesTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                long selectedPatientID = ((ComboboxItem)patientCB.SelectedItem).Value; // Change the type to long
                string treatmentName = treatmentTB.Text.Trim();
                DateTime datePerformed = dateTimePicker1.Value;
                string veterinarian = vetTB.Text.Trim();
                string notes = notesTB.Text.Trim();

                // Validation: Check if all required fields are filled
                if (string.IsNullOrWhiteSpace(treatmentName) ||
                    string.IsNullOrWhiteSpace(veterinarian) ||
                    patientCB.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill out all required fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop further execution
                }

                string insertQuery = "INSERT INTO treatments (PatientID, TreatmentName, DatePerformed, Veterinarian, Notes) " +
                                     "VALUES (@patientID, @treatmentName, @datePerformed, @veterinarian, @notes);";

                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@patientID", selectedPatientID);
                    command.Parameters.AddWithValue("@treatmentName", treatmentName);
                    command.Parameters.AddWithValue("@datePerformed", datePerformed);
                    command.Parameters.AddWithValue("@veterinarian", veterinarian);
                    command.Parameters.AddWithValue("@notes", notes);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Treatment Added");

                // Clear input fields
                treatmentTB.Clear();
                vetTB.Clear();
                notesTB.Clear();
                // ...

                // Close the form after successful insertion
                this.Close();

                // If the parent form is an instance of TreatmentForm, refresh its treatmentsDGV
                if (Owner is TreatmentForm treatmentForm)
                {
                    treatmentForm.LoadTreatments(); // Call the method to refresh the view
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding treatment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }




        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
