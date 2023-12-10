namespace C_
{
    partial class AddDish
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
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.txtDishPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDishName
            // 
            this.txtDishName.Location = new System.Drawing.Point(322, 144);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(131, 22);
            this.txtDishName.TabIndex = 9;
            this.txtDishName.Text = "Блюдо";
            // 
            // btnAddDish
            // 
            this.btnAddDish.Location = new System.Drawing.Point(322, 226);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(131, 32);
            this.btnAddDish.TabIndex = 8;
            this.btnAddDish.Text = "Добавить Блюдо";
            this.btnAddDish.UseVisualStyleBackColor = true;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // txtDishPrice
            // 
            this.txtDishPrice.Location = new System.Drawing.Point(322, 184);
            this.txtDishPrice.Name = "txtDishPrice";
            this.txtDishPrice.Size = new System.Drawing.Size(131, 22);
            this.txtDishPrice.TabIndex = 7;
            this.txtDishPrice.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(284, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Добавить Блюдо";
            // 
            // AddDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDishName);
            this.Controls.Add(this.btnAddDish);
            this.Controls.Add(this.txtDishPrice);
            this.Name = "AddDish";
            this.Text = "AddDish";
            this.Load += new System.EventHandler(this.AddDish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.TextBox txtDishPrice;
        private System.Windows.Forms.Label label1;
    }
}