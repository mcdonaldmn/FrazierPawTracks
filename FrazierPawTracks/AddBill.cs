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
    public partial class AddBill : Form
    {

        private SQLiteConnection connection;
        private string dbFilePath;

        public AddBill()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializePatientComboBox();

            // Initialize appointment and treatment combo boxes with default values
            if (patientCB.SelectedItem is ComboboxItem selectedPatient)
            {
                InitializeAppointmentComboBox(selectedPatient.Value);
            }

            if (appointmentCB.SelectedItem is ComboboxItem selectedAppointment)
            {
                InitializeTreatmentComboBox(selectedAppointment.Value);
            }
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

        private void OpenConnectionIfClosed()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        private void InitializePatientComboBox()
        {
            try
            {
                OpenConnectionIfClosed();

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
                            int patientID = reader.GetInt32(0);
                            string petName = reader.GetString(1);
                            string ownerName = reader.GetString(2);
                            int petAge = reader.GetInt32(3);
                            string gender = reader.GetString(4);
                            string contactNumber = reader.GetString(5);
                            string address = reader.GetString(6);

                            // Create a formatted patient information string
                            string patientInfo = $"ID: {patientID}, Pet: {petName}, Owner: {ownerName}, Age: {petAge}, Gender: {gender}, Contact: {contactNumber}, Address: {address}";

                            // Add the item to the ComboBox
                            patientCB.Items.Add(new ComboboxItem(patientInfo, patientID));
                        }

                        if (patientCB.Items.Count > 0)
                        {
                            patientCB.SelectedIndex = 0;
                        }
                    }
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



        private void InitializeAppointmentComboBox(int patientID)
        {
            try
            {
                OpenConnectionIfClosed();

                string query = $"SELECT AppointmentID, AppointmentDateTime FROM appointments WHERE PatientID = {patientID};";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        appointmentCB.Items.Clear();

                        while (reader.Read())
                        {
                            int appointmentID = reader.GetInt32(0);
                            DateTime appointmentDateTime = reader.GetDateTime(1);

                            appointmentCB.Items.Add(new ComboboxItem(appointmentDateTime.ToString(), appointmentID));
                        }

                        if (appointmentCB.Items.Count > 0)
                        {
                            appointmentCB.SelectedIndex = 0;
                        }
                    }
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

        private void InitializeTreatmentComboBox(int patientID)
        {
            try
            {
                OpenConnectionIfClosed();

                string query = $"SELECT TreatmentID, TreatmentName FROM treatments WHERE PatientID = {patientID}";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        treatmentCB.Items.Clear();

                        while (reader.Read())
                        {
                            int treatmentID = reader.GetInt32(0);
                            string treatmentName = reader.GetString(1);

                            Console.WriteLine($"Debug: TreatmentID: {treatmentID}, TreatmentName: {treatmentName}");

                            treatmentCB.Items.Add(new ComboboxItem(treatmentName, treatmentID));
                        }

                        if (treatmentCB.Items.Count > 0)
                        {
                            treatmentCB.SelectedIndex = 0;
                        }
                    }
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
            if (patientCB.SelectedItem is ComboboxItem selectedPatient)
            {
                // Populate the appointment combo box based on the selected patient's ID
                InitializeAppointmentComboBox(selectedPatient.Value);
            }
        }

        private void appointmentCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (appointmentCB.SelectedItem is ComboboxItem selectedAppointment)
            {
                // Populate the treatment combo box based on the selected appointment's ID
                InitializeTreatmentComboBox(selectedAppointment.Value);
            }
        }

        private void treatmentCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void amountDueTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void billingDTP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void paymentStatusCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paymentStatusCB.SelectedItem != null)
            {
                string selectedPaymentStatus = paymentStatusCB.SelectedItem.ToString();
                // Use the selectedPaymentStatus as needed
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnectionIfClosed();

                // Extract data from the UI controls
                int patientID = ((ComboboxItem)patientCB.SelectedItem).Value;
                int appointmentID = ((ComboboxItem)appointmentCB.SelectedItem).Value;
                int treatmentID = ((ComboboxItem)treatmentCB.SelectedItem).Value;
                decimal billAmount = decimal.Parse(amountDueTB.Text);
                DateTime billingDate = billingDTP.Value;
                string paymentStatus = paymentStatusCB.SelectedItem.ToString();

                // Prepare the SQL query to insert data into the billing table
                string query = $@"
            INSERT INTO billing (PatientID, AppointmentID, TreatmentID, BillAmount, BillingDate, PaymentStatus)
            VALUES ({patientID}, {appointmentID}, {treatmentID}, {billAmount}, '{billingDate:yyyy-MM-dd}', '{paymentStatus}')";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Billing information saved successfully!");

                // Clear UI controls
                amountDueTB.Clear();
                billingDTP.Value = DateTime.Now;
                paymentStatusCB.SelectedIndex = -1;

                // Refresh the DataGridView in the BillingForm
                if (Application.OpenForms["BillingForm"] is BillingForm billingForm)
                {
                    billingForm.LoadBillingData();
                }

                this.Close();
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

    }
}
