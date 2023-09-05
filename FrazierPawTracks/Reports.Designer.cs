namespace FrazierPawTracks
{
    partial class Reports
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
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.generateButton = new System.Windows.Forms.Button();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.end = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.reportCB = new System.Windows.Forms.ComboBox();
            this.dateRange = new System.Windows.Forms.Label();
            this.reportTypeLabel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.LightBlue;
            this.closeButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(522, 499);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(85, 36);
            this.closeButton.TabIndex = 19;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(17, 267);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.Size = new System.Drawing.Size(590, 218);
            this.dgvReports.TabIndex = 18;
            this.dgvReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReports_CellContentClick);
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.LightBlue;
            this.generateButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(264, 225);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(85, 36);
            this.generateButton.TabIndex = 17;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(407, 172);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 20);
            this.endDate.TabIndex = 16;
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(100, 170);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 20);
            this.startDate.TabIndex = 15;
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.Location = new System.Drawing.Point(326, 172);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(75, 19);
            this.end.TabIndex = 14;
            this.end.Text = "End Date:";
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(11, 170);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(83, 19);
            this.start.TabIndex = 13;
            this.start.Text = "Start Date:";
            // 
            // reportCB
            // 
            this.reportCB.FormattingEnabled = true;
            this.reportCB.Location = new System.Drawing.Point(118, 68);
            this.reportCB.Name = "reportCB";
            this.reportCB.Size = new System.Drawing.Size(231, 21);
            this.reportCB.TabIndex = 12;
            // 
            // dateRange
            // 
            this.dateRange.AutoSize = true;
            this.dateRange.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRange.Location = new System.Drawing.Point(11, 133);
            this.dateRange.Name = "dateRange";
            this.dateRange.Size = new System.Drawing.Size(91, 19);
            this.dateRange.TabIndex = 11;
            this.dateRange.Text = "Date Range:";
            // 
            // reportTypeLabel
            // 
            this.reportTypeLabel.AutoSize = true;
            this.reportTypeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTypeLabel.Location = new System.Drawing.Point(11, 67);
            this.reportTypeLabel.Name = "reportTypeLabel";
            this.reportTypeLabel.Size = new System.Drawing.Size(101, 19);
            this.reportTypeLabel.TabIndex = 10;
            this.reportTypeLabel.Text = "Report Type: ";
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(12, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(233, 27);
            this.logo.TabIndex = 35;
            this.logo.Text = "FrazierPawTracks";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 566);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.reportCB);
            this.Controls.Add(this.dateRange);
            this.Controls.Add(this.reportTypeLabel);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.ComboBox reportCB;
        private System.Windows.Forms.Label dateRange;
        private System.Windows.Forms.Label reportTypeLabel;
        private System.Windows.Forms.Label logo;
    }
}