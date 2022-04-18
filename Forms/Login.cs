using System;
using System.IO;
using System.Windows.Forms;

namespace Brewery_IMS.Forms {
    public partial class Login : Form {

        // ---------- Form Constructor ----------
        public Login() {
            InitializeComponent();
            btnLogin.Enabled = false;
        }



        // ---------- Form Events ----------
        private void textPass_TextChanged(object sender, EventArgs e) {
            if (textUser.Text.Length > 0 && textPass.Text.Length > 0) {
                btnLogin.Enabled = true;
            } else {
                btnLogin.Enabled = false;
            }
            labelInvalidCred.Visible = false;
        }

        private void textUser_TextChanged(object sender, EventArgs e) {
            if (textUser.Text.Length > 0 && textPass.Text.Length > 0) {
                btnLogin.Enabled = true;
            } else {
                btnLogin.Enabled = false;
            }
            labelInvalidCred.Visible = false;
        }



        // ---------- Form Functions ----------
        private void btnExit_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Abort;
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            MainForm.userId = MainForm.sql.checkLogin(textUser.Text, textPass.Text);
            if (MainForm.userId <= 0) {
                labelInvalidCred.Visible = true;
                using (StreamWriter sw = File.AppendText("userLog.txt")) // userLog.txt will be created in the project folder under bin -> Debug
                {
                    sw.WriteLine(System.DateTime.UtcNow.ToString() + "_UTC -- Failed login attempt for username \"" + textUser.Text + "\"");
                }
            } else {
                using (StreamWriter sw = File.AppendText("userLog.txt")) // userLog.txt will be created in the project folder under bin -> Debug
                {
                    sw.WriteLine(System.DateTime.UtcNow.ToString() + "_UTC -- Username \"" + textUser.Text + "\" logged in successfully");
                }
                this.DialogResult = DialogResult.Yes;
            }
        }
    }
}
