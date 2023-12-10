namespace C_
{
    partial class UpdAcc
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
            this.txtAccountantID = new System.Windows.Forms.TextBox();
            this.btnUpdateSalary = new System.Windows.Forms.Button();
            this.txtNewSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAccountantID
            // 
            this.txtAccountantID.Location = new System.Drawing.Point(335, 109);
            this.txtAccountantID.Name = "txtAccountantID";
            this.txtAccountantID.Size = new System.Drawing.Size(100, 22);
            this.txtAccountantID.TabIndex = 0;
            this.txtAccountantID.Text = "ID accaunt";
            this.txtAccountantID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdateSalary
            // 
            this.btnUpdateSalary.Location = new System.Drawing.Point(335, 185);
            this.btnUpdateSalary.Name = "btnUpdateSalary";
            this.btnUpdateSalary.Size = new System.Drawing.Size(100, 31);
            this.btnUpdateSalary.TabIndex = 1;
            this.btnUpdateSalary.Text = "Обновить";
            this.btnUpdateSalary.UseVisualStyleBackColor = true;
            this.btnUpdateSalary.Click += new System.EventHandler(this.btnUpdateSalary_Click);
            // 
            // txtNewSalary
            // 
            this.txtNewSalary.Location = new System.Drawing.Point(335, 144);
            this.txtNewSalary.Name = "txtNewSalary";
            this.txtNewSalary.Size = new System.Drawing.Size(100, 22);
            this.txtNewSalary.TabIndex = 2;
            this.txtNewSalary.Text = "Зарплата";
            this.txtNewSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(259, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Обновление Зарплаты";
            // 
            // UpdAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewSalary);
            this.Controls.Add(this.btnUpdateSalary);
            this.Controls.Add(this.txtAccountantID);
            this.Name = "UpdAcc";
            this.Text = "UpdAcc";
            this.Load += new System.EventHandler(this.UpdAcc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountantID;
        private System.Windows.Forms.Button btnUpdateSalary;
        private System.Windows.Forms.TextBox txtNewSalary;
        private System.Windows.Forms.Label label1;
    }
}