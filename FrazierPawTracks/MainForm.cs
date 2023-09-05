using FrazierPawTracks.Database;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrazierPawTracks
{
    public partial class MainForm : Form
    {
        private SQLiteHelper dbHelper;
        public MainForm()
        {
            InitializeComponent();

            // Initialize the SQLiteHelper with the database path
            string dbFilePath = Path.Combine(Application.StartupPath, "Database", "pawtracks.db");
            dbHelper = new SQLiteHelper(dbFilePath);

            // Load appointments into the DataGridView
            LoadAppointments();

            // Load upcoming appointments into dataGridView2
            LoadUpcomingAppointments();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load appointments into the DataGridView
            LoadAppointments();

            // Load upcoming appointments into dataGridView2
            LoadUpcomingAppointments();
        }

        public void LoadAppointments()
        {
            try
            {
                dbHelper.OpenConnection();

                DateTime today = DateTime.Today;

                string query = "SELECT strftime('%H:%M', a.AppointmentDateTime) AS Time, p.PetName, p.OwnerName " +
                               "FROM appointments a " +
                               "INNER JOIN patients p ON a.PatientID = p.PatientID " +
                               "WHERE date(a.AppointmentDateTime) = date(@TodayDate);";

                SQLiteParameter[] todayParameters = { new SQLiteParameter("@TodayDate", today.ToString("yyyy-MM-dd")) };

                using (SQLiteDataReader reader = dbHelper.ExecuteQuery(query, todayParameters))
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.ReadOnly = true;
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

        public void LoadUpcomingAppointments()
        {
            try
            {
                dbHelper.OpenConnection();

                DateTime currentDateTime = DateTime.Now;

                string query = "SELECT a.AppointmentDateTime, p.PetName, p.OwnerName " +
                               "FROM appointments a " +
                               "INNER JOIN patients p ON a.PatientID = p.PatientID " +
                               "WHERE a.AppointmentDateTime > @CurrentDateTime " +
                               "ORDER BY a.AppointmentDateTime;";

                SQLiteParameter[] currentDateTimeParameters = { new SQLiteParameter("@CurrentDateTime", currentDateTime.ToString("yyyy-MM-dd HH:mm:ss")) };

                using (SQLiteDataReader reader = dbHelper.ExecuteQuery(query, currentDateTimeParameters))
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    dataGridView2.DataSource = dataTable;
                    dataGridView2.AutoGenerateColumns = true;
                    dataGridView2.AllowUserToAddRows = false;
                    dataGridView2.ReadOnly = true;
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



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void schedAppointmentButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the AddAppointmentForm
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm();

            // Show the AddAppointmentForm
            addAppointmentForm.Show();
        }

        private void treatmentRecordsButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the TreatmentForm
            TreatmentForm treatmentForm = new TreatmentForm();

            // Show the TreatmentForm
            treatmentForm.Show();
        }

        private void billingButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the BillingForm
            BillingForm billingForm = new BillingForm();

            // Show the BillingForm
            billingForm.Show();
        }

        private void patientsButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the PatientForm
            PatientRecords patientRecords = new PatientRecords();

            // Show the PatientForm
            patientRecords.Show();
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            
            Reports reports = new Reports();

            
            reports.Show();
        }
    }
}
