namespace FrazierPawTracks
{
    partial class TreatmentForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.treatmentsDGV = new System.Windows.Forms.DataGridView();
            this.Treatments = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Label();
            this.addTreatmentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(542, 351);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 29);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(319, 117);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(298, 20);
            this.searchTB.TabIndex = 12;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(238, 111);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 29);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // treatmentsDGV
            // 
            this.treatmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treatmentsDGV.Location = new System.Drawing.Point(12, 150);
            this.treatmentsDGV.Name = "treatmentsDGV";
            this.treatmentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.treatmentsDGV.Size = new System.Drawing.Size(605, 175);
            this.treatmentsDGV.TabIndex = 10;
            this.treatmentsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.treatmentsDGV_CellContentClick);
            // 
            // Treatments
            // 
            this.Treatments.AutoSize = true;
            this.Treatments.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Treatments.Location = new System.Drawing.Point(516, 14);
            this.Treatments.Name = "Treatments";
            this.Treatments.Size = new System.Drawing.Size(101, 23);
            this.Treatments.TabIndex = 9;
            this.Treatments.Text = "Treatments";
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(12, 10);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(233, 27);
            this.logo.TabIndex = 8;
            this.logo.Text = "FrazierPawTracks";
            // 
            // addTreatmentButton
            // 
            this.addTreatmentButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTreatmentButton.Location = new System.Drawing.Point(12, 331);
            this.addTreatmentButton.Name = "addTreatmentButton";
            this.addTreatmentButton.Size = new System.Drawing.Size(132, 29);
            this.addTreatmentButton.TabIndex = 14;
            this.addTreatmentButton.Text = "Add Treatment";
            this.addTreatmentButton.UseVisualStyleBackColor = true;
            this.addTreatmentButton.Click += new System.EventHandler(this.addTreatmentButton_Click);
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 403);
            this.Controls.Add(this.addTreatmentButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.treatmentsDGV);
            this.Controls.Add(this.Treatments);
            this.Controls.Add(this.logo);
            this.Name = "TreatmentForm";
            this.Text = "TreatmentTracking";
            ((System.ComponentModel.ISupportInitialize)(this.treatmentsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView treatmentsDGV;
        private System.Windows.Forms.Label Treatments;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Button addTreatmentButton;
    }
}