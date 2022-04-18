using Brewery_IMS.Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Brewery_IMS.Forms {
    public partial class CreateBatch : Form {

        // ---------- Variables ----------
        private readonly bool editMode = false; // Used to change form to "Edit" mode
        private Batch batch = new Batch();
        private DataTable dt = new DataTable();



        // ---------- Form Constructors ----------
        public CreateBatch() {  // "Create" mode
            InitializeComponent();
            editMode = false;
            dgvRecipes.DataSource = MainForm.sql.getAllRecipes();
            dgvRecipes.Sort(dgvRecipes.Columns["name"], ListSortDirection.Ascending);
            dgvRecipes.Columns["name"].HeaderText = "Name";
            dgvRecipes.Columns["type"].HeaderText = "Type";
            dgvRecipes.Columns["days"].HeaderText = "Days Req'd";
            dgvRecipes.Columns["description"].HeaderText = "Description";
            dgvRecipes.Columns["recipeId"].Visible = false;
            dgvRecipes.Columns["author"].Visible = false;
            dgvRecipes.Columns["lastUpdate"].Visible = false;
            dgvRecipes.Columns["lastUpdateBy"].Visible = false;
            dtpStart.Value = System.DateTime.Now;
            dtpStart.MinDate = System.DateTime.Now;
            dtpStart.MaxDate = System.DateTime.Now.AddYears(1);
            dtpEnd.Value = System.DateTime.Now.AddDays(10);
        }

        public CreateBatch(Batch batch) {  // "Edit" mode
            InitializeComponent();
            editMode = true;
            this.batch = batch;
            this.Text = "Modify Batch";
            groupBox1.Text = "Modify Batch";
            textName.Text = batch.Name;
            textDesc.Text = batch.Description;
            dgvRecipes.DataSource = MainForm.sql.getAllRecipes();
            dgvRecipes.Sort(dgvRecipes.Columns["name"], ListSortDirection.Ascending);
            dgvRecipes.Columns["name"].HeaderText = "Name";
            dgvRecipes.Columns["type"].HeaderText = "Type";
            dgvRecipes.Columns["days"].HeaderText = "Days Req'd";
            dgvRecipes.Columns["description"].HeaderText = "Description";
            dgvRecipes.Columns["recipeId"].Visible = false;
            dgvRecipes.Columns["author"].Visible = false;
            dgvRecipes.Columns["lastUpdate"].Visible = false;
            dgvRecipes.Columns["lastUpdateBy"].Visible = false;
            dtpStart.Value = batch.StartDate;
            if (batch.StartDate > System.DateTime.Now) {
                dtpStart.MinDate = System.DateTime.Now;
            }
            if (batch.StartDate > System.DateTime.Now) {
                dtpStart.MaxDate = System.DateTime.Now.AddYears(1);
            }
            dtpEnd.Value = batch.EndDate;
            label6.Text = "Recipe: " + batch.RecipeName;
            label7.Text = "Batch Status: " + batch.SequenceText;
            if ((int)batch.Sequence <= 1) {
                btnSearch.Visible = true;
                dgvRecipes.Visible = true;
                dtpStart.Enabled = true;
                label2.Visible = true;
                label6.Visible = false;
                label7.Visible = false;
                textSearch.Visible = true;
            } else {
                btnSearch.Visible = false;
                dgvRecipes.Visible = false;
                dtpStart.Enabled = false;
                label2.Visible = false;
                label6.Visible = true;
                label7.Visible = true;
                textSearch.Visible = false;
            }
        }



        // ---------- Form Events ----------
        private void CreateBatch_Activated(object sender, EventArgs e) {
            if (editMode) {
                foreach (DataGridViewRow row in dgvRecipes.Rows) {
                    if ((int)row.Cells["recipeId"].Value == batch.RecipeID) {
                        row.Selected = true;
                        break;
                    } else {
                        row.Selected = false;
                    }
                }
                dgvRecipes.CurrentCell = dgvRecipes.Rows[dgvRecipes.SelectedRows[0].Index].Cells[1];
            }
        }

        private void dgvRecipes_SelectionChanged(object sender, EventArgs e) {
            if (dgvRecipes.RowCount > 0 && dgvRecipes.SelectedRows.Count > 0) {
                try {
                    dtpEnd.Value = dtpStart.Value.AddDays((int)dgvRecipes.SelectedRows[0].Cells["days"].Value);
                } catch { }
            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e) {
            if (dgvRecipes.RowCount > 0 && dgvRecipes.SelectedRows.Count > 0) {
                dtpEnd.Value = dtpStart.Value.AddDays((int)dgvRecipes.SelectedRows[0].Cells["days"].Value);
            }
        }



        // ---------- Form Functions ----------
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
            FormMgr.Main.Show();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (doValidate()) {
                batch.Name = textName.Text;
                batch.Description = textDesc.Text;
                batch.StartDate = dtpStart.Value;
                batch.EndDate = dtpEnd.Value;
                batch.Sequence = editMode ? batch.Sequence : 0;
                batch.RecipeID = (int)dgvRecipes.SelectedRows[0].Cells["recipeId"].Value;
                if (editMode) {
                    MainForm.sql.updateBatch(batch);
                } else {
                    MainForm.sql.createBatch(batch);
                }
                this.Close();
                FormMgr.Main.refreshGrids();
                FormMgr.Main.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (textSearch.Text.Length < 1) {
                ((DataTable)dgvRecipes.DataSource).DefaultView.RowFilter = "";
            } else {
                ((DataTable)dgvRecipes.DataSource).DefaultView.RowFilter = string.Format("name LIKE '%{0}%' OR description LIKE '%{0}%'" +
                    " OR type LIKE '%{0}%' OR CONVERT(days, System.String) LIKE '%{0}%'", textSearch.Text.Trim().Replace("'", "''"));
            }
        }




        // ---------- Functions ----------
        private bool doValidate() {
            if (textName.Text.Trim() == "") {
                MessageBox.Show("Name cannot be empty");
                return false;
            } else if (dtpStart.Value == null) {
                MessageBox.Show("Start Date cannot be empty");
                return false;
            } else if (dtpStart.Value < System.DateTime.Now.AddDays(-1)) {
                MessageBox.Show("Start Date cannot be in the past");
                return false;
            } else if (dgvRecipes.SelectedRows.Count == 0) {
                MessageBox.Show("A recipe must be selected");
                return false;
            }
            return true;
        }
    }
}
