namespace C_
{
    partial class DellAcc
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
            this.btnDeleteAccountant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAccountantID
            // 
            this.txtAccountantID.Location = new System.Drawing.Point(296, 111);
            this.txtAccountantID.Name = "txtAccountantID";
            this.txtAccountantID.Size = new System.Drawing.Size(131, 22);
            this.txtAccountantID.TabIndex = 0;
            this.txtAccountantID.Text = "ID accaunt";
            // 
            // btnDeleteAccountant
            // 
            this.btnDeleteAccountant.Location = new System.Drawing.Point(296, 155);
            this.btnDeleteAccountant.Name = "btnDeleteAccountant";
            this.btnDeleteAccountant.Size = new System.Drawing.Size(131, 37);
            this.btnDeleteAccountant.TabIndex = 1;
            this.btnDeleteAccountant.Text = "Удалить";
            this.btnDeleteAccountant.UseVisualStyleBackColor = true;
            this.btnDeleteAccountant.Click += new System.EventHandler(this.btnDeleteAccountant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(227, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Удаление Аккаунта";
            // 
            // DellAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteAccountant);
            this.Controls.Add(this.txtAccountantID);
            this.Name = "DellAcc";
            this.Text = "DellAcc";
            this.Load += new System.EventHandler(this.DellAcc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountantID;
        private System.Windows.Forms.Button btnDeleteAccountant;
        private System.Windows.Forms.Label label1;
    }
}