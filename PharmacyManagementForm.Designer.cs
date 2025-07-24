namespace SPC
{
    partial class PharmacyManagementForm
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
            this.dataGridViewPharmacies = new System.Windows.Forms.DataGridView();
            this.btnRegisterPharmacy = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.radioSPC = new System.Windows.Forms.RadioButton();
            this.radioDealer = new System.Windows.Forms.RadioButton();
            this.btnDeletePharmacy = new System.Windows.Forms.Button();
            this.btnUpdatePharmacy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPharmacies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPharmacies
            // 
            this.dataGridViewPharmacies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPharmacies.Location = new System.Drawing.Point(100, 355);
            this.dataGridViewPharmacies.Name = "dataGridViewPharmacies";
            this.dataGridViewPharmacies.RowTemplate.Height = 24;
            this.dataGridViewPharmacies.Size = new System.Drawing.Size(787, 307);
            this.dataGridViewPharmacies.TabIndex = 0;
            // 
            // btnRegisterPharmacy
            // 
            this.btnRegisterPharmacy.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRegisterPharmacy.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterPharmacy.ForeColor = System.Drawing.Color.White;
            this.btnRegisterPharmacy.Location = new System.Drawing.Point(759, 103);
            this.btnRegisterPharmacy.Name = "btnRegisterPharmacy";
            this.btnRegisterPharmacy.Size = new System.Drawing.Size(128, 47);
            this.btnRegisterPharmacy.TabIndex = 1;
            this.btnRegisterPharmacy.Text = "Register";
            this.btnRegisterPharmacy.UseVisualStyleBackColor = false;
            this.btnRegisterPharmacy.Click += new System.EventHandler(this.btnRegisterPharmacy_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(406, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 25);
            this.txtName.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(406, 155);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(276, 25);
            this.txtAddress.TabIndex = 2;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(406, 201);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(276, 25);
            this.txtContact.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(406, 249);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(276, 25);
            this.txtPassword.TabIndex = 2;
            // 
            // radioSPC
            // 
            this.radioSPC.AutoSize = true;
            this.radioSPC.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSPC.Location = new System.Drawing.Point(419, 296);
            this.radioSPC.Name = "radioSPC";
            this.radioSPC.Size = new System.Drawing.Size(60, 24);
            this.radioSPC.TabIndex = 3;
            this.radioSPC.TabStop = true;
            this.radioSPC.Text = "SPC";
            this.radioSPC.UseVisualStyleBackColor = true;
            // 
            // radioDealer
            // 
            this.radioDealer.AutoSize = true;
            this.radioDealer.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDealer.Location = new System.Drawing.Point(552, 297);
            this.radioDealer.Name = "radioDealer";
            this.radioDealer.Size = new System.Drawing.Size(84, 24);
            this.radioDealer.TabIndex = 3;
            this.radioDealer.TabStop = true;
            this.radioDealer.Text = "Dealer";
            this.radioDealer.UseVisualStyleBackColor = true;
            // 
            // btnDeletePharmacy
            // 
            this.btnDeletePharmacy.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDeletePharmacy.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePharmacy.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeletePharmacy.Location = new System.Drawing.Point(759, 270);
            this.btnDeletePharmacy.Name = "btnDeletePharmacy";
            this.btnDeletePharmacy.Size = new System.Drawing.Size(128, 47);
            this.btnDeletePharmacy.TabIndex = 1;
            this.btnDeletePharmacy.Text = "Delete";
            this.btnDeletePharmacy.UseVisualStyleBackColor = false;
            this.btnDeletePharmacy.Click += new System.EventHandler(this.btnDeletePharmacy_Click);
            // 
            // btnUpdatePharmacy
            // 
            this.btnUpdatePharmacy.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUpdatePharmacy.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePharmacy.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePharmacy.Location = new System.Drawing.Point(759, 186);
            this.btnUpdatePharmacy.Name = "btnUpdatePharmacy";
            this.btnUpdatePharmacy.Size = new System.Drawing.Size(128, 47);
            this.btnUpdatePharmacy.TabIndex = 1;
            this.btnUpdatePharmacy.Text = "Update";
            this.btnUpdatePharmacy.UseVisualStyleBackColor = false;
            this.btnUpdatePharmacy.Click += new System.EventHandler(this.btnUpdatePharmacy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(315, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(367, 34);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pharmacy Management";
            // 
            // PharmacyManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(990, 696);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioDealer);
            this.Controls.Add(this.radioSPC);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnUpdatePharmacy);
            this.Controls.Add(this.btnDeletePharmacy);
            this.Controls.Add(this.btnRegisterPharmacy);
            this.Controls.Add(this.dataGridViewPharmacies);
            this.Name = "PharmacyManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PharmacyManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPharmacies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPharmacies;
        private System.Windows.Forms.Button btnRegisterPharmacy;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton radioSPC;
        private System.Windows.Forms.RadioButton radioDealer;
        private System.Windows.Forms.Button btnDeletePharmacy;
        private System.Windows.Forms.Button btnUpdatePharmacy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}