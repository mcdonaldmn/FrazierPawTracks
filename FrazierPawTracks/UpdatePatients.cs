using FrazierPawTracks.Database;
using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace FrazierPawTracks
{
    public partial class UpdatePatients : Form
    {
        private SQLiteHelper dbHelper;
        private int PatientID; // Declare the PatientID field

        public UpdatePatients(int patientID, string petName, string ownerName, int petAge, string gender, string contactNumber, string address)
        {
            InitializeComponent();

            InitializeDatabaseConnection();

            // Populate input fields with patient information
            petNameTB.Text = petName;
            ownerNameTB.Text = ownerName;
            petAgeTB.Text = petAge.ToString();
            petGenderTB.Text = gender;
            contactNumberTB.Text = contactNumber;
            addressTB.Text = address;

            // Store the patient ID for further processing
            PatientID = patientID;
        }

        private void InitializeDatabaseConnection()
        {
            string dbFilePath = Path.Combine(Application.StartupPath, "Database", "pawtracks.db");
            dbHelper = new SQLiteHelper(dbFilePath);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void petNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void petAgeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void petGenderTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ownerNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactNumberTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string updatedPetName = petNameTB.Text.Trim();
            string updatedOwnerName = ownerNameTB.Text.Trim();
            string updatedPetAgeText = petAgeTB.Text.Trim();
            string updatedGender = petGenderTB.Text.Trim();
            string updatedContactNumber = contactNumberTB.Text.Trim();
            string updatedAddress = addressTB.Text.Trim();

            // Validate that all fields are filled out
            if (string.IsNullOrEmpty(updatedPetName) || string.IsNullOrEmpty(updatedOwnerName) ||
                string.IsNullOrEmpty(updatedPetAgeText) || string.IsNullOrEmpty(updatedGender) ||
                string.IsNullOrEmpty(updatedContactNumber) || string.IsNullOrEmpty(updatedAddress))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate updatedPetAge as an integer
            if (!int.TryParse(updatedPetAgeText, out int updatedPetAge))
            {
                MessageBox.Show("Pet Age must be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                dbHelper.OpenConnection();

                // Update patient information in the database
                string query = "UPDATE patients SET PetName = @petName, OwnerName = @ownerName, " +
                               "PetAge = @petAge, Gender = @gender, ContactNumber = @contactNumber, Address = @address " +
                               "WHERE PatientID = @patientID;";

                using (SQLiteCommand command = new SQLiteCommand(query, dbHelper.GetConnection()))
                {
                    command.Parameters.AddWithValue("@petName", updatedPetName);
                    command.Parameters.AddWithValue("@ownerName", updatedOwnerName);
                    command.Parameters.AddWithValue("@petAge", updatedPetAge);
                    command.Parameters.AddWithValue("@gender", updatedGender);
                    command.Parameters.AddWithValue("@contactNumber", updatedContactNumber);
                    command.Parameters.AddWithValue("@address", updatedAddress);
                    command.Parameters.AddWithValue("@patientID", PatientID);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Patient information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the patientsDGV in PatientRecords form
                    if (Application.OpenForms["PatientRecords"] is PatientRecords patientRecordsForm)
                    {
                        patientRecordsForm.LoadPatients();
                    }

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating patient information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }

    }
}
