
namespace Brewery_IMS
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvBatch = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBatch = new System.Windows.Forms.TabPage();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelBatch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModBatch = new System.Windows.Forms.Button();
            this.btnAddBatch = new System.Windows.Forms.Button();
            this.textSearchBatch = new System.Windows.Forms.TextBox();
            this.tabRecipe = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelRecipe = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModRecipe = new System.Windows.Forms.Button();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.textSearchRecipe = new System.Windows.Forms.TextBox();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.tabIngredient = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelIngr = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModIngr = new System.Windows.Forms.Button();
            this.btnAddIngr = new System.Windows.Forms.Button();
            this.textSearchIngr = new System.Windows.Forms.TextBox();
            this.dgvIngr = new System.Windows.Forms.DataGridView();
            this.tabEquipment = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelEqpt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModEqpt = new System.Windows.Forms.Button();
            this.btnAddEqpt = new System.Windows.Forms.Button();
            this.textSearchEquip = new System.Windows.Forms.TextBox();
            this.dgvEquip = new System.Windows.Forms.DataGridView();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.labelReportDate = new System.Windows.Forms.Label();
            this.labelReportTitle = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnReport2 = new System.Windows.Forms.Button();
            this.btnReport1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.tmr_1s = new System.Windows.Forms.Timer(this.components);
            this.tmr_1m = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabBatch.SuspendLayout();
            this.tabRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            this.tabIngredient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngr)).BeginInit();
            this.tabEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquip)).BeginInit();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBatch
            // 
            this.dgvBatch.AllowUserToAddRows = false;
            this.dgvBatch.AllowUserToDeleteRows = false;
            this.dgvBatch.AllowUserToResizeRows = false;
            this.dgvBatch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBatch.Location = new System.Drawing.Point(11, 35);
            this.dgvBatch.MultiSelect = false;
            this.dgvBatch.Name = "dgvBatch";
            this.dgvBatch.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBatch.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBatch.RowHeadersVisible = false;
            this.dgvBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBatch.ShowEditingIcon = false;
            this.dgvBatch.Size = new System.Drawing.Size(854, 307);
            this.dgvBatch.TabIndex = 1;
            this.dgvBatch.SelectionChanged += new System.EventHandler(this.dgvBatch_SelectionChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabBatch);
            this.tabControl1.Controls.Add(this.tabRecipe);
            this.tabControl1.Controls.Add(this.tabIngredient);
            this.tabControl1.Controls.Add(this.tabEquipment);
            this.tabControl1.Controls.Add(this.tabReports);
            this.tabControl1.Controls.Add(this.tabAbout);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 416);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabBatch
            // 
            this.tabBatch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabBatch.Controls.Add(this.btnAbort);
            this.tabBatch.Controls.Add(this.btnStart);
            this.tabBatch.Controls.Add(this.label1);
            this.tabBatch.Controls.Add(this.btnDelBatch);
            this.tabBatch.Controls.Add(this.label2);
            this.tabBatch.Controls.Add(this.btnModBatch);
            this.tabBatch.Controls.Add(this.btnAddBatch);
            this.tabBatch.Controls.Add(this.textSearchBatch);
            this.tabBatch.Controls.Add(this.dgvBatch);
            this.tabBatch.Location = new System.Drawing.Point(4, 27);
            this.tabBatch.Name = "tabBatch";
            this.tabBatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabBatch.Size = new System.Drawing.Size(876, 385);
            this.tabBatch.TabIndex = 0;
            this.tabBatch.Text = "Batches";
            this.tabBatch.Enter += new System.EventHandler(this.tabBatch_Enter);
            // 
            // btnAbort
            // 
            this.btnAbort.BackColor = System.Drawing.Color.Red;
            this.btnAbort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbort.ForeColor = System.Drawing.Color.Black;
            this.btnAbort.Location = new System.Drawing.Point(157, 348);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(118, 27);
            this.btnAbort.TabIndex = 4;
            this.btnAbort.Text = "ABORT BATCH";
            this.btnAbort.UseVisualStyleBackColor = false;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkGreen;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(24, 348);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 27);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START BATCH";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 93;
            this.label1.Text = "Enter search keyword to filter:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDelBatch
            // 
            this.btnDelBatch.BackColor = System.Drawing.Color.Maroon;
            this.btnDelBatch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelBatch.ForeColor = System.Drawing.Color.White;
            this.btnDelBatch.Location = new System.Drawing.Point(736, 348);
            this.btnDelBatch.Name = "btnDelBatch";
            this.btnDelBatch.Size = new System.Drawing.Size(118, 27);
            this.btnDelBatch.TabIndex = 7;
            this.btnDelBatch.Text = "Delete";
            this.btnDelBatch.UseVisualStyleBackColor = false;
            this.btnDelBatch.Click += new System.EventHandler(this.btnDelBatch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 91;
            this.label2.Text = "Batch Management:";
            // 
            // btnModBatch
            // 
            this.btnModBatch.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnModBatch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModBatch.ForeColor = System.Drawing.Color.White;
            this.btnModBatch.Location = new System.Drawing.Point(600, 348);
            this.btnModBatch.Name = "btnModBatch";
            this.btnModBatch.Size = new System.Drawing.Size(118, 27);
            this.btnModBatch.TabIndex = 6;
            this.btnModBatch.Text = "Modify";
            this.btnModBatch.UseVisualStyleBackColor = false;
            this.btnModBatch.Click += new System.EventHandler(this.btnModBatch_Click);
            // 
            // btnAddBatch
            // 
            this.btnAddBatch.BackColor = System.Drawing.Color.Navy;
            this.btnAddBatch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBatch.ForeColor = System.Drawing.Color.White;
            this.btnAddBatch.Location = new System.Drawing.Point(465, 348);
            this.btnAddBatch.Name = "btnAddBatch";
            this.btnAddBatch.Size = new System.Drawing.Size(118, 27);
            this.btnAddBatch.TabIndex = 5;
            this.btnAddBatch.Text = "Create New";
            this.btnAddBatch.UseVisualStyleBackColor = false;
            this.btnAddBatch.Click += new System.EventHandler(this.btnAddBatch_Click);
            // 
            // textSearchBatch
            // 
            this.textSearchBatch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchBatch.Location = new System.Drawing.Point(714, 9);
            this.textSearchBatch.Name = "textSearchBatch";
            this.textSearchBatch.Size = new System.Drawing.Size(151, 23);
            this.textSearchBatch.TabIndex = 2;
            this.textSearchBatch.TextChanged += new System.EventHandler(this.textSearchBatch_TextChanged);
            // 
            // tabRecipe
            // 
            this.tabRecipe.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabRecipe.Controls.Add(this.label3);
            this.tabRecipe.Controls.Add(this.btnDelRecipe);
            this.tabRecipe.Controls.Add(this.label4);
            this.tabRecipe.Controls.Add(this.btnModRecipe);
            this.tabRecipe.Controls.Add(this.btnAddRecipe);
            this.tabRecipe.Controls.Add(this.textSearchRecipe);
            this.tabRecipe.Controls.Add(this.dgvRecipes);
            this.tabRecipe.Location = new System.Drawing.Point(4, 27);
            this.tabRecipe.Name = "tabRecipe";
            this.tabRecipe.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecipe.Size = new System.Drawing.Size(876, 385);
            this.tabRecipe.TabIndex = 1;
            this.tabRecipe.Text = "Recipes";
            this.tabRecipe.Enter += new System.EventHandler(this.tabRecipe_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 15);
            this.label3.TabIndex = 100;
            this.label3.Text = "Enter search keyword to filter:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDelRecipe
            // 
            this.btnDelRecipe.BackColor = System.Drawing.Color.Maroon;
            this.btnDelRecipe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelRecipe.ForeColor = System.Drawing.Color.White;
            this.btnDelRecipe.Location = new System.Drawing.Point(736, 348);
            this.btnDelRecipe.Name = "btnDelRecipe";
            this.btnDelRecipe.Size = new System.Drawing.Size(118, 27);
            this.btnDelRecipe.TabIndex = 5;
            this.btnDelRecipe.Text = "Delete";
            this.btnDelRecipe.UseVisualStyleBackColor = false;
            this.btnDelRecipe.Click += new System.EventHandler(this.btnDelRecipe_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 99;
            this.label4.Text = "Recipe Management:";
            // 
            // btnModRecipe
            // 
            this.btnModRecipe.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnModRecipe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModRecipe.ForeColor = System.Drawing.Color.White;
            this.btnModRecipe.Location = new System.Drawing.Point(600, 348);
            this.btnModRecipe.Name = "btnModRecipe";
            this.btnModRecipe.Size = new System.Drawing.Size(118, 27);
            this.btnModRecipe.TabIndex = 4;
            this.btnModRecipe.Text = "Modify";
            this.btnModRecipe.UseVisualStyleBackColor = false;
            this.btnModRecipe.Click += new System.EventHandler(this.btnModRecipe_Click);
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.BackColor = System.Drawing.Color.Navy;
            this.btnAddRecipe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecipe.ForeColor = System.Drawing.Color.White;
            this.btnAddRecipe.Location = new System.Drawing.Point(465, 348);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(118, 27);
            this.btnAddRecipe.TabIndex = 3;
            this.btnAddRecipe.Text = "Create New";
            this.btnAddRecipe.UseVisualStyleBackColor = false;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // textSearchRecipe
            // 
            this.textSearchRecipe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchRecipe.Location = new System.Drawing.Point(714, 9);
            this.textSearchRecipe.Name = "textSearchRecipe";
            this.textSearchRecipe.Size = new System.Drawing.Size(151, 23);
            this.textSearchRecipe.TabIndex = 2;
            this.textSearchRecipe.TextChanged += new System.EventHandler(this.textSearchRecipe_TextChanged);
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.AllowUserToAddRows = false;
            this.dgvRecipes.AllowUserToDeleteRows = false;
            this.dgvRecipes.AllowUserToResizeRows = false;
            this.dgvRecipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecipes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRecipes.Location = new System.Drawing.Point(11, 35);
            this.dgvRecipes.MultiSelect = false;
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecipes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecipes.RowHeadersVisible = false;
            this.dgvRecipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipes.ShowEditingIcon = false;
            this.dgvRecipes.Size = new System.Drawing.Size(854, 307);
            this.dgvRecipes.TabIndex = 1;
            // 
            // tabIngredient
            // 
            this.tabIngredient.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabIngredient.Controls.Add(this.label5);
            this.tabIngredient.Controls.Add(this.btnDelIngr);
            this.tabIngredient.Controls.Add(this.label6);
            this.tabIngredient.Controls.Add(this.btnModIngr);
            this.tabIngredient.Controls.Add(this.btnAddIngr);
            this.tabIngredient.Controls.Add(this.textSearchIngr);
            this.tabIngredient.Controls.Add(this.dgvIngr);
            this.tabIngredient.Location = new System.Drawing.Point(4, 27);
            this.tabIngredient.Name = "tabIngredient";
            this.tabIngredient.Size = new System.Drawing.Size(876, 385);
            this.tabIngredient.TabIndex = 2;
            this.tabIngredient.Text = "Ingredients";
            this.tabIngredient.Enter += new System.EventHandler(this.tabIngredient_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 15);
            this.label5.TabIndex = 107;
            this.label5.Text = "Enter search keyword to filter:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDelIngr
            // 
            this.btnDelIngr.BackColor = System.Drawing.Color.Maroon;
            this.btnDelIngr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelIngr.ForeColor = System.Drawing.Color.White;
            this.btnDelIngr.Location = new System.Drawing.Point(736, 348);
            this.btnDelIngr.Name = "btnDelIngr";
            this.btnDelIngr.Size = new System.Drawing.Size(118, 27);
            this.btnDelIngr.TabIndex = 5;
            this.btnDelIngr.Text = "Delete";
            this.btnDelIngr.UseVisualStyleBackColor = false;
            this.btnDelIngr.Click += new System.EventHandler(this.btnDelIngr_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 106;
            this.label6.Text = "Ingredient Management:";
            // 
            // btnModIngr
            // 
            this.btnModIngr.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnModIngr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModIngr.ForeColor = System.Drawing.Color.White;
            this.btnModIngr.Location = new System.Drawing.Point(600, 348);
            this.btnModIngr.Name = "btnModIngr";
            this.btnModIngr.Size = new System.Drawing.Size(118, 27);
            this.btnModIngr.TabIndex = 4;
            this.btnModIngr.Text = "Modify";
            this.btnModIngr.UseVisualStyleBackColor = false;
            this.btnModIngr.Click += new System.EventHandler(this.btnModIngr_Click);
            // 
            // btnAddIngr
            // 
            this.btnAddIngr.BackColor = System.Drawing.Color.Navy;
            this.btnAddIngr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIngr.ForeColor = System.Drawing.Color.White;
            this.btnAddIngr.Location = new System.Drawing.Point(465, 348);
            this.btnAddIngr.Name = "btnAddIngr";
            this.btnAddIngr.Size = new System.Drawing.Size(118, 27);
            this.btnAddIngr.TabIndex = 3;
            this.btnAddIngr.Text = "Create New";
            this.btnAddIngr.UseVisualStyleBackColor = false;
            this.btnAddIngr.Click += new System.EventHandler(this.btnAddIngr_Click);
            // 
            // textSearchIngr
            // 
            this.textSearchIngr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchIngr.Location = new System.Drawing.Point(714, 9);
            this.textSearchIngr.Name = "textSearchIngr";
            this.textSearchIngr.Size = new System.Drawing.Size(151, 23);
            this.textSearchIngr.TabIndex = 2;
            this.textSearchIngr.TextChanged += new System.EventHandler(this.textSearchIngr_TextChanged);
            // 
            // dgvIngr
            // 
            this.dgvIngr.AllowUserToAddRows = false;
            this.dgvIngr.AllowUserToDeleteRows = false;
            this.dgvIngr.AllowUserToResizeRows = false;
            this.dgvIngr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIngr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngr.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvIngr.Location = new System.Drawing.Point(11, 35);
            this.dgvIngr.MultiSelect = false;
            this.dgvIngr.Name = "dgvIngr";
            this.dgvIngr.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngr.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIngr.RowHeadersVisible = false;
            this.dgvIngr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngr.ShowEditingIcon = false;
            this.dgvIngr.Size = new System.Drawing.Size(854, 307);
            this.dgvIngr.TabIndex = 1;
            // 
            // tabEquipment
            // 
            this.tabEquipment.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabEquipment.Controls.Add(this.label7);
            this.tabEquipment.Controls.Add(this.btnDelEqpt);
            this.tabEquipment.Controls.Add(this.label8);
            this.tabEquipment.Controls.Add(this.btnModEqpt);
            this.tabEquipment.Controls.Add(this.btnAddEqpt);
            this.tabEquipment.Controls.Add(this.textSearchEquip);
            this.tabEquipment.Controls.Add(this.dgvEquip);
            this.tabEquipment.Location = new System.Drawing.Point(4, 27);
            this.tabEquipment.Name = "tabEquipment";
            this.tabEquipment.Size = new System.Drawing.Size(876, 385);
            this.tabEquipment.TabIndex = 3;
            this.tabEquipment.Text = "Equipment";
            this.tabEquipment.Enter += new System.EventHandler(this.tabEquipment_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 15);
            this.label7.TabIndex = 107;
            this.label7.Text = "Enter search keyword to filter:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDelEqpt
            // 
            this.btnDelEqpt.BackColor = System.Drawing.Color.Maroon;
            this.btnDelEqpt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelEqpt.ForeColor = System.Drawing.Color.White;
            this.btnDelEqpt.Location = new System.Drawing.Point(736, 348);
            this.btnDelEqpt.Name = "btnDelEqpt";
            this.btnDelEqpt.Size = new System.Drawing.Size(118, 27);
            this.btnDelEqpt.TabIndex = 5;
            this.btnDelEqpt.Text = "Delete";
            this.btnDelEqpt.UseVisualStyleBackColor = false;
            this.btnDelEqpt.Click += new System.EventHandler(this.btnDelEqpt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 17);
            this.label8.TabIndex = 106;
            this.label8.Text = "Equipment Management:";
            // 
            // btnModEqpt
            // 
            this.btnModEqpt.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnModEqpt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModEqpt.ForeColor = System.Drawing.Color.White;
            this.btnModEqpt.Location = new System.Drawing.Point(600, 348);
            this.btnModEqpt.Name = "btnModEqpt";
            this.btnModEqpt.Size = new System.Drawing.Size(118, 27);
            this.btnModEqpt.TabIndex = 4;
            this.btnModEqpt.Text = "Modify";
            this.btnModEqpt.UseVisualStyleBackColor = false;
            this.btnModEqpt.Click += new System.EventHandler(this.btnModEqpt_Click);
            // 
            // btnAddEqpt
            // 
            this.btnAddEqpt.BackColor = System.Drawing.Color.Navy;
            this.btnAddEqpt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEqpt.ForeColor = System.Drawing.Color.White;
            this.btnAddEqpt.Location = new System.Drawing.Point(465, 348);
            this.btnAddEqpt.Name = "btnAddEqpt";
            this.btnAddEqpt.Size = new System.Drawing.Size(118, 27);
            this.btnAddEqpt.TabIndex = 3;
            this.btnAddEqpt.Text = "Create New";
            this.btnAddEqpt.UseVisualStyleBackColor = false;
            this.btnAddEqpt.Click += new System.EventHandler(this.btnAddEqpt_Click);
            // 
            // textSearchEquip
            // 
            this.textSearchEquip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchEquip.Location = new System.Drawing.Point(714, 9);
            this.textSearchEquip.Name = "textSearchEquip";
            this.textSearchEquip.Size = new System.Drawing.Size(151, 23);
            this.textSearchEquip.TabIndex = 2;
            this.textSearchEquip.TextChanged += new System.EventHandler(this.textSearchEquip_TextChanged);
            // 
            // dgvEquip
            // 
            this.dgvEquip.AllowUserToAddRows = false;
            this.dgvEquip.AllowUserToDeleteRows = false;
            this.dgvEquip.AllowUserToResizeRows = false;
            this.dgvEquip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquip.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEquip.Location = new System.Drawing.Point(11, 35);
            this.dgvEquip.MultiSelect = false;
            this.dgvEquip.Name = "dgvEquip";
            this.dgvEquip.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquip.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEquip.RowHeadersVisible = false;
            this.dgvEquip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquip.ShowEditingIcon = false;
            this.dgvEquip.Size = new System.Drawing.Size(854, 307);
            this.dgvEquip.TabIndex = 1;
            // 
            // tabReports
            // 
            this.tabReports.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabReports.Controls.Add(this.labelReportDate);
            this.tabReports.Controls.Add(this.labelReportTitle);
            this.tabReports.Controls.Add(this.dgvReport);
            this.tabReports.Controls.Add(this.btnReport2);
            this.tabReports.Controls.Add(this.btnReport1);
            this.tabReports.Controls.Add(this.label9);
            this.tabReports.Location = new System.Drawing.Point(4, 27);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(876, 385);
            this.tabReports.TabIndex = 4;
            this.tabReports.Text = "Reports";
            // 
            // labelReportDate
            // 
            this.labelReportDate.AutoSize = true;
            this.labelReportDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportDate.Location = new System.Drawing.Point(635, 10);
            this.labelReportDate.Name = "labelReportDate";
            this.labelReportDate.Size = new System.Drawing.Size(37, 15);
            this.labelReportDate.TabIndex = 112;
            this.labelReportDate.Text = "          ";
            // 
            // labelReportTitle
            // 
            this.labelReportTitle.AutoSize = true;
            this.labelReportTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportTitle.Location = new System.Drawing.Point(200, 8);
            this.labelReportTitle.Name = "labelReportTitle";
            this.labelReportTitle.Size = new System.Drawing.Size(48, 17);
            this.labelReportTitle.TabIndex = 111;
            this.labelReportTitle.Text = "          ";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AllowUserToOrderColumns = true;
            this.dgvReport.AllowUserToResizeRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReport.Location = new System.Drawing.Point(143, 32);
            this.dgvReport.MultiSelect = false;
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.ShowEditingIcon = false;
            this.dgvReport.Size = new System.Drawing.Size(729, 350);
            this.dgvReport.TabIndex = 110;
            // 
            // btnReport2
            // 
            this.btnReport2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnReport2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport2.ForeColor = System.Drawing.Color.Black;
            this.btnReport2.Location = new System.Drawing.Point(9, 65);
            this.btnReport2.Name = "btnReport2";
            this.btnReport2.Size = new System.Drawing.Size(124, 27);
            this.btnReport2.TabIndex = 109;
            this.btnReport2.Text = "Batch Schedule";
            this.btnReport2.UseVisualStyleBackColor = false;
            this.btnReport2.Click += new System.EventHandler(this.btnReport2_Click);
            // 
            // btnReport1
            // 
            this.btnReport1.BackColor = System.Drawing.Color.Khaki;
            this.btnReport1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport1.ForeColor = System.Drawing.Color.Black;
            this.btnReport1.Location = new System.Drawing.Point(9, 32);
            this.btnReport1.Name = "btnReport1";
            this.btnReport1.Size = new System.Drawing.Size(124, 27);
            this.btnReport1.TabIndex = 108;
            this.btnReport1.Text = "Ingredient Usage";
            this.btnReport1.UseVisualStyleBackColor = false;
            this.btnReport1.Click += new System.EventHandler(this.btnReport1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(9, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 107;
            this.label9.Text = "Please choose a report:";
            // 
            // tabAbout
            // 
            this.tabAbout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabAbout.Controls.Add(this.label10);
            this.tabAbout.Location = new System.Drawing.Point(4, 27);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(876, 385);
            this.tabAbout.TabIndex = 5;
            this.tabAbout.Text = "About";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label10.Location = new System.Drawing.Point(288, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 20);
            this.label10.TabIndex = 108;
            this.label10.Text = "Created by harryse7en for C868, 4/10/2022";
            // 
            // tmr_1s
            // 
            this.tmr_1s.Interval = 1000;
            this.tmr_1s.Tick += new System.EventHandler(this.tmr_1s_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(885, 418);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Brewery IMS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabBatch.ResumeLayout(false);
            this.tabBatch.PerformLayout();
            this.tabRecipe.ResumeLayout(false);
            this.tabRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            this.tabIngredient.ResumeLayout(false);
            this.tabIngredient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngr)).EndInit();
            this.tabEquipment.ResumeLayout(false);
            this.tabEquipment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquip)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBatch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBatch;
        private System.Windows.Forms.TabPage tabRecipe;
        private System.Windows.Forms.TabPage tabIngredient;
        private System.Windows.Forms.TabPage tabEquipment;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.TextBox textSearchBatch;
        private System.Windows.Forms.Button btnModBatch;
        private System.Windows.Forms.Button btnAddBatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelBatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelRecipe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModRecipe;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.TextBox textSearchRecipe;
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelIngr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnModIngr;
        private System.Windows.Forms.Button btnAddIngr;
        private System.Windows.Forms.TextBox textSearchIngr;
        private System.Windows.Forms.DataGridView dgvIngr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelEqpt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModEqpt;
        private System.Windows.Forms.Button btnAddEqpt;
        private System.Windows.Forms.TextBox textSearchEquip;
        private System.Windows.Forms.DataGridView dgvEquip;
        private System.Windows.Forms.Timer tmr_1s;
        private System.Windows.Forms.Timer tmr_1m;
        private System.Windows.Forms.Button btnReport1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReport2;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label labelReportDate;
        private System.Windows.Forms.Label labelReportTitle;
        private System.Windows.Forms.Label label10;
    }
}

