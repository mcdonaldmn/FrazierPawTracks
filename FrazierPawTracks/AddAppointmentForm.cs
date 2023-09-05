using FrazierPawTracks.Database;
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
using System.IO;

namespace FrazierPawTracks
{
    public partial class AddAppointmentForm : Form
    {
        private SQLiteHelper dbHelper;

        public AddAppointmentForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializePatientComboBox();

            // Initialize the DateTimePicker format
            appointmentDTP.Format = DateTimePickerFormat.Time;

        }

        private void InitializeDatabaseConnection()
        {
            string dbFilePath = Path.Combine(Application.StartupPath, "database", "pawtracks.db");
            dbHelper = new SQLiteHelper(dbFilePath);
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
                dbHelper.OpenConnection();

                // Prepare a SQL query to fetch patient information from the patients table
                string query = "SELECT PatientID, PetName, OwnerName, PetAge, Gender, ContactNumber, Address FROM patients;";

                using (SQLiteDataReader reader = dbHelper.ExecuteQuery(query))
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
                dbHelper.CloseConnection();
            }
        }



        private void appointmentDTP_ValueChanged(object sender, EventArgs e)
        {

        }


        private void patientView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void notesTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveAppointment();
        }

        private void SaveAppointment()
        {
            try
            {
                dbHelper.OpenConnection();

                int selectedPatientID = ((ComboboxItem)patientCB.SelectedItem).Value;
                DateTime appointmentDateTime = appointmentDTP.Value;
                string notes = notesTB.Text;

                string insertQuery = "INSERT INTO appointments (PatientID, AppointmentDateTime, Notes) " +
                                     "VALUES (@patientID, @appointmentDateTime, @notes);";

                using (SQLiteCommand command = new SQLiteCommand(insertQuery, dbHelper.GetConnection()))
                {
                    command.Parameters.AddWithValue("@patientID", selectedPatientID);
                    command.Parameters.AddWithValue("@appointmentDateTime", appointmentDateTime);
                    command.Parameters.AddWithValue("@notes", notes);

                    command.ExecuteNonQuery();  // Use ExecuteNonQuery for INSERT operations
                }

                // Close the form after successful insertion
                this.Close();

                // Show a message box to indicate successful appointment addition
                MessageBox.Show("Appointment Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the data grids in the MainForm
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                if (mainForm != null)
                {
                    mainForm.LoadAppointments();
                    mainForm.LoadUpcomingAppointments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding appointment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }



        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void patientCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
