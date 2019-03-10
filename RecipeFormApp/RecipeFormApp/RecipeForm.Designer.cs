namespace RecipeFormApp
{
    partial class RecipeForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.recipeDBDataSet = new RecipeFormApp.RecipeDBDataSet();
            this.tblIngredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblIngredientTableAdapter = new RecipeFormApp.RecipeDBDataSetTableAdapters.tblIngredientTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tblIngredientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeDBDataSet2 = new RecipeFormApp.RecipeDBDataSet2();
            this.recipeDBDataSet1 = new RecipeFormApp.RecipeDBDataSet1();
            this.tblIngredientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblIngredientTableAdapter1 = new RecipeFormApp.RecipeDBDataSet1TableAdapters.tblIngredientTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIngredientName = new System.Windows.Forms.TextBox();
            this.ingredientsTableAdapter = new RecipeFormApp.RecipeDBDataSet2TableAdapters.IngredientsTableAdapter();
            this.combo_Unit = new System.Windows.Forms.ComboBox();
            this.combo_Meal = new System.Windows.Forms.ComboBox();
            this.combo_prepMinutes = new System.Windows.Forms.ComboBox();
            this.combo_cookMinutes = new System.Windows.Forms.ComboBox();
            this.combo_prepHours = new System.Windows.Forms.ComboBox();
            this.combo_cookHours = new System.Windows.Forms.ComboBox();
            this.combo_cookTemp = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Direction = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recipeDBDataSet3 = new RecipeFormApp.RecipeDBDataSet3();
            this.tblDirectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDirectionsTableAdapter = new RecipeFormApp.RecipeDBDataSet3TableAdapters.tblDirectionsTableAdapter();
            this.directionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_submitRecipe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_recipeID = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.ingredientData = new RecipeFormApp.IngredientData();
            this.tblIngredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblIngredientsTableAdapter = new RecipeFormApp.IngredientDataTableAdapters.tblIngredientsTableAdapter();
            this.ingredientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addDirection = new System.Windows.Forms.Button();
            this.btn_getRecipeID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDirectionsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a Recipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(157, 95);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(156, 20);
            this.txtRecipeName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Meal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prep Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Minutes";
            // 
            // recipeDBDataSet
            // 
            this.recipeDBDataSet.DataSetName = "RecipeDBDataSet";
            this.recipeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblIngredientBindingSource
            // 
            this.tblIngredientBindingSource.DataMember = "tblIngredient";
            this.tblIngredientBindingSource.DataSource = this.recipeDBDataSet;
            // 
            // tblIngredientTableAdapter
            // 
            this.tblIngredientTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cook Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Hours";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Minutes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Oven Temperature";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(227, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Degrees ";
            // 
            // tblIngredientBindingSource1
            // 
            this.tblIngredientBindingSource1.DataMember = "tblIngredient";
            this.tblIngredientBindingSource1.DataSource = this.recipeDBDataSet;
            // 
            // ingredientsBindingSource
            // 
            this.ingredientsBindingSource.DataMember = "Ingredients";
            this.ingredientsBindingSource.DataSource = this.recipeDBDataSet2;
            // 
            // recipeDBDataSet2
            // 
            this.recipeDBDataSet2.DataSetName = "RecipeDBDataSet2";
            this.recipeDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipeDBDataSet1
            // 
            this.recipeDBDataSet1.DataSetName = "RecipeDBDataSet1";
            this.recipeDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblIngredientBindingSource2
            // 
            this.tblIngredientBindingSource2.DataMember = "tblIngredient";
            this.tblIngredientBindingSource2.DataSource = this.recipeDBDataSet1;
            // 
            // tblIngredientTableAdapter1
            // 
            this.tblIngredientTableAdapter1.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(311, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 32);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Ingredient Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Amount";
            // 
            // txtIngredientName
            // 
            this.txtIngredientName.Location = new System.Drawing.Point(123, 23);
            this.txtIngredientName.Name = "txtIngredientName";
            this.txtIngredientName.Size = new System.Drawing.Size(156, 20);
            this.txtIngredientName.TabIndex = 15;
            // 
            // ingredientsTableAdapter
            // 
            this.ingredientsTableAdapter.ClearBeforeFill = true;
            // 
            // combo_Unit
            // 
            this.combo_Unit.FormattingEnabled = true;
            this.combo_Unit.Items.AddRange(new object[] {
            "Cups",
            "Tablespoons",
            "Teaspoons",
            "Liters",
            "Milliliters",
            "Ounces"});
            this.combo_Unit.Location = new System.Drawing.Point(220, 57);
            this.combo_Unit.Name = "combo_Unit";
            this.combo_Unit.Size = new System.Drawing.Size(59, 21);
            this.combo_Unit.TabIndex = 22;
            // 
            // combo_Meal
            // 
            this.combo_Meal.FormattingEnabled = true;
            this.combo_Meal.Location = new System.Drawing.Point(157, 138);
            this.combo_Meal.Name = "combo_Meal";
            this.combo_Meal.Size = new System.Drawing.Size(156, 21);
            this.combo_Meal.TabIndex = 2;
            // 
            // combo_prepMinutes
            // 
            this.combo_prepMinutes.FormattingEnabled = true;
            this.combo_prepMinutes.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.combo_prepMinutes.Location = new System.Drawing.Point(268, 185);
            this.combo_prepMinutes.Name = "combo_prepMinutes";
            this.combo_prepMinutes.Size = new System.Drawing.Size(45, 21);
            this.combo_prepMinutes.TabIndex = 23;
            // 
            // combo_cookMinutes
            // 
            this.combo_cookMinutes.FormattingEnabled = true;
            this.combo_cookMinutes.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.combo_cookMinutes.Location = new System.Drawing.Point(268, 214);
            this.combo_cookMinutes.Name = "combo_cookMinutes";
            this.combo_cookMinutes.Size = new System.Drawing.Size(45, 21);
            this.combo_cookMinutes.TabIndex = 23;
            // 
            // combo_prepHours
            // 
            this.combo_prepHours.FormattingEnabled = true;
            this.combo_prepHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "Other"});
            this.combo_prepHours.Location = new System.Drawing.Point(157, 185);
            this.combo_prepHours.Name = "combo_prepHours";
            this.combo_prepHours.Size = new System.Drawing.Size(64, 21);
            this.combo_prepHours.TabIndex = 24;
            // 
            // combo_cookHours
            // 
            this.combo_cookHours.FormattingEnabled = true;
            this.combo_cookHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "Other"});
            this.combo_cookHours.Location = new System.Drawing.Point(157, 214);
            this.combo_cookHours.Name = "combo_cookHours";
            this.combo_cookHours.Size = new System.Drawing.Size(64, 21);
            this.combo_cookHours.TabIndex = 24;
            // 
            // combo_cookTemp
            // 
            this.combo_cookTemp.FormattingEnabled = true;
            this.combo_cookTemp.Items.AddRange(new object[] {
            "0",
            "200",
            "250",
            "275",
            "300",
            "325",
            "350",
            "375",
            "400",
            "425",
            "450",
            "475",
            "500",
            "Other"});
            this.combo_cookTemp.Location = new System.Drawing.Point(157, 243);
            this.combo_cookTemp.Name = "combo_cookTemp";
            this.combo_cookTemp.Size = new System.Drawing.Size(64, 21);
            this.combo_cookTemp.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(911, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 26);
            this.button4.TabIndex = 30;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(679, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 26);
            this.button5.TabIndex = 30;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(761, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 26);
            this.button1.TabIndex = 31;
            this.button1.Text = "Up";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(831, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 26);
            this.button2.TabIndex = 31;
            this.button2.Text = "Down";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(790, 300);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 13);
            this.label27.TabIndex = 32;
            this.label27.Text = "Directions";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(801, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Ingredients List";
            // 
            // txt_Direction
            // 
            this.txt_Direction.Location = new System.Drawing.Point(22, 36);
            this.txt_Direction.Multiline = true;
            this.txt_Direction.Name = "txt_Direction";
            this.txt_Direction.Size = new System.Drawing.Size(263, 89);
            this.txt_Direction.TabIndex = 35;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.directionNumberDataGridViewTextBoxColumn,
            this.directionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDirectionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(679, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(326, 183);
            this.dataGridView1.TabIndex = 36;
            // 
            // recipeDBDataSet3
            // 
            this.recipeDBDataSet3.DataSetName = "RecipeDBDataSet3";
            this.recipeDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDirectionsBindingSource
            // 
            this.tblDirectionsBindingSource.DataMember = "tblDirections";
            this.tblDirectionsBindingSource.DataSource = this.recipeDBDataSet3;
            // 
            // tblDirectionsTableAdapter
            // 
            this.tblDirectionsTableAdapter.ClearBeforeFill = true;
            // 
            // directionNumberDataGridViewTextBoxColumn
            // 
            this.directionNumberDataGridViewTextBoxColumn.DataPropertyName = "DirectionNumber";
            this.directionNumberDataGridViewTextBoxColumn.HeaderText = "DirectionNumber";
            this.directionNumberDataGridViewTextBoxColumn.Name = "directionNumberDataGridViewTextBoxColumn";
            // 
            // directionDataGridViewTextBoxColumn
            // 
            this.directionDataGridViewTextBoxColumn.DataPropertyName = "Direction";
            this.directionDataGridViewTextBoxColumn.HeaderText = "Direction";
            this.directionDataGridViewTextBoxColumn.Name = "directionDataGridViewTextBoxColumn";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(241, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Directions (enter one step at a time and click add)";
            // 
            // btn_submitRecipe
            // 
            this.btn_submitRecipe.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_submitRecipe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_submitRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submitRecipe.Location = new System.Drawing.Point(388, 551);
            this.btn_submitRecipe.Name = "btn_submitRecipe";
            this.btn_submitRecipe.Size = new System.Drawing.Size(238, 38);
            this.btn_submitRecipe.TabIndex = 38;
            this.btn_submitRecipe.Text = "Submit Recipe";
            this.btn_submitRecipe.UseVisualStyleBackColor = false;
            this.btn_submitRecipe.Click += new System.EventHandler(this.btn_submitRecipe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Amount);
            this.groupBox1.Controls.Add(this.combo_Unit);
            this.groupBox1.Controls.Add(this.txtIngredientName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(34, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 101);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Ingredients";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_addDirection);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_Direction);
            this.groupBox2.Location = new System.Drawing.Point(28, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 174);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Directions";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredientNameDataGridViewTextBoxColumn,
            this.Amount,
            this.Unit});
            this.dataGridView2.DataSource = this.tblIngredientsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(669, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(344, 198);
            this.dataGridView2.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(54, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Author:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(154, 58);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(34, 13);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "         ";
            // 
            // lbl_recipeID
            // 
            this.lbl_recipeID.AutoSize = true;
            this.lbl_recipeID.Location = new System.Drawing.Point(342, 58);
            this.lbl_recipeID.Name = "lbl_recipeID";
            this.lbl_recipeID.Size = new System.Drawing.Size(52, 13);
            this.lbl_recipeID.TabIndex = 42;
            this.lbl_recipeID.Text = "RecipeID";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(123, 57);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(64, 20);
            this.txt_Amount.TabIndex = 23;
            // 
            // ingredientData
            // 
            this.ingredientData.DataSetName = "IngredientData";
            this.ingredientData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblIngredientsBindingSource
            // 
            this.tblIngredientsBindingSource.DataMember = "tblIngredients";
            this.tblIngredientsBindingSource.DataSource = this.ingredientData;
            // 
            // tblIngredientsTableAdapter
            // 
            this.tblIngredientsTableAdapter.ClearBeforeFill = true;
            // 
            // ingredientNameDataGridViewTextBoxColumn
            // 
            this.ingredientNameDataGridViewTextBoxColumn.DataPropertyName = "IngredientName";
            this.ingredientNameDataGridViewTextBoxColumn.HeaderText = "IngredientName";
            this.ingredientNameDataGridViewTextBoxColumn.Name = "ingredientNameDataGridViewTextBoxColumn";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            // 
            // btn_addDirection
            // 
            this.btn_addDirection.Location = new System.Drawing.Point(29, 138);
            this.btn_addDirection.Name = "btn_addDirection";
            this.btn_addDirection.Size = new System.Drawing.Size(140, 35);
            this.btn_addDirection.TabIndex = 38;
            this.btn_addDirection.Text = "Add Direction";
            this.btn_addDirection.UseVisualStyleBackColor = true;
            this.btn_addDirection.Click += new System.EventHandler(this.btn_addDirection_Click);
            // 
            // btn_getRecipeID
            // 
            this.btn_getRecipeID.Location = new System.Drawing.Point(436, 425);
            this.btn_getRecipeID.Name = "btn_getRecipeID";
            this.btn_getRecipeID.Size = new System.Drawing.Size(118, 40);
            this.btn_getRecipeID.TabIndex = 43;
            this.btn_getRecipeID.Text = "getRecipeID";
            this.btn_getRecipeID.UseVisualStyleBackColor = true;
            this.btn_getRecipeID.Click += new System.EventHandler(this.btn_getRecipeID_Click);
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 601);
            this.Controls.Add(this.btn_getRecipeID);
            this.Controls.Add(this.lbl_recipeID);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_submitRecipe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.combo_Meal);
            this.Controls.Add(this.combo_cookTemp);
            this.Controls.Add(this.combo_cookHours);
            this.Controls.Add(this.combo_prepHours);
            this.Controls.Add(this.combo_cookMinutes);
            this.Controls.Add(this.combo_prepMinutes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RecipeForm";
            this.Text = "RecipeForm";
            this.Load += new System.EventHandler(this.RecipeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDirectionsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private RecipeDBDataSet recipeDBDataSet;
        private System.Windows.Forms.BindingSource tblIngredientBindingSource;
        private RecipeDBDataSetTableAdapters.tblIngredientTableAdapter tblIngredientTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource tblIngredientBindingSource1;
        private RecipeDBDataSet1 recipeDBDataSet1;
        private System.Windows.Forms.BindingSource tblIngredientBindingSource2;
        private RecipeDBDataSet1TableAdapters.tblIngredientTableAdapter tblIngredientTableAdapter1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIngredientName;
        private RecipeDBDataSet2 recipeDBDataSet2;
        private System.Windows.Forms.BindingSource ingredientsBindingSource;
        private RecipeDBDataSet2TableAdapters.IngredientsTableAdapter ingredientsTableAdapter;
        private System.Windows.Forms.ComboBox combo_Unit;
        private System.Windows.Forms.ComboBox combo_Meal;
        private System.Windows.Forms.ComboBox combo_prepMinutes;
        private System.Windows.Forms.ComboBox combo_cookMinutes;
        private System.Windows.Forms.ComboBox combo_prepHours;
        private System.Windows.Forms.ComboBox combo_cookHours;
        private System.Windows.Forms.ComboBox combo_cookTemp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Direction;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RecipeDBDataSet3 recipeDBDataSet3;
        private System.Windows.Forms.BindingSource tblDirectionsBindingSource;
        private RecipeDBDataSet3TableAdapters.tblDirectionsTableAdapter tblDirectionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn directionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_submitRecipe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_recipeID;
        private System.Windows.Forms.TextBox txt_Amount;
        private IngredientData ingredientData;
        private System.Windows.Forms.BindingSource tblIngredientsBindingSource;
        private IngredientDataTableAdapters.tblIngredientsTableAdapter tblIngredientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.Button btn_addDirection;
        private System.Windows.Forms.Button btn_getRecipeID;
    }
}