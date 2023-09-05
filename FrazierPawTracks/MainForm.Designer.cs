namespace FrazierPawTracks
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logo = new System.Windows.Forms.Label();
            this.tdapp = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.schedAppointmentButton = new System.Windows.Forms.Button();
            this.treatmentRecordsButton = new System.Windows.Forms.Button();
            this.billingButton = new System.Windows.Forms.Button();
            this.patientsButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(12, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(233, 27);
            this.logo.TabIndex = 1;
            this.logo.Text = "FrazierPawTracks";
            // 
            // tdapp
            // 
            this.tdapp.AutoSize = true;
            this.tdapp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdapp.Location = new System.Drawing.Point(12, 69);
            this.tdapp.Name = "tdapp";
            this.tdapp.Size = new System.Drawing.Size(166, 19);
            this.tdapp.TabIndex = 2;
            this.tdapp.Text = "Today\'s Appointments:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(346, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Upcoming Appointments:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(17, 335);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(346, 150);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // schedAppointmentButton
            // 
            this.schedAppointmentButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedAppointmentButton.Location = new System.Drawing.Point(477, 170);
            this.schedAppointmentButton.Name = "schedAppointmentButton";
            this.schedAppointmentButton.Size = new System.Drawing.Size(190, 36);
            this.schedAppointmentButton.TabIndex = 7;
            this.schedAppointmentButton.Text = "Schedule Appointment";
            this.schedAppointmentButton.UseVisualStyleBackColor = true;
            this.schedAppointmentButton.Click += new System.EventHandler(this.schedAppointmentButton_Click);
            // 
            // treatmentRecordsButton
            // 
            this.treatmentRecordsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentRecordsButton.Location = new System.Drawing.Point(477, 233);
            this.treatmentRecordsButton.Name = "treatmentRecordsButton";
            this.treatmentRecordsButton.Size = new System.Drawing.Size(190, 36);
            this.treatmentRecordsButton.TabIndex = 8;
            this.treatmentRecordsButton.Text = "Treatment Records";
            this.treatmentRecordsButton.UseVisualStyleBackColor = true;
            this.treatmentRecordsButton.Click += new System.EventHandler(this.treatmentRecordsButton_Click);
            // 
            // billingButton
            // 
            this.billingButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingButton.Location = new System.Drawing.Point(477, 296);
            this.billingButton.Name = "billingButton";
            this.billingButton.Size = new System.Drawing.Size(190, 36);
            this.billingButton.TabIndex = 9;
            this.billingButton.Text = "Billing";
            this.billingButton.UseVisualStyleBackColor = true;
            this.billingButton.Click += new System.EventHandler(this.billingButton_Click);
            // 
            // patientsButton
            // 
            this.patientsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsButton.Location = new System.Drawing.Point(477, 109);
            this.patientsButton.Name = "patientsButton";
            this.patientsButton.Size = new System.Drawing.Size(190, 36);
            this.patientsButton.TabIndex = 11;
            this.patientsButton.Text = "Patient Records";
            this.patientsButton.UseVisualStyleBackColor = true;
            this.patientsButton.Click += new System.EventHandler(this.patientsButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.Location = new System.Drawing.Point(477, 362);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(190, 36);
            this.reportsButton.TabIndex = 12;
            this.reportsButton.Text = "Reports";
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 597);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.patientsButton);
            this.Controls.Add(this.billingButton);
            this.Controls.Add(this.treatmentRecordsButton);
            this.Controls.Add(this.schedAppointmentButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tdapp);
            this.Controls.Add(this.logo);
            this.Name = "MainForm";
            this.Text = "FrazierPawTracks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label tdapp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button schedAppointmentButton;
        private System.Windows.Forms.Button treatmentRecordsButton;
        private System.Windows.Forms.Button billingButton;
        private System.Windows.Forms.Button patientsButton;
        private System.Windows.Forms.Button reportsButton;
    }
}