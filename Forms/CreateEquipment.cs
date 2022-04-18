using Brewery_IMS.Classes;
using System;
using System.Windows.Forms;

namespace Brewery_IMS.Forms {
    public partial class CreateEquipment : Form {

        // ---------- Variables ----------
        private readonly bool editMode = false; // Used to change form to "Edit" mode
        private Equipment equip = new Equipment();



        // ---------- Form Constructors ----------
        public CreateEquipment() {  // "Create" mode
            InitializeComponent();
            editMode = false;
        }

        public CreateEquipment(Equipment equip) {  // "Edit" mode
            InitializeComponent();
            editMode = true;
            this.equip = equip;
            this.Text = "Modify Equipment";
            groupBox1.Text = "Modify Equipment";
            textDesc.Text = equip.Description;
            textManuf.Text = equip.Manufacturer;
            textName.Text = equip.Name;
            textType.Text = equip.Type;
            cbStatus.Checked = equip.Status;
        }



        // ---------- Form Functions ----------
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
            FormMgr.Main.Show();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (doValidate()) {
                equip.Description = textDesc.Text;
                equip.Manufacturer = textManuf.Text;
                equip.Name = textName.Text;
                equip.Type = textType.Text;
                equip.Status = cbStatus.Checked;
                if (editMode) {
                    MainForm.sql.updateEquipment(equip);
                } else {
                    MainForm.sql.createEquipment(equip);
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
            } else if (textType.Text.Trim() == "") {
                MessageBox.Show("Type cannot be empty");
                return false;
            }
            return true;
        }
    }
}
