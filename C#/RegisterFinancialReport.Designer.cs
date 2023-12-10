namespace C_
{
    partial class RegisterFinancialReport
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
            this.btnRegisterFinancialReport = new System.Windows.Forms.Button();
            this.txtOperationDetails = new System.Windows.Forms.TextBox();
            this.cmbOperationType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegisterFinancialReport
            // 
            this.btnRegisterFinancialReport.Location = new System.Drawing.Point(341, 220);
            this.btnRegisterFinancialReport.Name = "btnRegisterFinancialReport";
            this.btnRegisterFinancialReport.Size = new System.Drawing.Size(121, 40);
            this.btnRegisterFinancialReport.TabIndex = 5;
            this.btnRegisterFinancialReport.Text = "Регистрация отчетов ";
            this.btnRegisterFinancialReport.UseVisualStyleBackColor = true;
            this.btnRegisterFinancialReport.Click += new System.EventHandler(this.btnRegisterFinancialReport_Click);
            // 
            // txtOperationDetails
            // 
            this.txtOperationDetails.Location = new System.Drawing.Point(341, 178);
            this.txtOperationDetails.Name = "txtOperationDetails";
            this.txtOperationDetails.Size = new System.Drawing.Size(121, 22);
            this.txtOperationDetails.TabIndex = 4;
            this.txtOperationDetails.Text = "Описание";
            this.txtOperationDetails.TextChanged += new System.EventHandler(this.txtOperationDetails_TextChanged);
            // 
            // cmbOperationType
            // 
            this.cmbOperationType.FormattingEnabled = true;
            this.cmbOperationType.Items.AddRange(new object[] {
            "Доход",
            "Расход",
            "т.д"});
            this.cmbOperationType.Location = new System.Drawing.Point(341, 136);
            this.cmbOperationType.Name = "cmbOperationType";
            this.cmbOperationType.Size = new System.Drawing.Size(121, 24);
            this.cmbOperationType.TabIndex = 3;
            this.cmbOperationType.Text = "Операция";
            this.cmbOperationType.SelectedIndexChanged += new System.EventHandler(this.cmbOperationType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(202, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Регистрация Финансовых Отчётов";
            // 
            // RegisterFinancialReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegisterFinancialReport);
            this.Controls.Add(this.txtOperationDetails);
            this.Controls.Add(this.cmbOperationType);
            this.Name = "RegisterFinancialReport";
            this.Text = "RegisterFinancialReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterFinancialReport;
        private System.Windows.Forms.TextBox txtOperationDetails;
        private System.Windows.Forms.ComboBox cmbOperationType;
        private System.Windows.Forms.Label label1;
    }
}