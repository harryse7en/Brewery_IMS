
namespace Brewery_IMS.Forms {
    partial class Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelTitle = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.labelInvalidCred = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(303, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Login";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textUser
            // 
            this.textUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.Location = new System.Drawing.Point(170, 80);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(100, 23);
            this.textUser.TabIndex = 0;
            this.textUser.TextChanged += new System.EventHandler(this.textUser_TextChanged);
            // 
            // labelUser
            // 
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(34, 82);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(119, 21);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "Username:";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPass
            // 
            this.labelPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(37, 108);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(116, 23);
            this.labelPass.TabIndex = 4;
            this.labelPass.Text = "Password:";
            this.labelPass.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textPass
            // 
            this.textPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textPass.Location = new System.Drawing.Point(170, 106);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(100, 23);
            this.textPass.TabIndex = 1;
            this.textPass.UseSystemPasswordChar = true;
            this.textPass.TextChanged += new System.EventHandler(this.textPass_TextChanged);
            // 
            // labelInvalidCred
            // 
            this.labelInvalidCred.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelInvalidCred.ForeColor = System.Drawing.Color.DarkRed;
            this.labelInvalidCred.Location = new System.Drawing.Point(16, 42);
            this.labelInvalidCred.Name = "labelInvalidCred";
            this.labelInvalidCred.Size = new System.Drawing.Size(299, 24);
            this.labelInvalidCred.TabIndex = 8;
            this.labelInvalidCred.Text = "Invalid login credentials";
            this.labelInvalidCred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInvalidCred.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(170, 146);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 27);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(78, 146);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(327, 207);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelInvalidCred);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.labelTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Brewery IMS Login";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label labelInvalidCred;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}