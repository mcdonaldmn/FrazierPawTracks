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
    public partial class BillingForm : Form
    {
        private SQLiteConnection connection;
        private string dbFilePath;

        public BillingForm()
        {
            InitializeComponent();
            dbFilePath = Path.Combine(Application.StartupPath, "Database", "pawtracks.db");
            InitializeDatabaseConnection();

            // Configure the DataGridView to allow editing and subscribe to the CellEndEdit event
            billingDGV.ReadOnly = false; // Allow editing
            billingDGV.CellEndEdit += BillingDGV_CellEndEdit; // Subscribe to CellEndEdit event

            LoadBillingData();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = $"Data Source={dbFilePath};Version=3;";
            connection = new SQLiteConnection(connectionString);
        }

        private void BillingDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == billingDGV.Columns["PaymentStatus"].Index && e.RowIndex >= 0)
            {
                int billID = Convert.ToInt32(billingDGV.Rows[e.RowIndex].Cells["BillID"].Value);
                string newPaymentStatus = billingDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Update the database with the new payment status
                UpdatePaymentStatusInDatabase(billID, newPaymentStatus);
            }
        }

        private void UpdatePaymentStatusInDatabase(int billID, string newPaymentStatus)
        {
            try
            {
                connection.Open();

                string query = "UPDATE billing SET PaymentStatus = @newPaymentStatus WHERE BillID = @billID;";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@newPaymentStatus", newPaymentStatus);
                    cmd.Parameters.AddWithValue("@billID", billID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Payment status updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Payment status update failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        public void LoadBillingData()
        {
            try
            {
                connection.Open();

                // Modify the SQL query to use SQLite syntax
                string query = "SELECT b.BillID, p.OwnerName, b.BillAmount, b.BillingDate, b.PaymentStatus " +
                               "FROM billing AS b " +
                               "INNER JOIN patients AS p ON b.PatientID = p.PatientID;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        billingDGV.DataSource = dataTable;

                        // Configure the DataGridView's appearance
                        billingDGV.AutoGenerateColumns = true;
                        billingDGV.AllowUserToAddRows = false;

                        // Set all columns except PaymentStatus to read-only
                        foreach (DataGridViewColumn column in billingDGV.Columns)
                        {
                            if (column.Name != "PaymentStatus")
                            {
                                column.ReadOnly = true;
                            }
                        }

                        billingDGV.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        private void searchTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchQuery = searchTB.Text.Trim();
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                FilterBillingData(searchQuery);
            }
            else
            {
                LoadBillingData(); // Reload all data when search query is empty
            }
        }

        private void FilterBillingData(string searchQuery)
        {
            try
            {
                connection.Open();

                string query = "SELECT b.BillID, p.OwnerName, b.BillAmount, b.BillingDate, b.PaymentStatus " +
                               "FROM billing AS b " +
                               "INNER JOIN patients AS p ON b.PatientID = p.PatientID " +
                               $"WHERE p.OwnerName LIKE @searchQuery OR b.PaymentStatus LIKE @searchQuery;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@searchQuery", $"%{searchQuery}%");

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        billingDGV.DataSource = dataTable;

                        billingDGV.AutoGenerateColumns = true;
                        billingDGV.AllowUserToAddRows = false;

                        foreach (DataGridViewColumn column in billingDGV.Columns)
                        {
                            if (column.Name != "PaymentStatus")
                            {
                                column.ReadOnly = true;
                            }
                        }

                        billingDGV.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        private void addBillButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the BillingForm
            AddBill addBillForm = new AddBill();

            // Show the BillingForm
            addBillForm.Show();
        }

        private void billingDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteBillingRecord(int billID)
        {
            try
            {
                connection.Open();

                string query = "DELETE FROM billing WHERE BillID = @billID;";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@billID", billID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Billing record deleted successfully.");
                        LoadBillingData(); // Refresh the DataGridView after deletion
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete billing record.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (billingDGV.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this billing record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int billID = Convert.ToInt32(billingDGV.SelectedRows[0].Cells["BillID"].Value);
                    DeleteBillingRecord(billID);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
