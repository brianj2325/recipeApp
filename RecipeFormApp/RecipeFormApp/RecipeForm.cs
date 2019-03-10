using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RecipeFormApp
{
    public partial class RecipeForm : Form
    {
        string connectionString = @"Data Source = OfficeComputer\SQLEXPRESS; Initial Catalog = RecipeDB; Integrated Security=True;";
        string username;

        public RecipeForm(String user)
        {
            InitializeComponent();
            username = user;
            lbl_username.Text = username;
        }

        private void RecipeForm_Load(object sender, EventArgs e)
        {


        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection recipeConnection = new SqlConnection(connectionString))
            {
                recipeConnection.Open();

                SqlCommand sqlCmd = new SqlCommand("AddIngredient", recipeConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@RecipeName", txtRecipeName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@IngredientName", txtIngredientName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Amount", txt_Amount.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Unit", combo_Unit.Text.Trim());


                sqlCmd.ExecuteNonQuery();
                // TODO: This line of code loads data into the 'ingredientData.tblIngredients' table. You can move, or remove it, as needed.
                this.tblIngredientsTableAdapter.Fill(this.ingredientData.tblIngredients);

                ClearIngredient();

                // recipeConnection.Close();

            }
        }

        void ClearIngredient()
        {
            txtIngredientName.Text = txt_Amount.Text = "";
            combo_Unit.Text = "";
        }
        void Clear()
        {
            txtRecipeName.Text = combo_cookHours.Text = combo_cookMinutes.Text = combo_Meal.Text = combo_prepHours.Text = combo_prepMinutes.Text = "";
        }

        private void btn_submitRecipe_Click(object sender, EventArgs e)
        {
            using (SqlConnection recipeConnection = new SqlConnection(connectionString))
            {
                recipeConnection.Open();

                SqlCommand sqlCmd = new SqlCommand("AddRecipe", recipeConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@RecipeName", txtRecipeName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Meal", combo_Meal.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@PrepMinutes", combo_prepMinutes.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@PrepHours", combo_prepHours.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@CookMinutes", combo_cookMinutes.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@CookHours", combo_cookHours.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Author", username);
                sqlCmd.Parameters.AddWithValue("@CookTemp", combo_cookTemp.Text.Trim());

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Recipe was Added");
                Clear();

            }
        }

        private void btn_addDirection_Click(object sender, EventArgs e)
        {
            using (SqlConnection recipeConnection = new SqlConnection(connectionString))
            {
                recipeConnection.Open();

                SqlCommand sqlCmd = new SqlCommand("AddDirections", recipeConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@DirectionNumber", txtRecipeName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Direction", txtIngredientName.Text.Trim());
                //sqlCmd.Parameters.AddWithValue("@RecipeID", getRecipeID());



                sqlCmd.ExecuteNonQuery();


                txt_Direction.Text = "";

                // recipeConnection.Close();

            }
        }

        private void getRecipeID()
        {
            using (SqlConnection recipeConnection = new SqlConnection(connectionString))
            {
                recipeConnection.Open();
                SqlCommand command;
                SqlDataReader sqlDataReader;
                String sql, output = "";

                sql = "SELECT RecipeID FROM tblRecipe where";
                command = new SqlCommand(sql, recipeConnection);
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    output = output + sqlDataReader.GetValue(0);
                }
                lbl_recipeID.Text = output ;
            }



            //private int getRecipeID()
            //{

            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        connection.Open();

            //        SqlCommand command;
            //        SqlDataReader dataReader;
            //        String sql = "";
            //            int output;

            //        sql = "SELECT RecipeID FROM tblRecipe WHERE RecipeName='" + txtRecipeName.Text + "'";
            //        command = new SqlCommand(sql, connection);

            //        dataReader = command.ExecuteReader();

            //        output = (dataReader.GetInt32()).ToString();

            //        return output;



            //    }

            //}
        }

        private void btn_getRecipeID_Click(object sender, EventArgs e)
        {
            getRecipeID();
        }

        public DataTable GetDataTable()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM tblRecipe";
            SqlCommand cmd = new SqlCommand(query, conn);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            return dt;
        }
    }
}
