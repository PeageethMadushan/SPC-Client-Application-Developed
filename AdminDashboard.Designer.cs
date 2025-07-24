namespace SPC
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.btnPostAd = new System.Windows.Forms.Button();
            this.btnViewTenders = new System.Windows.Forms.Button();
            this.btnViewSuppliers = new System.Windows.Forms.Button();
            this.btnAddDrugs = new System.Windows.Forms.Button();
            this.btnRegisterPharmacy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPostAd
            // 
            this.btnPostAd.BackColor = System.Drawing.Color.SlateGray;
            this.btnPostAd.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostAd.ForeColor = System.Drawing.Color.White;
            this.btnPostAd.Location = new System.Drawing.Point(273, 192);
            this.btnPostAd.Name = "btnPostAd";
            this.btnPostAd.Size = new System.Drawing.Size(190, 89);
            this.btnPostAd.TabIndex = 0;
            this.btnPostAd.Text = "Advertisements";
            this.btnPostAd.UseVisualStyleBackColor = false;
            this.btnPostAd.Click += new System.EventHandler(this.btnPostAd_Click);
            // 
            // btnViewTenders
            // 
            this.btnViewTenders.BackColor = System.Drawing.Color.SlateGray;
            this.btnViewTenders.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTenders.ForeColor = System.Drawing.Color.White;
            this.btnViewTenders.Location = new System.Drawing.Point(547, 192);
            this.btnViewTenders.Name = "btnViewTenders";
            this.btnViewTenders.Size = new System.Drawing.Size(190, 89);
            this.btnViewTenders.TabIndex = 1;
            this.btnViewTenders.Text = "Tenders";
            this.btnViewTenders.UseVisualStyleBackColor = false;
            this.btnViewTenders.Click += new System.EventHandler(this.btnViewTenders_Click);
            // 
            // btnViewSuppliers
            // 
            this.btnViewSuppliers.BackColor = System.Drawing.Color.SlateGray;
            this.btnViewSuppliers.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSuppliers.ForeColor = System.Drawing.Color.White;
            this.btnViewSuppliers.Location = new System.Drawing.Point(273, 315);
            this.btnViewSuppliers.Name = "btnViewSuppliers";
            this.btnViewSuppliers.Size = new System.Drawing.Size(190, 89);
            this.btnViewSuppliers.TabIndex = 2;
            this.btnViewSuppliers.Text = "Suppliers";
            this.btnViewSuppliers.UseVisualStyleBackColor = false;
            this.btnViewSuppliers.Click += new System.EventHandler(this.btnViewSuppliers_Click);
            // 
            // btnAddDrugs
            // 
            this.btnAddDrugs.BackColor = System.Drawing.Color.SlateGray;
            this.btnAddDrugs.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDrugs.ForeColor = System.Drawing.Color.White;
            this.btnAddDrugs.Location = new System.Drawing.Point(273, 449);
            this.btnAddDrugs.Name = "btnAddDrugs";
            this.btnAddDrugs.Size = new System.Drawing.Size(464, 80);
            this.btnAddDrugs.TabIndex = 3;
            this.btnAddDrugs.Text = "Drugs";
            this.btnAddDrugs.UseVisualStyleBackColor = false;
            this.btnAddDrugs.Click += new System.EventHandler(this.btnAddDrugs_Click);
            // 
            // btnRegisterPharmacy
            // 
            this.btnRegisterPharmacy.BackColor = System.Drawing.Color.SlateGray;
            this.btnRegisterPharmacy.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterPharmacy.ForeColor = System.Drawing.Color.White;
            this.btnRegisterPharmacy.Location = new System.Drawing.Point(547, 315);
            this.btnRegisterPharmacy.Name = "btnRegisterPharmacy";
            this.btnRegisterPharmacy.Size = new System.Drawing.Size(190, 89);
            this.btnRegisterPharmacy.TabIndex = 4;
            this.btnRegisterPharmacy.Text = "Pharmacies";
            this.btnRegisterPharmacy.UseVisualStyleBackColor = false;
            this.btnRegisterPharmacy.Click += new System.EventHandler(this.btnRegisterPharmacy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(77, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Administrator";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(460, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegisterPharmacy);
            this.Controls.Add(this.btnAddDrugs);
            this.Controls.Add(this.btnViewSuppliers);
            this.Controls.Add(this.btnViewTenders);
            this.Controls.Add(this.btnPostAd);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPostAd;
        private System.Windows.Forms.Button btnViewTenders;
        private System.Windows.Forms.Button btnViewSuppliers;
        private System.Windows.Forms.Button btnAddDrugs;
        private System.Windows.Forms.Button btnRegisterPharmacy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}