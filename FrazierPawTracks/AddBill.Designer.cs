namespace FrazierPawTracks
{
    partial class AddBill
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
            this.saveButton = new System.Windows.Forms.Button();
            this.newBill = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Label();
            this.patientCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.appointmentCB = new System.Windows.Forms.ComboBox();
            this.appointment = new System.Windows.Forms.Label();
            this.treatmentCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.paymentStatusCB = new System.Windows.Forms.ComboBox();
            this.amountDueTB = new System.Windows.Forms.TextBox();
            this.billingDTP = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(331, 411);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(76, 33);
            this.saveButton.TabIndex = 48;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newBill
            // 
            this.newBill.AutoSize = true;
            this.newBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBill.Location = new System.Drawing.Point(341, 15);
            this.newBill.Name = "newBill";
            this.newBill.Size = new System.Drawing.Size(65, 19);
            this.newBill.TabIndex = 47;
            this.newBill.Text = "New Bill";
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(12, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(233, 27);
            this.logo.TabIndex = 34;
            this.logo.Text = "FrazierPawTracks";
            // 
            // patientCB
            // 
            this.patientCB.FormattingEnabled = true;
            this.patientCB.Location = new System.Drawing.Point(118, 91);
            this.patientCB.Name = "patientCB";
            this.patientCB.Size = new System.Drawing.Size(288, 21);
            this.patientCB.TabIndex = 50;
            this.patientCB.SelectedIndexChanged += new System.EventHandler(this.patientCB_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 49;
            this.label7.Text = "Patient";
            // 
            // appointmentCB
            // 
            this.appointmentCB.FormattingEnabled = true;
            this.appointmentCB.Location = new System.Drawing.Point(119, 143);
            this.appointmentCB.Name = "appointmentCB";
            this.appointmentCB.Size = new System.Drawing.Size(288, 21);
            this.appointmentCB.TabIndex = 52;
            this.appointmentCB.SelectedIndexChanged += new System.EventHandler(this.appointmentCB_SelectedIndexChanged);
            // 
            // appointment
            // 
            this.appointment.AutoSize = true;
            this.appointment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointment.Location = new System.Drawing.Point(12, 143);
            this.appointment.Name = "appointment";
            this.appointment.Size = new System.Drawing.Size(101, 19);
            this.appointment.TabIndex = 51;
            this.appointment.Text = "Appointment";
            // 
            // treatmentCB
            // 
            this.treatmentCB.FormattingEnabled = true;
            this.treatmentCB.Location = new System.Drawing.Point(118, 199);
            this.treatmentCB.Name = "treatmentCB";
            this.treatmentCB.Size = new System.Drawing.Size(288, 21);
            this.treatmentCB.TabIndex = 54;
            this.treatmentCB.SelectedIndexChanged += new System.EventHandler(this.treatmentCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "Treatment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 55;
            this.label2.Text = "Amount Due";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 56;
            this.label3.Text = "Billing Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 57;
            this.label4.Text = "Payment Status";
            // 
            // paymentStatusCB
            // 
            this.paymentStatusCB.FormattingEnabled = true;
            this.paymentStatusCB.Items.AddRange(new object[] {
            "Pending",
            "Paid"});
            this.paymentStatusCB.Location = new System.Drawing.Point(150, 342);
            this.paymentStatusCB.Name = "paymentStatusCB";
            this.paymentStatusCB.Size = new System.Drawing.Size(256, 21);
            this.paymentStatusCB.TabIndex = 58;
            this.paymentStatusCB.SelectedIndexChanged += new System.EventHandler(this.paymentStatusCB_SelectedIndexChanged);
            // 
            // amountDueTB
            // 
            this.amountDueTB.Location = new System.Drawing.Point(212, 248);
            this.amountDueTB.Name = "amountDueTB";
            this.amountDueTB.Size = new System.Drawing.Size(194, 20);
            this.amountDueTB.TabIndex = 59;
            this.amountDueTB.TextChanged += new System.EventHandler(this.amountDueTB_TextChanged);
            // 
            // billingDTP
            // 
            this.billingDTP.Location = new System.Drawing.Point(206, 297);
            this.billingDTP.Name = "billingDTP";
            this.billingDTP.Size = new System.Drawing.Size(200, 20);
            this.billingDTP.TabIndex = 60;
            this.billingDTP.ValueChanged += new System.EventHandler(this.billingDTP_ValueChanged);
            // 
            // AddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 491);
            this.Controls.Add(this.billingDTP);
            this.Controls.Add(this.amountDueTB);
            this.Controls.Add(this.paymentStatusCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treatmentCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appointmentCB);
            this.Controls.Add(this.appointment);
            this.Controls.Add(this.patientCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newBill);
            this.Controls.Add(this.logo);
            this.Name = "AddBill";
            this.Text = "AddBill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label newBill;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.ComboBox patientCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox appointmentCB;
        private System.Windows.Forms.Label appointment;
        private System.Windows.Forms.ComboBox treatmentCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox paymentStatusCB;
        private System.Windows.Forms.TextBox amountDueTB;
        private System.Windows.Forms.DateTimePicker billingDTP;
    }
}