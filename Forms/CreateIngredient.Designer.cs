
namespace Brewery_IMS.Forms
{
    partial class CreateIngredient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateIngredient));
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboCat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textManuf = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textDesc = new System.Windows.Forms.RichTextBox();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSpecific = new System.Windows.Forms.Label();
            this.textSpecific = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textType = new System.Windows.Forms.TextBox();
            this.comboUnit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(313, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 21);
            this.label10.TabIndex = 67;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 21);
            this.label11.TabIndex = 66;
            this.label11.Text = "* Required";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(313, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 21);
            this.label9.TabIndex = 65;
            this.label9.Text = "*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboCat
            // 
            this.comboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboCat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCat.FormattingEnabled = true;
            this.comboCat.Location = new System.Drawing.Point(142, 66);
            this.comboCat.Name = "comboCat";
            this.comboCat.Size = new System.Drawing.Size(167, 23);
            this.comboCat.TabIndex = 1;
            this.comboCat.SelectedValueChanged += new System.EventHandler(this.comboCat_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 59;
            this.label5.Text = "Description:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(234, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(142, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 55;
            this.label3.Text = "Category:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPass
            // 
            this.labelPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(20, 124);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(116, 23);
            this.labelPass.TabIndex = 52;
            this.labelPass.Text = "Manufacturer:";
            this.labelPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textManuf
            // 
            this.textManuf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textManuf.Location = new System.Drawing.Point(142, 124);
            this.textManuf.MaxLength = 50;
            this.textManuf.Name = "textManuf";
            this.textManuf.Size = new System.Drawing.Size(167, 23);
            this.textManuf.TabIndex = 3;
            // 
            // labelUser
            // 
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(17, 38);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(119, 21);
            this.labelUser.TabIndex = 51;
            this.labelUser.Text = "Name:";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textDesc);
            this.groupBox1.Controls.Add(this.numStock);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelSpecific);
            this.groupBox1.Controls.Add(this.textSpecific);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textType);
            this.groupBox1.Controls.Add(this.comboUnit);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.labelUser);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboCat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textManuf);
            this.groupBox1.Controls.Add(this.labelPass);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 395);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Ingredient";
            // 
            // textDesc
            // 
            this.textDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textDesc.Location = new System.Drawing.Point(142, 153);
            this.textDesc.MaxLength = 500;
            this.textDesc.Name = "textDesc";
            this.textDesc.Size = new System.Drawing.Size(167, 112);
            this.textDesc.TabIndex = 4;
            this.textDesc.Text = "";
            // 
            // numStock
            // 
            this.numStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStock.Location = new System.Drawing.Point(142, 301);
            this.numStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(75, 23);
            this.numStock.TabIndex = 6;
            this.numStock.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 21);
            this.label4.TabIndex = 80;
            this.label4.Text = "*";
            // 
            // labelSpecific
            // 
            this.labelSpecific.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecific.Location = new System.Drawing.Point(20, 271);
            this.labelSpecific.Name = "labelSpecific";
            this.labelSpecific.Size = new System.Drawing.Size(116, 23);
            this.labelSpecific.TabIndex = 79;
            this.labelSpecific.Text = "(Select category...)";
            this.labelSpecific.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textSpecific
            // 
            this.textSpecific.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSpecific.Location = new System.Drawing.Point(142, 271);
            this.textSpecific.MaxLength = 50;
            this.textSpecific.Name = "textSpecific";
            this.textSpecific.Size = new System.Drawing.Size(167, 23);
            this.textSpecific.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 77;
            this.label1.Text = "Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textType
            // 
            this.textType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textType.Location = new System.Drawing.Point(142, 95);
            this.textType.MaxLength = 50;
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(167, 23);
            this.textType.TabIndex = 2;
            // 
            // comboUnit
            // 
            this.comboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboUnit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUnit.FormattingEnabled = true;
            this.comboUnit.Location = new System.Drawing.Point(223, 300);
            this.comboUnit.Name = "comboUnit";
            this.comboUnit.Size = new System.Drawing.Size(86, 23);
            this.comboUnit.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 73;
            this.label8.Text = "Stock:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(142, 37);
            this.textName.MaxLength = 50;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(167, 23);
            this.textName.TabIndex = 0;
            // 
            // CreateIngredient
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(367, 419);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateIngredient";
            this.Text = "Create Ingredient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textManuf;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ComboBox comboUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.Label labelSpecific;
        private System.Windows.Forms.TextBox textSpecific;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.RichTextBox textDesc;
    }
}