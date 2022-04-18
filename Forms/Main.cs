using Brewery_IMS.Classes;
using Brewery_IMS.Forms;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Brewery_IMS {
    public partial class MainForm : Form {

        // ---------- Variables ----------
        public static int userId = 1;
        public static Database sql = new Database() {
            Server = "localhost",
            Port = "3306",
            DbName = "brewery_ims",
            Uid = "sqlUser",
            Password = "Passw0rd!"
        };



        // ---------- Form Constructor ----------
        public MainForm() {
            InitializeComponent();
            btnAbort.Visible = false;
            btnStart.Visible = false;
            tmr_1s.Enabled = false;
        }



        // ---------- Form Events ----------
        private void dgvBatch_SelectionChanged(object sender, EventArgs e) {
            if (dgvBatch.RowCount > 0 && dgvBatch.SelectedRows.Count > 0) {
                if ((int)dgvBatch.SelectedRows[0].Cells["sequence"].Value <= 1) {
                    btnStart.Visible = true;
                } else {
                    btnStart.Visible = false;
                }
                if ((int)dgvBatch.SelectedRows[0].Cells["sequence"].Value >= 2 && (int)dgvBatch.SelectedRows[0].Cells["sequence"].Value <= 6) {
                    btnAbort.Visible = true;
                } else {
                    btnAbort.Visible = false;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            Login formLogin = new Login();
            formLogin.ShowDialog();
            if (formLogin.DialogResult == DialogResult.Abort) {
                Application.Exit();
                return;
            }
            while (formLogin.DialogResult != DialogResult.Yes) {
                formLogin.ShowDialog();
            }
            tmr_1s.Enabled = true;
        }
        private void tabBatch_Enter(object sender, EventArgs e) {
            refreshGrids();
        }
        private void tabEquipment_Enter(object sender, EventArgs e) {
            refreshGrids();
        }
        private void tabIngredient_Enter(object sender, EventArgs e) {
            refreshGrids();
        }
        private void tabRecipe_Enter(object sender, EventArgs e) {
            refreshGrids();
        }
        private void textSearchBatch_TextChanged(object sender, EventArgs e) {
            if (textSearchBatch.Text.Length < 1) {
                ((DataTable)dgvBatch.DataSource).DefaultView.RowFilter = "";
            } else {
                ((DataTable)dgvBatch.DataSource).DefaultView.RowFilter = string.Format("name LIKE '%{0}%' OR description LIKE '%{0}%'" +
                    " OR sequenceText LIKE '%{0}%' OR startDate LIKE '%{0}%' OR endDate LIKE '%{0}%' OR recipeName LIKE '%{0}%'",
                    textSearchBatch.Text.Trim().Replace("'", "''"));
            }
        }
        private void textSearchEquip_TextChanged(object sender, EventArgs e) {
            if (textSearchEquip.Text.Length < 1) {
                ((DataTable)dgvEquip.DataSource).DefaultView.RowFilter = "";
            } else {
                ((DataTable)dgvEquip.DataSource).DefaultView.RowFilter = string.Format("name LIKE '%{0}%' OR type LIKE '%{0}%'" +
                    " OR manufacturer LIKE '%{0}%'",
                    textSearchEquip.Text.Trim().Replace("'", "''"));
                dgvEquip.Refresh();
            }
        }
        private void textSearchIngr_TextChanged(object sender, EventArgs e) {
            if (textSearchIngr.Text.Length < 1) {
                ((DataTable)dgvIngr.DataSource).DefaultView.RowFilter = "";
            } else {
                ((DataTable)dgvIngr.DataSource).DefaultView.RowFilter = string.Format("name LIKE '%{0}%' OR category LIKE '%{0}%'" +
                    " OR type LIKE '%{0}%' OR manufacturer LIKE '%{0}%' OR CONVERT(stock, System.String) LIKE '%{0}%' OR unit LIKE '%{0}%'",
                    textSearchIngr.Text.Trim().Replace("'", "''"));
            }
        }
        private void textSearchRecipe_TextChanged(object sender, EventArgs e) {
            if (textSearchRecipe.Text.Length < 1) {
                ((DataTable)dgvRecipes.DataSource).DefaultView.RowFilter = "";
            } else {
                ((DataTable)dgvRecipes.DataSource).DefaultView.RowFilter = string.Format("name LIKE '%{0}%' OR type LIKE '%{0}%'" +
                    " OR author LIKE '%{0}%' OR CONVERT(days, System.String) LIKE '%{0}%'",
                    textSearchRecipe.Text.Trim().Replace("'", "''"));
            }
        }
        private void tmr_1s_Tick(object sender, EventArgs e) {
            doBatchAdvances();
        }



        // ---------- Form Functions ----------
        private void btnAbort_Click(object sender, EventArgs e) {
            if (dgvBatch.SelectedRows.Count > 0) {
                string msg = "Are you sure you want to abort this batch?";
                if (MessageBox.Show(msg, "Confirm Abort", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                    sql.abortBatch((int)dgvBatch.SelectedRows[0].Cells["batchId"].Value);
                    refreshGrids();
                }
            } else {
                MessageBox.Show("Nothing selected", "ERROR");
            }
        }
        private void btnAddBatch_Click(object sender, EventArgs e) {
            CreateBatch formCreateBatch = new CreateBatch();
            formCreateBatch.Show();
            FormMgr.Main.Hide();
        }
        private void btnAddEqpt_Click(object sender, EventArgs e) {
            CreateEquipment formCreateEquip = new CreateEquipment();
            formCreateEquip.Show();
            FormMgr.Main.Hide();
        }
        private void btnAddIngr_Click(object sender, EventArgs e) {
            CreateIngredient formCreateIngr = new CreateIngredient();
            formCreateIngr.Show();
            FormMgr.Main.Hide();
        }
        private void btnAddRecipe_Click(object sender, EventArgs e) {
            CreateRecipe formCreateRecipe = new CreateRecipe();
            formCreateRecipe.Show();
            FormMgr.Main.Hide();
        }
        private void btnDelBatch_Click(object sender, EventArgs e) {
            if (dgvBatch.RowCount > 0) {
                if (dgvBatch.SelectedRows.Count > 0) {
                    string msg = "Are you sure you want to delete this batch?";
                    if (MessageBox.Show(msg, "Confirm Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                        if ((int)dgvBatch.SelectedRows[0].Cells["Sequence"].Value > 1 && (int)dgvBatch.SelectedRows[0].Cells["Sequence"].Value < 6) {
                            MessageBox.Show("This batch is currently in progress, it cannot be deleted.  Please abort the batch first");
                        } else {
                            sql.deleteBatch((int)dgvBatch.SelectedRows[0].Cells["batchId"].Value);
                            refreshGrids();
                        }
                    }
                } else {
                    MessageBox.Show("Nothing selected", "ERROR");
                }
            } else {
                MessageBox.Show("Nothing selected", "ERROR");
            }
        }
        private void btnDelEqpt_Click(object sender, EventArgs e) {
            if (dgvEquip.RowCount > 0) {
                if (dgvEquip.SelectedRows.Count > 0) {
                    string msg = "Are you sure you want to delete this equipment?";
                    if (MessageBox.Show(msg, "Confirm Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                        sql.deleteEquipment((int)dgvEquip.SelectedRows[0].Cells["equipmentId"].Value);
                        refreshGrids();
                    }
                } else {
                    MessageBox.Show("Nothing selected", "ERROR");
                }
            } else {
                MessageBox.Show("Nothing selected", "ERROR");
            }
        }
        private void btnDelIngr_Click(object sender, EventArgs e) {
            if (dgvIngr.RowCount > 0) {
                if (dgvIngr.SelectedRows.Count > 0) {
                    string msg = "Are you sure you want to delete this ingredient?  This will also delete the ingredient from all existing recipes";
                    if (MessageBox.Show(msg, "Confirm Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                        sql.deleteIngredient((int)dgvIngr.SelectedRows[0].Cells["ingredientId"].Value);
                        refreshGrids();
                    }
                } else {
                    MessageBox.Show("Nothing selected", "ERROR");
                }
            } else {
                MessageBox.Show("Nothing selected", "ERROR");
            }
        }
        private void btnDelRecipe_Click(object sender, EventArgs e) {
            if (dgvRecipes.RowCount > 0) {
                if (dgvRecipes.SelectedRows.Count > 0) {
                    string msg = "Are you sure you want to delete this recipe?";
                    if (MessageBox.Show(msg, "Confirm Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                        sql.deleteRecipe((int)dgvRecipes.SelectedRows[0].Cells["recipeId"].Value);
                        refreshGrids();
                    }
                } else {
                    MessageBox.Show("Nothing selected", "ERROR");
                }
            } else {
                MessageBox.Show("Nothing selected", "ERROR");
            }
        }
        private void btnModBatch_Click(object sender, EventArgs e) {
            Batch batch = new Batch() {
                ID = (int)dgvBatch.SelectedRows[0].Cells["batchId"].Value,
                Name = dgvBatch.SelectedRows[0].Cells["name"].Value.ToString(),
                Description = dgvBatch.SelectedRows[0].Cells["description"].Value.ToString(),
                StartDate = (DateTime)dgvBatch.SelectedRows[0].Cells["startDate"].Value,
                EndDate = (DateTime)dgvBatch.SelectedRows[0].Cells["endDate"].Value,
                RecipeID = (int)dgvBatch.SelectedRows[0].Cells["recipeId"].Value,
                RecipeName = dgvBatch.SelectedRows[0].Cells["recipeName"].Value.ToString(),
                Sequence = (int)dgvBatch.SelectedRows[0].Cells["sequence"].Value,
                SequenceText = dgvBatch.SelectedRows[0].Cells["sequenceText"].Value.ToString()
            };
            CreateBatch formCreateBatch = new CreateBatch(batch);
            formCreateBatch.Show();
            FormMgr.Main.Hide();
        }
        private void btnModEqpt_Click(object sender, EventArgs e) {
            bool _status = dgvEquip.SelectedRows[0].Cells["status"].Value.ToString() == "1" ? true : false;
            Equipment equip = new Equipment() {
                ID = (int)dgvEquip.SelectedRows[0].Cells["equipmentId"].Value,
                Name = dgvEquip.SelectedRows[0].Cells["name"].Value.ToString(),
                Description = dgvEquip.SelectedRows[0].Cells["description"].Value.ToString(),
                Manufacturer = dgvEquip.SelectedRows[0].Cells["manufacturer"].Value.ToString(),
                Status = _status,
                Type = dgvEquip.SelectedRows[0].Cells["type"].Value.ToString()
            };
            CreateEquipment formCreateEquip = new CreateEquipment(equip);
            formCreateEquip.Show();
            FormMgr.Main.Hide();
        }
        private void btnModIngr_Click(object sender, EventArgs e) {
            if (dgvIngr.SelectedRows[0].Cells["category"].Value.ToString() == "Grain") {
                IngrGrain grain = new IngrGrain() {
                    ID = (int)dgvIngr.SelectedRows[0].Cells["ingredientId"].Value,
                    Name = dgvIngr.SelectedRows[0].Cells["name"].Value.ToString(),
                    Description = dgvIngr.SelectedRows[0].Cells["description"].Value.ToString(),
                    Manufacturer = dgvIngr.SelectedRows[0].Cells["manufacturer"].Value.ToString(),
                    Type = dgvIngr.SelectedRows[0].Cells["type"].Value.ToString(),
                    Color = dgvIngr.SelectedRows[0].Cells["color"].Value.ToString(),
                    Stock = (int)dgvIngr.SelectedRows[0].Cells["stock"].Value,
                    Unit = dgvIngr.SelectedRows[0].Cells["unit"].Value.ToString()
                };
                CreateIngredient formCreateIngr = new CreateIngredient(grain);
                formCreateIngr.Show();
                FormMgr.Main.Hide();
            }
            if (dgvIngr.SelectedRows[0].Cells["category"].Value.ToString() == "Hop") {
                IngrHop hop = new IngrHop() {
                    ID = (int)dgvIngr.SelectedRows[0].Cells["ingredientId"].Value,
                    Name = dgvIngr.SelectedRows[0].Cells["name"].Value.ToString(),
                    Description = dgvIngr.SelectedRows[0].Cells["description"].Value.ToString(),
                    Manufacturer = dgvIngr.SelectedRows[0].Cells["manufacturer"].Value.ToString(),
                    Type = dgvIngr.SelectedRows[0].Cells["type"].Value.ToString(),
                    Alpha = dgvIngr.SelectedRows[0].Cells["alpha"].Value.ToString(),
                    Stock = (int)dgvIngr.SelectedRows[0].Cells["stock"].Value,
                    Unit = dgvIngr.SelectedRows[0].Cells["unit"].Value.ToString()
                };
                CreateIngredient formCreateIngr = new CreateIngredient(hop);
                formCreateIngr.Show();
                FormMgr.Main.Hide();
            }
            if (dgvIngr.SelectedRows[0].Cells["category"].Value.ToString() == "Yeast") {
                IngrYeast yeast = new IngrYeast() {
                    ID = (int)dgvIngr.SelectedRows[0].Cells["ingredientId"].Value,
                    Name = dgvIngr.SelectedRows[0].Cells["name"].Value.ToString(),
                    Description = dgvIngr.SelectedRows[0].Cells["description"].Value.ToString(),
                    Manufacturer = dgvIngr.SelectedRows[0].Cells["manufacturer"].Value.ToString(),
                    Type = dgvIngr.SelectedRows[0].Cells["type"].Value.ToString(),
                    Attenuation = dgvIngr.SelectedRows[0].Cells["attenuation"].Value.ToString(),
                    Stock = (int)dgvIngr.SelectedRows[0].Cells["stock"].Value,
                    Unit = dgvIngr.SelectedRows[0].Cells["unit"].Value.ToString()
                };
                CreateIngredient formCreateIngr = new CreateIngredient(yeast);
                formCreateIngr.Show();
                FormMgr.Main.Hide();
            }
        }
        private void btnModRecipe_Click(object sender, EventArgs e) {
            Recipe recipe = new Recipe() {
                ID = (int)dgvRecipes.SelectedRows[0].Cells["recipeId"].Value,
                Name = dgvRecipes.SelectedRows[0].Cells["name"].Value.ToString(),
                Description = dgvRecipes.SelectedRows[0].Cells["description"].Value.ToString(),
                Author = dgvRecipes.SelectedRows[0].Cells["author"].Value.ToString(),
                Type = dgvRecipes.SelectedRows[0].Cells["type"].Value.ToString(),
                Days = (int)dgvRecipes.SelectedRows[0].Cells["days"].Value
            };
            CreateRecipe formCreateRecipe = new CreateRecipe(recipe);
            formCreateRecipe.Show();
            FormMgr.Main.Hide();
        }
        private void btnReport1_Click(object sender, EventArgs e) {
            dgvReport.DataSource = sql.reportIngrUsage();
            dgvReport.Columns["batchName"].HeaderText = "Batch Name";
            dgvReport.Columns["ingrName"].HeaderText = "Ingr. Name";
            dgvReport.Columns["category"].HeaderText = "Category";
            dgvReport.Columns["itemQty"].HeaderText = "Req'd Qty";
            dgvReport.Columns["stock"].HeaderText = "Stock Qty";
            dgvReport.Columns["batchId"].Visible = false;
            labelReportTitle.Text = "Ingredient Usage Report";
            labelReportDate.Text = "Generated " + System.DateTime.Now.ToString("M/dd/yy HH:mm:ss");
        }
        private void btnReport2_Click(object sender, EventArgs e) {
            dgvReport.DataSource = sql.reportBatchSchedule();
            dgvReport.Columns["name"].HeaderText = "Batch Name";
            dgvReport.Columns["startDate"].HeaderText = "Start Date";
            dgvReport.Columns["endDate"].HeaderText = "End Date";
            dgvReport.Columns["text"].HeaderText = "Current Status";
            labelReportTitle.Text = "Batch Schedule Report";
            labelReportDate.Text = "Generated " + System.DateTime.Now.ToString("M/dd/yy HH:mm:ss");
        }
        private void btnStart_Click(object sender, EventArgs e) {
            if (dgvBatch.SelectedRows.Count > 0) {
                string msg = "Are you ready to start this batch?";
                if (MessageBox.Show(msg, "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                    sql.startBatch((int)dgvBatch.SelectedRows[0].Cells["batchId"].Value, (int)dgvBatch.SelectedRows[0].Cells["recipeId"].Value);
                    refreshGrids();
                }
            } else {
                MessageBox.Show("Nothing selected", "ERROR");
            }

        }



        // ---------- Functions ----------
        private void doBatchAdvances() {
            DataTable dt = sql.getAllBatches();
            DataRow[] selRows = dt.Select("sequence < 7");
            if (selRows.Length > 0) {
                foreach (DataRow row in dt.Rows) {
                    int seqNum = (int)row["sequence"];
                    int id = (int)row["batchId"];
                    DateTime startDate = (DateTime)row["startDate"];
                    DateTime endDate = (DateTime)row["endDate"];
                    switch (seqNum) {
                        case 0: // Created
                            sql.advanceBatch(id); // Advance to 'Ready' immediately
                            refreshGrids();
                            break;
                        case 1: // Ready to Start
                            break; // Advance to 'Mashing' is handled separately when the Start button is pressed
                        case 2: // Mashing
                            if (System.DateTime.Now.Date >= startDate.AddDays(1)) {
                                sql.advanceBatch(id); // Advance to 'Fermenting' after 1 day
                                refreshGrids();
                            }
                            break;
                        case 3: // Fermenting
                            if (System.DateTime.Now.Date >= endDate.AddDays(-1)) {
                                sql.advanceBatch(id); // Advance to 'Racking' 1 day before end date
                                refreshGrids();
                            }
                            break;
                        case 4: // Racking
                            if (System.DateTime.Now.Date >= endDate) {
                                sql.advanceBatch(id); // Advance to 'Racking' on end date
                                refreshGrids();
                            }
                            break;
                        case 5: // Cleaning
                            if (System.DateTime.Now.Date >= endDate.AddDays(1)) {
                                sql.advanceBatch(id); // Advance to 'Finished' after 1 day
                                refreshGrids();
                            }
                            break;
                        case 6: // Finished
                            if (System.DateTime.Now.Date >= endDate.AddDays(7)) {
                                sql.advanceBatch(id); // Advance to 'Archived' after 7 days
                                refreshGrids();
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public void refreshGrids() {
            dgvBatch.DataSource = sql.getAllBatches();
            dgvBatch.Sort(dgvBatch.Columns["startDate"], ListSortDirection.Ascending);
            dgvBatch.Columns["name"].HeaderText = "Name";
            dgvBatch.Columns["description"].HeaderText = "Description";
            dgvBatch.Columns["sequenceText"].HeaderText = "Sequence";
            dgvBatch.Columns["startDate"].HeaderText = "Start Date";
            dgvBatch.Columns["endDate"].HeaderText = "End Date";
            dgvBatch.Columns["recipeName"].HeaderText = "Recipe Name";
            dgvBatch.Columns["batchId"].Visible = false;
            dgvBatch.Columns["sequence"].Visible = false;
            dgvBatch.Columns["recipeId"].Visible = false;
            if (dgvBatch.RowCount > 0) {
                if ((int)dgvBatch.SelectedRows[0].Cells["sequence"].Value <= 1) {
                    btnStart.Visible = true;
                } else {
                    btnStart.Visible = false;
                }
                if ((int)dgvBatch.SelectedRows[0].Cells["sequence"].Value >= 2 && (int)dgvBatch.SelectedRows[0].Cells["sequence"].Value <= 6) {
                    btnAbort.Visible = true;
                } else {
                    btnAbort.Visible = false;
                }
            }
            dgvBatch.Refresh();
            dgvEquip.DataSource = sql.getAllEquipment();
            dgvEquip.Sort(dgvEquip.Columns["name"], ListSortDirection.Ascending);
            dgvEquip.Columns["name"].HeaderText = "Name";
            dgvEquip.Columns["type"].HeaderText = "Type";
            dgvEquip.Columns["manufacturer"].HeaderText = "Manufacturer";
            dgvEquip.Columns["statusText"].HeaderText = "Status";
            dgvEquip.Columns["equipmentId"].Visible = false;
            dgvEquip.Columns["description"].Visible = false;
            dgvEquip.Columns["status"].Visible = false;
            dgvEquip.Columns["lastUpdate"].Visible = false;
            dgvEquip.Columns["lastUpdateBy"].Visible = false;
            dgvEquip.Refresh();
            dgvIngr.DataSource = sql.getAllIngredients();
            dgvIngr.Sort(dgvIngr.Columns["name"], ListSortDirection.Ascending);
            dgvIngr.Columns["name"].HeaderText = "Name";
            dgvIngr.Columns["category"].HeaderText = "Category";
            dgvIngr.Columns["type"].HeaderText = "Type";
            dgvIngr.Columns["manufacturer"].HeaderText = "Manufacturer";
            dgvIngr.Columns["stock"].HeaderText = "Stock";
            dgvIngr.Columns["unit"].HeaderText = "Unit";
            dgvIngr.Columns["ingredientId"].Visible = false;
            dgvIngr.Columns["description"].Visible = false;
            dgvIngr.Columns["alpha"].Visible = false;
            dgvIngr.Columns["attenuation"].Visible = false;
            dgvIngr.Columns["color"].Visible = false;
            dgvIngr.Columns["lastUpdate"].Visible = false;
            dgvIngr.Columns["lastUpdateBy"].Visible = false;
            dgvIngr.Refresh();
            dgvRecipes.DataSource = sql.getAllRecipes();
            dgvRecipes.Sort(dgvRecipes.Columns["name"], ListSortDirection.Ascending);
            dgvRecipes.Columns["name"].HeaderText = "Name";
            dgvRecipes.Columns["type"].HeaderText = "Type";
            dgvRecipes.Columns["author"].HeaderText = "Author";
            dgvRecipes.Columns["days"].HeaderText = "Days Req'd";
            dgvRecipes.Columns["recipeId"].Visible = false;
            dgvRecipes.Columns["description"].Visible = false;
            dgvRecipes.Columns["lastUpdate"].Visible = false;
            dgvRecipes.Columns["lastUpdateBy"].Visible = false;
            dgvRecipes.Refresh();
        }
    }
}
