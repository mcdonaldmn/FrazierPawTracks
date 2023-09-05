namespace FrazierPawTracks
{
    partial class BillingForm
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
            this.Billing = new System.Windows.Forms.Label();
            this.addBillButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.billingDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.billingDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Billing
            // 
            this.Billing.AutoSize = true;
            this.Billing.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billing.Location = new System.Drawing.Point(542, 12);
            this.Billing.Name = "Billing";
            this.Billing.Size = new System.Drawing.Size(60, 23);
            this.Billing.TabIndex = 28;
            this.Billing.Text = "Billing";
            // 
            // addBillButton
            // 
            this.addBillButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBillButton.Location = new System.Drawing.Point(12, 328);
            this.addBillButton.Name = "addBillButton";
            this.addBillButton.Size = new System.Drawing.Size(132, 29);
            this.addBillButton.TabIndex = 27;
            this.addBillButton.Text = "Add Bill";
            this.addBillButton.UseVisualStyleBackColor = true;
            this.addBillButton.Click += new System.EventHandler(this.addBillButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(542, 348);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 29);
            this.closeButton.TabIndex = 26;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(319, 114);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(298, 20);
            this.searchTB.TabIndex = 25;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(238, 108);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 29);
            this.searchButton.TabIndex = 24;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // billingDGV
            // 
            this.billingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingDGV.Location = new System.Drawing.Point(12, 147);
            this.billingDGV.Name = "billingDGV";
            this.billingDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billingDGV.Size = new System.Drawing.Size(605, 175);
            this.billingDGV.TabIndex = 23;
            this.billingDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billingDGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "FrazierPawTracks";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(150, 328);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(132, 29);
            this.deleteButton.TabIndex = 29;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 422);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.Billing);
            this.Controls.Add(this.addBillButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.billingDGV);
            this.Controls.Add(this.label1);
            this.Name = "BillingForm";
            this.Text = "BillingPage";
            ((System.ComponentModel.ISupportInitialize)(this.billingDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Billing;
        private System.Windows.Forms.Button addBillButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView billingDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
    }
}