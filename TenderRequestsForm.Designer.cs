namespace SPC
{
    partial class TenderRequestsForm
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
            this.dataGridViewTenders = new System.Windows.Forms.DataGridView();
            this.btnApproveTender = new System.Windows.Forms.Button();
            this.btnRejectTender = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTenders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTenders
            // 
            this.dataGridViewTenders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTenders.Location = new System.Drawing.Point(105, 142);
            this.dataGridViewTenders.Name = "dataGridViewTenders";
            this.dataGridViewTenders.RowTemplate.Height = 24;
            this.dataGridViewTenders.Size = new System.Drawing.Size(843, 354);
            this.dataGridViewTenders.TabIndex = 0;
            // 
            // btnApproveTender
            // 
            this.btnApproveTender.BackColor = System.Drawing.Color.Green;
            this.btnApproveTender.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproveTender.ForeColor = System.Drawing.Color.White;
            this.btnApproveTender.Location = new System.Drawing.Point(560, 540);
            this.btnApproveTender.Name = "btnApproveTender";
            this.btnApproveTender.Size = new System.Drawing.Size(131, 53);
            this.btnApproveTender.TabIndex = 1;
            this.btnApproveTender.Text = "Accept";
            this.btnApproveTender.UseVisualStyleBackColor = false;
            this.btnApproveTender.Click += new System.EventHandler(this.btnApproveTender_Click);
            // 
            // btnRejectTender
            // 
            this.btnRejectTender.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRejectTender.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejectTender.ForeColor = System.Drawing.Color.White;
            this.btnRejectTender.Location = new System.Drawing.Point(338, 540);
            this.btnRejectTender.Name = "btnRejectTender";
            this.btnRejectTender.Size = new System.Drawing.Size(131, 53);
            this.btnRejectTender.TabIndex = 1;
            this.btnRejectTender.Text = "Reject";
            this.btnRejectTender.UseVisualStyleBackColor = false;
            this.btnRejectTender.Click += new System.EventHandler(this.btnRejectTender_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(395, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tender Requests";
            // 
            // TenderRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1052, 656);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRejectTender);
            this.Controls.Add(this.btnApproveTender);
            this.Controls.Add(this.dataGridViewTenders);
            this.Name = "TenderRequestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TenderRequestsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTenders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTenders;
        private System.Windows.Forms.Button btnApproveTender;
        private System.Windows.Forms.Button btnRejectTender;
        private System.Windows.Forms.Label label1;
    }
}