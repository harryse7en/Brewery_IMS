using Brewery_IMS.Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Brewery_IMS.Forms {
    public partial class CreateRecipe : Form {

        // ---------- Variables ----------
        public static int qtyFromPrompt;
        private readonly bool editMode = false; // Used to change form to "Edit" mode
        private DataTable dt = new DataTable();
        private Recipe recipe = new Recipe();



        // ---------- Form Constructors ----------
        public CreateRecipe() {  // "Create" mode
            InitializeComponent();
            editMode = false;
            recipe.ID = MainForm.sql.getAutoIncrement("recipes");
            dgvAvail.DataSource = MainForm.sql.getAllIngredients();
            dgvAvail.Sort(dgvAvail.Columns["name"], ListSortDirection.Ascending);
            dgvAvail.Columns["name"].HeaderText = "Name";
            dgvAvail.Columns["category"].HeaderText = "Category";
            dgvAvail.Columns["type"].HeaderText = "Type";
            dgvAvail.Columns["manufacturer"].HeaderText = "Manufacturer";
            dgvAvail.Columns["ingredientId"].Visible = false;
            dgvAvail.Columns["stock"].Visible = false;
            dgvAvail.Columns["description"].Visible = false;
            dgvAvail.Columns["alpha"].Visible = false;
            dgvAvail.Columns["attenuation"].Visible = false;
            dgvAvail.Columns["color"].Visible = false;
            dgvAvail.Columns["unit"].Visible = false;
            dgvAvail.Columns["lastUpdate"].Visible = false;
            dgvAvail.Columns["lastUpdateBy"].Visible = false;
            dt = MainForm.sql.getRecipeItems(0); // This will return all columns needed but no rows
            dgvUsed.DataSource = dt;
            dgvUsed.Columns["itemQty"].HeaderText = "Qty";
            dgvUsed.Columns["name"].HeaderText = "Name";
            dgvUsed.Columns["category"].HeaderText = "Category";
            dgvUsed.Columns["type"].HeaderText = "Type";
            dgvUsed.Columns["manufacturer"].HeaderText = "Manufacturer";
            dgvUsed.Columns["recipeId"].Visible = false;
            dgvUsed.Columns["ingredientId"].Visible = false;
        }

        public CreateRecipe(Recipe recipe) {  // "Edit" mode
            InitializeComponent();
            editMode = true;
            this.recipe = recipe;
            this.Text = "Modify Recipe";
            groupBox1.Text = "Modify Recipe";
            numDays.Value = recipe.Days;
            textDesc.Text = recipe.Description;
            textAuthor.Text = recipe.Author;
            textName.Text = recipe.Name;
            textType.Text = recipe.Type;
            dgvAvail.DataSource = MainForm.sql.getAllIngredients();
            dgvAvail.Sort(dgvAvail.Columns["Name"], ListSortDirection.Ascending);
            dgvAvail.Columns["name"].HeaderText = "Name";
            dgvAvail.Columns["category"].HeaderText = "Category";
            dgvAvail.Columns["type"].HeaderText = "Type";
            dgvAvail.Columns["manufacturer"].HeaderText = "Manufacturer";
            dgvAvail.Columns["ingredientId"].Visible = false;
            dgvAvail.Columns["stock"].Visible = false;
            dgvAvail.Columns["description"].Visible = false;
            dgvAvail.Columns["alpha"].Visible = false;
            dgvAvail.Columns["attenuation"].Visible = false;
            dgvAvail.Columns["color"].Visible = false;
            dgvAvail.Columns["unit"].Visible = false;
            dgvAvail.Columns["lastUpdate"].Visible = false;
            dgvAvail.Columns["lastUpdateBy"].Visible = false;
            dt = MainForm.sql.getRecipeItems(recipe.ID);
            dgvUsed.DataSource = dt;
            dgvUsed.Columns["itemQty"].HeaderText = "Qty";
            dgvUsed.Columns["name"].HeaderText = "Name";
            dgvUsed.Columns["category"].HeaderText = "Category";
            dgvUsed.Columns["type"].HeaderText = "Type";
            dgvUsed.Columns["manufacturer"].HeaderText = "Manufacturer";
            dgvUsed.Columns["recipeId"].Visible = false;
            dgvUsed.Columns["ingredientId"].Visible = false;
        }



        // ---------- Form Events ----------
        private void numDays_ValueChanged(object sender, EventArgs e) {
            Regex digitsOnly = new Regex(@"[^\d]");
            var temp = digitsOnly.Replace(numDays.Value.ToString(), string.Empty);
            numDays.Value = Convert.ToDecimal(temp);
        }



        // ---------- Form Functions ----------
        private void btnAdd_Click(object sender, EventArgs e) {
            if (dgvAvail.SelectedRows.Count > 0) {
                qtyFromPrompt = 0;
                QtyPrompt formQtyPrompt = new QtyPrompt("add");
                var prompt = formQtyPrompt.ShowDialog();
                if (prompt == DialogResult.Yes) {
                    string exp = "ingredientId = " + dgvAvail.SelectedRows[0].Cells["ingredientId"].Value;
                    DataRow[] selRows = dt.Select(exp);
                    if (selRows.Length == 0) {
                        DataRow dr = dt.NewRow();
                        dr["name"] = dgvAvail.SelectedRows[0].Cells["name"].Value;
                        dr["category"] = dgvAvail.SelectedRows[0].Cells["category"].Value;
                        dr["type"] = dgvAvail.SelectedRows[0].Cells["type"].Value;
                        dr["manufacturer"] = dgvAvail.SelectedRows[0].Cells["manufacturer"].Value;
                        dr["recipeId"] = recipe.ID;
                        dr["ingredientId"] = dgvAvail.SelectedRows[0].Cells["ingredientId"].Value;
                        dr["itemQty"] = qtyFromPrompt;
                        dt.Rows.Add(dr);
                    } else {
                        foreach (DataRow row in dt.Rows) {
                            if (row["ingredientId"].ToString() == dgvAvail.SelectedRows[0].Cells["ingredientId"].Value.ToString()) {
                                int newQty = (int)row["itemQty"] + qtyFromPrompt;
                                row.SetField("itemQty", newQty);
                            }
                        }
                    }
                    dgvUsed.Refresh();
                }
            } else {
                MessageBox.Show("Please select an item");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
            FormMgr.Main.Show();
        }

        private void btnRem_Click(object sender, EventArgs e) {
            if (dgvUsed.RowCount > 0) {
                if (dgvUsed.SelectedRows.Count > 0) {
                    qtyFromPrompt = 0;
                    QtyPrompt formQtyPrompt = new QtyPrompt("add");
                    var prompt = formQtyPrompt.ShowDialog();
                    if (prompt == DialogResult.Yes) {
                        int newQty = (int)dgvUsed.SelectedRows[0].Cells["itemQty"].Value - qtyFromPrompt;
                        if (newQty <= 0) {
                            dgvUsed.Rows.Remove(dgvUsed.SelectedRows[0]);
                        } else {
                            dgvUsed.SelectedRows[0].Cells["itemQty"].Value = newQty;
                        }
                        dgvUsed.Refresh();
                    }
                } else {
                    MessageBox.Show("Please select an item");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (doValidate()) {
                recipe.Description = textDesc.Text;
                recipe.Author = textAuthor.Text;
                recipe.Name = textName.Text;
                recipe.Days = Convert.ToInt32(numDays.Value);
                recipe.Type = textType.Text;
                if (editMode) {
                    MainForm.sql.updateRecipe(recipe);
                    MainForm.sql.clearRecipeItems(recipe.ID);
                    foreach (DataRow row in dt.Rows) {
                        MainForm.sql.addRecipeItem(recipe.ID, (int)row["ingredientId"], (int)row["itemQty"]);
                    }
                } else {
                    MainForm.sql.createRecipe(recipe);
                    foreach (DataRow row in dt.Rows) {
                        MainForm.sql.addRecipeItem(recipe.ID, (int)row["ingredientId"], (int)row["itemQty"]);
                    }
                }
                this.Close();
                FormMgr.Main.refreshGrids();
                FormMgr.Main.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (textSearch.Text.Length < 1) {
                ((DataTable)dgvAvail.DataSource).DefaultView.RowFilter = "";
            } else {
                ((DataTable)dgvAvail.DataSource).DefaultView.RowFilter = string.Format("name LIKE '%{0}%' OR category LIKE '%{0}%'" +
                    " OR type LIKE '%{0}%' OR manufacturer LIKE '%{0}%'", textSearch.Text.Trim().Replace("'", "''"));
            }
        }



        // ---------- Functions ----------
        private bool doValidate() {
            if (textName.Text.Trim() == "") {
                MessageBox.Show("Name cannot be empty");
                return false;
            } else if (textType.Text.Trim() == "") {
                MessageBox.Show("Type cannot be empty");
                return false;
            } else if (numDays.Value < 10) {
                MessageBox.Show("Days cannot be below 10");
                return false;
            } else if (numDays.Value > 365) {
                MessageBox.Show("Days cannot be above 365");
                return false;
            }
            return true;
        }
    }
}
