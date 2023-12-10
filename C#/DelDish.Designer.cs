namespace C_
{
    partial class DelDish
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
            this.txtDishID = new System.Windows.Forms.TextBox();
            this.btnDeleteDish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDishID
            // 
            this.txtDishID.Location = new System.Drawing.Point(313, 92);
            this.txtDishID.Name = "txtDishID";
            this.txtDishID.Size = new System.Drawing.Size(123, 22);
            this.txtDishID.TabIndex = 0;
            this.txtDishID.Text = "ID блюда";
            // 
            // btnDeleteDish
            // 
            this.btnDeleteDish.Location = new System.Drawing.Point(313, 135);
            this.btnDeleteDish.Name = "btnDeleteDish";
            this.btnDeleteDish.Size = new System.Drawing.Size(123, 47);
            this.btnDeleteDish.TabIndex = 1;
            this.btnDeleteDish.Text = "Удалить";
            this.btnDeleteDish.UseVisualStyleBackColor = true;
            this.btnDeleteDish.Click += new System.EventHandler(this.btnDeleteDish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(271, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Удаление Блюд";
            // 
            // DelDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteDish);
            this.Controls.Add(this.txtDishID);
            this.Name = "DelDish";
            this.Text = "DelDish";
            this.Load += new System.EventHandler(this.DelDish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDishID;
        private System.Windows.Forms.Button btnDeleteDish;
        private System.Windows.Forms.Label label1;
    }
}