using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using FrazierPawTracks.Database;

namespace FrazierPawTracks
{
    public partial class Reports : Form
    {
        private SQLiteConnection connection;
        private string dbFilePath;

        public Reports()
        {
            InitializeComponent();
            dbFilePath = Path.Combine(Application.StartupPath, "Database", "pawtracks.db");
            connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;");

            LoadReportTypes();
        }

        private void LoadReportTypes()
        {
            reportCB.Items.Add("Appointments Report");
            reportCB.Items.Add("Billing Report");
            reportCB.Items.Add("Patients Report");
            reportCB.Items.Add("Treatments Report");
            // Add more report types as needed
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // Clear previous report data
            dgvReports.DataSource = null;

            // Get the selected report type from the ComboBox
            string selectedReport = reportCB.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedReport))
            {
                MessageBox.Show("Please select a report type before generating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further execution
            }

            // Execute the appropriate method based on the selected report
            switch (selectedReport)
            {
                case "Appointments Report":
                    GenerateAppointmentsReport();
                    break;

                case "Billing Report":
                    GenerateBillingReport();
                    break;

                case "Patients Report":
                    GeneratePatientsReport();
                    break;

                case "Treatments Report":
                    GenerateTreatmentsReport();
                    break;

                // Add more cases for other report types

                default:
                    MessageBox.Show("Please select a valid report type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void GenerateAppointmentsReport()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string query = "SELECT AppointmentID, PatientID, AppointmentDateTime, Notes FROM appointments " +
                               "WHERE AppointmentDateTime BETWEEN @StartDate AND @EndDate;";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@StartDate", startDate.Value);
                    adapter.SelectCommand.Parameters.AddWithValue("@EndDate", endDate.Value);

                    DataTable reportData = new DataTable();
                    adapter.Fill(reportData);

                    dgvReports.DataSource = reportData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating the report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }



        private void GenerateBillingReport()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string query = "SELECT BillID, PatientID, AppointmentID, TreatmentID, BillAmount, BillingDate, PaymentStatus FROM billing " +
                               "WHERE BillingDate BETWEEN @StartDate AND @EndDate;";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@StartDate", startDate.Value);
                    adapter.SelectCommand.Parameters.AddWithValue("@EndDate", endDate.Value);

                    DataTable reportData = new DataTable();
                    adapter.Fill(reportData);

                    dgvReports.DataSource = reportData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating the report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void GeneratePatientsReport()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string query = "SELECT PatientID, PetName, OwnerName, PetAge, Gender, ContactNumber, Address FROM patients;";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    DataTable reportData = new DataTable();
                    adapter.Fill(reportData);

                    dgvReports.DataSource = reportData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating the report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void GenerateTreatmentsReport()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string query = "SELECT TreatmentID, PatientID, TreatmentName, DatePerformed, Veterinarian, Notes FROM treatments " +
                               "WHERE DatePerformed BETWEEN @StartDate AND @EndDate;";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@StartDate", startDate.Value);
                    adapter.SelectCommand.Parameters.AddWithValue("@EndDate", endDate.Value);

                    DataTable reportData = new DataTable();
                    adapter.Fill(reportData);

                    dgvReports.DataSource = reportData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating the report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }




        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
