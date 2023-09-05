using FrazierPawTracks.Database;
using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace FrazierPawTracks
{
    public partial class PatientForm : Form
    {
        private SQLiteHelper dbHelper;

        public PatientForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            string dbFilePath = Path.Combine(Application.StartupPath, "database", "pawtracks.db");
            dbHelper = new SQLiteHelper(dbFilePath);
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
            string petName = petNameTB.Text.Trim();
            string ownerName = ownerNameTB.Text.Trim();
            string petAgeText = petAgeTB.Text.Trim();
            string gender = petGenderTB.Text.Trim();
            string contactNumber = contactNumberTB.Text.Trim();
            string address = addressTB.Text.Trim();

            // Validate that all fields are filled out
            if (string.IsNullOrEmpty(petName) || string.IsNullOrEmpty(ownerName) ||
                string.IsNullOrEmpty(petAgeText) || string.IsNullOrEmpty(gender) ||
                string.IsNullOrEmpty(contactNumber) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate petAge as an integer
            if (!int.TryParse(petAgeText, out int petAge))
            {
                MessageBox.Show("Pet Age must be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                dbHelper.OpenConnection();

                // Prepare the SQL query to insert a new patient
                string query = "INSERT INTO patients (PetName, OwnerName, PetAge, Gender, ContactNumber, Address) " +
                               "VALUES (@petName, @ownerName, @petAge, @gender, @contactNumber, @address);";

                using (SQLiteCommand command = new SQLiteCommand(query, dbHelper.GetConnection()))
                {
                    command.Parameters.AddWithValue("@petName", petName);
                    command.Parameters.AddWithValue("@ownerName", ownerName);
                    command.Parameters.AddWithValue("@petAge", petAge);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@contactNumber", contactNumber);
                    command.Parameters.AddWithValue("@address", address);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Patient added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the input fields after adding the patient
                    petNameTB.Clear();
                    ownerNameTB.Clear();
                    petAgeTB.Clear();
                    petGenderTB.Clear();
                    contactNumberTB.Clear();
                    addressTB.Clear();

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
                MessageBox.Show("Error adding patient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }

    }
}
