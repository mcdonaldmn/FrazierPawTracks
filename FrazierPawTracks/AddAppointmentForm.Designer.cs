namespace FrazierPawTracks
{
    partial class AddAppointmentForm
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
            this.newAppointment = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.notesTB = new System.Windows.Forms.RichTextBox();
            this.appointmentDTP = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.patientCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(12, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(233, 27);
            this.logo.TabIndex = 2;
            this.logo.Text = "FrazierPawTracks";
            // 
            // newAppointment
            // 
            this.newAppointment.AutoSize = true;
            this.newAppointment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAppointment.Location = new System.Drawing.Point(297, 15);
            this.newAppointment.Name = "newAppointment";
            this.newAppointment.Size = new System.Drawing.Size(136, 19);
            this.newAppointment.TabIndex = 3;
            this.newAppointment.Text = "New Appointment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Notes:";
            // 
            // notesTB
            // 
            this.notesTB.Location = new System.Drawing.Point(17, 255);
            this.notesTB.Name = "notesTB";
            this.notesTB.Size = new System.Drawing.Size(416, 104);
            this.notesTB.TabIndex = 17;
            this.notesTB.Text = "";
            this.notesTB.TextChanged += new System.EventHandler(this.notesTB_TextChanged);
            // 
            // appointmentDTP
            // 
            this.appointmentDTP.Location = new System.Drawing.Point(233, 88);
            this.appointmentDTP.Name = "appointmentDTP";
            this.appointmentDTP.Size = new System.Drawing.Size(200, 20);
            this.appointmentDTP.TabIndex = 18;
            this.appointmentDTP.ValueChanged += new System.EventHandler(this.appointmentDTP_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Appointment Date and Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Patient";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(357, 391);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(76, 31);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(275, 391);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(76, 31);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // patientCB
            // 
            this.patientCB.FormattingEnabled = true;
            this.patientCB.Location = new System.Drawing.Point(111, 171);
            this.patientCB.Name = "patientCB";
            this.patientCB.Size = new System.Drawing.Size(322, 21);
            this.patientCB.TabIndex = 24;
            this.patientCB.SelectedIndexChanged += new System.EventHandler(this.patientCB_SelectedIndexChanged);
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 476);
            this.Controls.Add(this.patientCB);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.appointmentDTP);
            this.Controls.Add(this.notesTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.newAppointment);
            this.Controls.Add(this.logo);
            this.Name = "AddAppointmentForm";
            this.Text = "AddAppointmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label newAppointment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox notesTB;
        private System.Windows.Forms.DateTimePicker appointmentDTP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox patientCB;
    }
}