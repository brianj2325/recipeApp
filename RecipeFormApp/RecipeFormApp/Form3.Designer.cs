namespace RecipeFormApp
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDisplayUsername = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseRecipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome ";
            // 
            // lblDisplayUsername
            // 
            this.lblDisplayUsername.AutoSize = true;
            this.lblDisplayUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayUsername.Location = new System.Drawing.Point(339, 36);
            this.lblDisplayUsername.Name = "lblDisplayUsername";
            this.lblDisplayUsername.Size = new System.Drawing.Size(251, 39);
            this.lblDisplayUsername.TabIndex = 0;
            this.lblDisplayUsername.Text = "                          ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recipeToolStripMenuItem,
            this.browseRecipesToolStripMenuItem,
            this.shoppingListToolStripMenuItem,
            this.timerToolStripMenuItem,
            this.accountSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recipeToolStripMenuItem
            // 
            this.recipeToolStripMenuItem.Name = "recipeToolStripMenuItem";
            this.recipeToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.recipeToolStripMenuItem.Text = "Add Recipe";
            this.recipeToolStripMenuItem.Click += new System.EventHandler(this.recipeToolStripMenuItem_Click);
            // 
            // browseRecipesToolStripMenuItem
            // 
            this.browseRecipesToolStripMenuItem.Name = "browseRecipesToolStripMenuItem";
            this.browseRecipesToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.browseRecipesToolStripMenuItem.Text = "Browse Recipes";
            // 
            // shoppingListToolStripMenuItem
            // 
            this.shoppingListToolStripMenuItem.Name = "shoppingListToolStripMenuItem";
            this.shoppingListToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.shoppingListToolStripMenuItem.Text = "Shopping List";
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.timerToolStripMenuItem.Text = "Timer";
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisplayUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisplayUsername;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseRecipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoppingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
    }
}