namespace C_
{
    partial class AddAcc
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
            this.txtAccountantName = new System.Windows.Forms.TextBox();
            this.txtAccountantSalary = new System.Windows.Forms.TextBox();
            this.btnAddAccountant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAccountantName
            // 
            this.txtAccountantName.Location = new System.Drawing.Point(313, 113);
            this.txtAccountantName.Name = "txtAccountantName";
            this.txtAccountantName.Size = new System.Drawing.Size(100, 22);
            this.txtAccountantName.TabIndex = 0;
            this.txtAccountantName.Text = "Имя";
            this.txtAccountantName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAccountantSalary
            // 
            this.txtAccountantSalary.Location = new System.Drawing.Point(313, 164);
            this.txtAccountantSalary.Name = "txtAccountantSalary";
            this.txtAccountantSalary.Size = new System.Drawing.Size(100, 22);
            this.txtAccountantSalary.TabIndex = 1;
            this.txtAccountantSalary.Text = "Зарплата";
            // 
            // btnAddAccountant
            // 
            this.btnAddAccountant.Location = new System.Drawing.Point(313, 202);
            this.btnAddAccountant.Name = "btnAddAccountant";
            this.btnAddAccountant.Size = new System.Drawing.Size(100, 37);
            this.btnAddAccountant.TabIndex = 2;
            this.btnAddAccountant.Text = "Добавить";
            this.btnAddAccountant.UseVisualStyleBackColor = true;
            this.btnAddAccountant.Click += new System.EventHandler(this.btnAddAccountant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(239, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Добавоение аккаунты";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddAccountant);
            this.Controls.Add(this.txtAccountantSalary);
            this.Controls.Add(this.txtAccountantName);
            this.Name = "AddAcc";
            this.Text = "AddAcc";
            this.Load += new System.EventHandler(this.AddAcc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountantName;
        private System.Windows.Forms.TextBox txtAccountantSalary;
        private System.Windows.Forms.Button btnAddAccountant;
        private System.Windows.Forms.Label label1;
    }
}