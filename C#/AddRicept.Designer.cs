namespace C_
{
    partial class AddRicept
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
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.txtRecipeDetails = new System.Windows.Forms.TextBox();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(326, 231);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(137, 29);
            this.btnAddRecipe.TabIndex = 12;
            this.btnAddRecipe.Text = "Добавить Рецепт";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // txtRecipeDetails
            // 
            this.txtRecipeDetails.Location = new System.Drawing.Point(326, 189);
            this.txtRecipeDetails.Name = "txtRecipeDetails";
            this.txtRecipeDetails.Size = new System.Drawing.Size(137, 22);
            this.txtRecipeDetails.TabIndex = 11;
            this.txtRecipeDetails.Text = "Рецепт";
            // 
            // txtDishName
            // 
            this.txtDishName.Location = new System.Drawing.Point(326, 147);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(137, 22);
            this.txtDishName.TabIndex = 10;
            this.txtDishName.Text = "Блюдо";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(305, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Добавить рецепт";
            // 
            // AddRicept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.txtRecipeDetails);
            this.Controls.Add(this.txtDishName);
            this.Name = "AddRicept";
            this.Text = "AddRicept";
            this.Load += new System.EventHandler(this.AddRicept_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.TextBox txtRecipeDetails;
        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.Label label1;
    }
}