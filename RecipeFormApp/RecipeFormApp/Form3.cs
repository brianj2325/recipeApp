using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeFormApp
{
    public partial class Form3 : Form
    {
        

        public Form3(String user)
        {
            InitializeComponent();
            lblDisplayUsername.Text = user;
        }

        private void recipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecipeForm recipeForm = new RecipeForm(lblDisplayUsername.Text);
            recipeForm.ShowDialog();
            this.Hide();

        }
    }
}
