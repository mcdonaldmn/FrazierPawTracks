using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrazierPawTracks
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InitializeDatabase();

            Application.Run(new LoginPage());
        }

        static void InitializeDatabase()
        {
            string dbFolderPath = Path.Combine(Application.StartupPath, "Database");
            string dbFilePath = Path.Combine(dbFolderPath, "pawtracks.db");

            if (!File.Exists(dbFilePath))
            {
                Directory.CreateDirectory(dbFolderPath);
                SQLiteConnection.CreateFile(dbFilePath);

                using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        // Create tables
                        command.CommandText = @"
                            CREATE TABLE IF NOT EXISTS users (
                                UserID INTEGER PRIMARY KEY,
                                Username VARCHAR(50),
                                Password VARCHAR(50)
                            );
                            CREATE TABLE IF NOT EXISTS patients (
                                PatientID INTEGER PRIMARY KEY,
                                PetName VARCHAR(100),
                                OwnerName VARCHAR(100),
                                PetAge INTEGER,
                                Gender VARCHAR(10),
                                ContactNumber VARCHAR(20),
                                Address TEXT
                            );
                            CREATE TABLE IF NOT EXISTS treatments (
                                TreatmentID INTEGER PRIMARY KEY,
                                PatientID INTEGER,
                                TreatmentName VARCHAR(100),
                                DatePerformed DATE,
                                Veterinarian VARCHAR(100),
                                Notes TEXT,
                                FOREIGN KEY (PatientID) REFERENCES patients(PatientID)
                            );
                            CREATE TABLE IF NOT EXISTS appointments (
                                AppointmentId INTEGER PRIMARY KEY,
                                PatientID INTEGER,
                                AppointmentDateTime DATETIME,
                                Notes TEXT,
                                FOREIGN KEY (PatientID) REFERENCES patients(PatientID)
                            );
                            CREATE TABLE IF NOT EXISTS billing (
                                BillID INTEGER PRIMARY KEY,
                                PatientID INTEGER,
                                AppointmentID INTEGER,
                                TreatmentID INTEGER,
                                BillAmount DECIMAL(10, 2),
                                BillingDate DATE,
                                PaymentStatus VARCHAR(20),
                                FOREIGN KEY (PatientID) REFERENCES patients(PatientID),
                                FOREIGN KEY (AppointmentID) REFERENCES appointments(AppointmentId),
                                FOREIGN KEY (TreatmentID) REFERENCES treatments(TreatmentID)
                            );
                        ";
                        command.ExecuteNonQuery();

                        // Insert data
                        command.CommandText = @"
                            INSERT INTO patients (PetName, OwnerName, PetAge, Gender, ContactNumber, Address)
                            VALUES
                                ('Fluffy', 'John Doe', 3, 'Male', '123-456-7890', '123 Main St'),
                                ('Buddy', 'Jane Smith', 5, 'Female', '987-654-3210', '456 Elm St');
                            INSERT INTO treatments (PatientID, TreatmentName, DatePerformed, Veterinarian, Notes)
                            VALUES
                                (1, 'Vaccination', '2023-08-15', 'Dr. Johnson', 'Routine vaccination'),
                                (2, 'Checkup', '2023-07-20', 'Dr. Williams', 'Annual checkup');
                            INSERT INTO appointments (PatientID, AppointmentDateTime, Notes)
                            VALUES
                                (1, '2023-08-25 10:00:00', 'Follow-up appointment'),
                                (2, '2023-09-10 15:30:00', 'Discussion about diet');
                            INSERT INTO billing (PatientID, AppointmentID, TreatmentID, BillAmount, BillingDate, PaymentStatus)
                            VALUES
                                (1, 1, NULL, 50.00, '2023-08-25', 'Pending'),
                                (2, NULL, 2, 75.50, '2023-09-15', 'Paid');
                            INSERT INTO users (Username, Password)
                            VALUES
                                ('test', 'test');
                        ";
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
