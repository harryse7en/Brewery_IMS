using Brewery_IMS.Classes;
using System;
using System.Windows.Forms;

namespace Brewery_IMS.Forms {
    public partial class CreateIngredient : Form {

        // ---------- Variables ----------
        private readonly bool editMode = false; // Used to change form to "Edit" mode
        private IngrGrain grain = new IngrGrain();
        private IngrHop hop = new IngrHop();
        private IngrYeast yeast = new IngrYeast();



        // ---------- Form Constructors ----------
        public CreateIngredient() {  // "Create" mode
            InitializeComponent();
            editMode = false;
            comboCat.Items.Add("Grain");
            comboCat.Items.Add("Hop");
            comboCat.Items.Add("Yeast");
            comboCat.SelectedIndex = 0;
            comboUnit.Items.Add("oz.");
            comboUnit.Items.Add("lbs.");
            comboUnit.Items.Add("bag");
            comboUnit.SelectedIndex = 0;
        }

        public CreateIngredient(IngrGrain ingr) {  // "Edit" mode for grain
            InitializeComponent();
            editMode = true;
            grain = ingr;
            comboCat.Items.Add("Grain");
            comboCat.SelectedIndex = 0;
            comboCat.Enabled = false;
            comboUnit.Items.Add("oz.");
            comboUnit.Items.Add("lbs.");
            comboUnit.Items.Add("bag");
            comboUnit.SelectedIndex = comboUnit.FindString(ingr.Unit);
            this.Text = "Modify Ingredient";
            groupBox1.Text = "Modify Ingredient";
            numStock.Value = ingr.Stock;
            textDesc.Text = ingr.Description;
            textManuf.Text = ingr.Manufacturer;
            textName.Text = ingr.Name;
            textSpecific.Text = ingr.Color;
            textType.Text = ingr.Type;
        }

        public CreateIngredient(IngrHop ingr) {  // "Edit" mode for hop
            InitializeComponent();
            editMode = true;
            hop = ingr;
            comboCat.Items.Add("Hop");
            comboCat.SelectedIndex = 0;
            comboCat.Enabled = false;
            comboUnit.Items.Add("oz.");
            comboUnit.Items.Add("lbs.");
            comboUnit.Items.Add("bag");
            comboUnit.SelectedIndex = comboUnit.FindString(ingr.Unit);
            this.Text = "Modify Ingredient";
            groupBox1.Text = "Modify Ingredient";
            numStock.Value = ingr.Stock;
            textDesc.Text = ingr.Description;
            textManuf.Text = ingr.Manufacturer;
            textName.Text = ingr.Name;
            textSpecific.Text = ingr.Alpha;
            textType.Text = ingr.Type;
        }

        public CreateIngredient(IngrYeast ingr) {  // "Edit" mode for yeast
            InitializeComponent();
            editMode = true;
            yeast = ingr;
            comboCat.Items.Add("Yeast");
            comboCat.SelectedIndex = 0;
            comboCat.Enabled = false;
            comboUnit.Items.Add("oz.");
            comboUnit.Items.Add("lbs.");
            comboUnit.Items.Add("bag");
            comboUnit.SelectedIndex = comboUnit.FindString(ingr.Unit);
            this.Text = "Modify Ingredient";
            groupBox1.Text = "Modify Ingredient";
            numStock.Value = ingr.Stock;
            textDesc.Text = ingr.Description;
            textManuf.Text = ingr.Manufacturer;
            textName.Text = ingr.Name;
            textSpecific.Text = ingr.Attenuation;
            textType.Text = ingr.Type;
        }



        // ---------- Form Events ----------
        private void comboCat_SelectedValueChanged(object sender, EventArgs e) {
            if (comboCat.SelectedItem.ToString() == "Grain") {  // Grain
                labelSpecific.Text = "Color";
            } else if (comboCat.SelectedItem.ToString() == "Hop") {  // Hop
                labelSpecific.Text = "Alpha";
            } else if (comboCat.SelectedItem.ToString() == "Yeast") {  // Yeast
                labelSpecific.Text = "Attenuation";
            } else {
                labelSpecific.Text = "(Select category...)";
            }

        }



        // ---------- Form Functions ----------
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
            FormMgr.Main.Show();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (doValidate()) {
                if (comboCat.SelectedItem.ToString() == "Grain") {  // Grain
                    grain.Color = textSpecific.Text;
                    grain.Description = textDesc.Text;
                    grain.Manufacturer = textManuf.Text;
                    grain.Name = textName.Text;
                    grain.Stock = numStock.Value;
                    grain.Type = textType.Text;
                    grain.Unit = comboUnit.SelectedItem.ToString();
                    if (editMode) {
                        MainForm.sql.updateIngredient(grain);
                    } else {
                        MainForm.sql.createIngredient(grain);
                    }
                } else if (comboCat.SelectedItem.ToString() == "Hop") {  // Hop
                    hop.Alpha = textSpecific.Text;
                    hop.Description = textDesc.Text;
                    hop.Manufacturer = textManuf.Text;
                    hop.Name = textName.Text;
                    hop.Stock = numStock.Value;
                    hop.Type = textType.Text;
                    hop.Unit = comboUnit.SelectedItem.ToString();
                    if (editMode) {
                        MainForm.sql.updateIngredient(hop);
                    } else {
                        MainForm.sql.createIngredient(hop);
                    }
                } else {  // Yeast
                    yeast.Attenuation = textSpecific.Text;
                    yeast.Description = textDesc.Text;
                    yeast.Manufacturer = textManuf.Text;
                    yeast.Name = textName.Text;
                    yeast.Stock = numStock.Value;
                    yeast.Type = textType.Text;
                    yeast.Unit = comboUnit.SelectedItem.ToString();
                    if (editMode) {
                        MainForm.sql.updateIngredient(yeast);
                    } else {
                        MainForm.sql.createIngredient(yeast);
                    }
                }
                this.Close();
                FormMgr.Main.refreshGrids();
                FormMgr.Main.Show();
            }
        }



        // ---------- Functions ----------
        private bool doValidate() {
            if (textName.Text.Trim() == "") {
                MessageBox.Show("Name cannot be empty");
                return false;
            } else if (comboCat.SelectedItem.ToString() == "") {
                MessageBox.Show("Category cannot be empty");
                return false;
            } else if (comboUnit.SelectedItem.ToString() == "") {
                MessageBox.Show("Unit cannot be empty");
                return false;
            } else if (numStock.Value < 0) {
                MessageBox.Show("Stock cannot be below 0");
                return false;
            }
            return true;
        }
    }
}
