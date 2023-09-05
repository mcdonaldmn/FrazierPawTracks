namespace FrazierPawTracks
{
    partial class PatientForm
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
            this.addressTB = new System.Windows.Forms.TextBox();
            this.contactNumberTB = new System.Windows.Forms.TextBox();
            this.ownerNameTB = new System.Windows.Forms.TextBox();
            this.petGenderTB = new System.Windows.Forms.TextBox();
            this.petAgeTB = new System.Windows.Forms.TextBox();
            this.petNameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newAppointment = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
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
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(190, 363);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(244, 20);
            this.addressTB.TabIndex = 30;
            this.addressTB.TextChanged += new System.EventHandler(this.addressTB_TextChanged);
            // 
            // contactNumberTB
            // 
            this.contactNumberTB.Location = new System.Drawing.Point(190, 305);
            this.contactNumberTB.Name = "contactNumberTB";
            this.contactNumberTB.Size = new System.Drawing.Size(244, 20);
            this.contactNumberTB.TabIndex = 29;
            this.contactNumberTB.TextChanged += new System.EventHandler(this.contactNumberTB_TextChanged);
            // 
            // ownerNameTB
            // 
            this.ownerNameTB.Location = new System.Drawing.Point(190, 250);
            this.ownerNameTB.Name = "ownerNameTB";
            this.ownerNameTB.Size = new System.Drawing.Size(244, 20);
            this.ownerNameTB.TabIndex = 28;
            this.ownerNameTB.TextChanged += new System.EventHandler(this.ownerNameTB_TextChanged);
            // 
            // petGenderTB
            // 
            this.petGenderTB.Location = new System.Drawing.Point(190, 191);
            this.petGenderTB.Name = "petGenderTB";
            this.petGenderTB.Size = new System.Drawing.Size(244, 20);
            this.petGenderTB.TabIndex = 27;
            this.petGenderTB.TextChanged += new System.EventHandler(this.petGenderTB_TextChanged);
            // 
            // petAgeTB
            // 
            this.petAgeTB.Location = new System.Drawing.Point(190, 144);
            this.petAgeTB.Name = "petAgeTB";
            this.petAgeTB.Size = new System.Drawing.Size(244, 20);
            this.petAgeTB.TabIndex = 26;
            this.petAgeTB.TextChanged += new System.EventHandler(this.petAgeTB_TextChanged);
            // 
            // petNameTB
            // 
            this.petNameTB.Location = new System.Drawing.Point(190, 100);
            this.petNameTB.Name = "petNameTB";
            this.petNameTB.Size = new System.Drawing.Size(244, 20);
            this.petNameTB.TabIndex = 25;
            this.petNameTB.TextChanged += new System.EventHandler(this.petNameTB_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Contact Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Pet\'s Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Pet\'s Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Owner\'s Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pet\'s Name:";
            // 
            // newAppointment
            // 
            this.newAppointment.AutoSize = true;
            this.newAppointment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAppointment.Location = new System.Drawing.Point(341, 17);
            this.newAppointment.Name = "newAppointment";
            this.newAppointment.Size = new System.Drawing.Size(93, 19);
            this.newAppointment.TabIndex = 32;
            this.newAppointment.Text = "New Patient";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(382, 421);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(76, 33);
            this.saveButton.TabIndex = 33;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 466);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newAppointment);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.contactNumberTB);
            this.Controls.Add(this.ownerNameTB);
            this.Controls.Add(this.petGenderTB);
            this.Controls.Add(this.petAgeTB);
            this.Controls.Add(this.petNameTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Name = "PatientForm";
            this.Text = "New Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox contactNumberTB;
        private System.Windows.Forms.TextBox ownerNameTB;
        private System.Windows.Forms.TextBox petGenderTB;
        private System.Windows.Forms.TextBox petAgeTB;
        private System.Windows.Forms.TextBox petNameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newAppointment;
        private System.Windows.Forms.Button saveButton;
    }
}