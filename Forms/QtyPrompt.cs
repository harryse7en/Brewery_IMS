using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Brewery_IMS.Forms {
    public partial class QtyPrompt : Form {

        // ---------- Form Constructor ----------
        public QtyPrompt(string mode) {
            InitializeComponent();
            label1.Text = "Please enter the quanity you want to " + mode;
        }



        // ---------- Form Events ----------
        private void numQty_ValueChanged(object sender, EventArgs e) {
            Regex digitsOnly = new Regex(@"[^\d]");
            var temp = digitsOnly.Replace(numQty.Value.ToString(), string.Empty);
            numQty.Value = Convert.ToDecimal(temp);
        }



        // ---------- Form Functions ----------
        private void btnSave_Click(object sender, EventArgs e) {
            CreateRecipe.qtyFromPrompt = Convert.ToInt32(numQty.Value);
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
