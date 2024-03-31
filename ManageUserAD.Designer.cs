namespace LogInForm
{
    partial class ManageUserAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserAD));
            this.label18 = new System.Windows.Forms.Label();
            this.frmCloseBtn = new System.Windows.Forms.PictureBox();
            this.profileBtn = new System.Windows.Forms.PictureBox();
            this.panelEditUser = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEditSubmit = new System.Windows.Forms.Button();
            this.txtBoxEditType = new System.Windows.Forms.ComboBox();
            this.editUserClsBtn = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBoxEditLN = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.TextBox();
            this.lblSearchText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panelDeleteUser = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.delUserClsBtn = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.addUserClsBtn = new System.Windows.Forms.PictureBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cmbBoxAddType = new System.Windows.Forms.ComboBox();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxAddLN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxAddFN = new System.Windows.Forms.TextBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frmCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBtn)).BeginInit();
            this.panelEditUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editUserClsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panelDeleteUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delUserClsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addUserClsBtn)).BeginInit();
            this.panelAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(36, 116);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "ORDER:";
            // 
            // panelEditUser
            // 
            this.panelEditUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEditUser.Controls.Add(this.label10);
            this.panelEditUser.Controls.Add(this.btnEditSubmit);
            this.panelEditUser.Controls.Add(this.txtBoxEditType);
            this.panelEditUser.Controls.Add(this.editUserClsBtn);
            this.panelEditUser.Controls.Add(this.label12);
            this.panelEditUser.Controls.Add(this.label16);
            this.panelEditUser.Controls.Add(this.txtBoxEditLN);
            this.panelEditUser.Controls.Add(this.label17);
            this.panelEditUser.Controls.Add(this.t);
            this.panelEditUser.Enabled = false;
            this.panelEditUser.Location = new System.Drawing.Point(520, 408);
            this.panelEditUser.Name = "panelEditUser";
            this.panelEditUser.Size = new System.Drawing.Size(407, 273);
            this.panelEditUser.TabIndex = 54;
            this.panelEditUser.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "TYPE OF PAYMENT:";
            // 
            // btnEditSubmit
            // 
            this.btnEditSubmit.BackColor = System.Drawing.Color.Wheat;
            this.btnEditSubmit.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSubmit.Location = new System.Drawing.Point(127, 195);
            this.btnEditSubmit.Name = "btnEditSubmit";
            this.btnEditSubmit.Size = new System.Drawing.Size(134, 33);
            this.btnEditSubmit.TabIndex = 16;
            this.btnEditSubmit.Text = "EDIT ORDER";
            this.btnEditSubmit.UseVisualStyleBackColor = false;
            // 
            // txtBoxEditType
            // 
            this.txtBoxEditType.FormattingEnabled = true;
            this.txtBoxEditType.Items.AddRange(new object[] {
            "Online Payment",
            "Cash On Delivery",
            "Walk-in"});
            this.txtBoxEditType.Location = new System.Drawing.Point(192, 147);
            this.txtBoxEditType.Name = "txtBoxEditType";
            this.txtBoxEditType.Size = new System.Drawing.Size(185, 21);
            this.txtBoxEditType.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Wheat;
            this.label12.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(91, 32);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(227, 39);
            this.label12.TabIndex = 23;
            this.label12.Text = "EDIT ORDER";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(36, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "QUANTITY:";
            // 
            // txtBoxEditLN
            // 
            this.txtBoxEditLN.Location = new System.Drawing.Point(192, 117);
            this.txtBoxEditLN.Name = "txtBoxEditLN";
            this.txtBoxEditLN.Size = new System.Drawing.Size(185, 20);
            this.txtBoxEditLN.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(36, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "FOOD:";
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(192, 91);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(185, 20);
            this.t.TabIndex = 13;
            // 
            // lblSearchText
            // 
            this.lblSearchText.AutoSize = true;
            this.lblSearchText.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchText.Location = new System.Drawing.Point(277, 126);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(55, 13);
            this.lblSearchText.TabIndex = 52;
            this.lblSearchText.Text = "SEARCH";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(369, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 20);
            this.textBox1.TabIndex = 51;
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.Wheat;
            this.btnEditUser.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.Location = new System.Drawing.Point(84, 212);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(152, 33);
            this.btnEditUser.TabIndex = 49;
            this.btnEditUser.Text = "EDIT USER";
            this.btnEditUser.UseVisualStyleBackColor = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Wheat;
            this.btnAddUser.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(84, 144);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(152, 33);
            this.btnAddUser.TabIndex = 48;
            this.btnAddUser.Text = "ADD USER";
            this.btnAddUser.UseVisualStyleBackColor = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Wheat;
            this.lblLogin.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(228, 51);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLogin.Size = new System.Drawing.Size(353, 39);
            this.lblLogin.TabIndex = 47;
            this.lblLogin.Text = "ADMIN DASHBOARD";
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(280, 159);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(395, 229);
            this.dgvUsers.TabIndex = 46;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // panelDeleteUser
            // 
            this.panelDeleteUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDeleteUser.Controls.Add(this.comboBox1);
            this.panelDeleteUser.Controls.Add(this.label18);
            this.panelDeleteUser.Controls.Add(this.btnDelete);
            this.panelDeleteUser.Controls.Add(this.delUserClsBtn);
            this.panelDeleteUser.Controls.Add(this.label20);
            this.panelDeleteUser.Enabled = false;
            this.panelDeleteUser.Location = new System.Drawing.Point(57, 408);
            this.panelDeleteUser.Name = "panelDeleteUser";
            this.panelDeleteUser.Size = new System.Drawing.Size(407, 244);
            this.panelDeleteUser.TabIndex = 55;
            this.panelDeleteUser.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Online Payment",
            "Cash On Delivery",
            "Walk-in"});
            this.comboBox1.Location = new System.Drawing.Point(185, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Wheat;
            this.btnDelete.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(130, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 33);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Wheat;
            this.label20.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(62, 28);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label20.Size = new System.Drawing.Size(292, 39);
            this.label20.TabIndex = 23;
            this.label20.Text = "REMOVE ORDER";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Wheat;
            this.btnAddProduct.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(84, 355);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(152, 33);
            this.btnAddProduct.TabIndex = 57;
            this.btnAddProduct.Text = "ADD PRODUCT";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // cmbBoxAddType
            // 
            this.cmbBoxAddType.FormattingEnabled = true;
            this.cmbBoxAddType.Items.AddRange(new object[] {
            "Online Payment",
            "Cash On Delivery",
            "Walk-in"});
            this.cmbBoxAddType.Location = new System.Drawing.Point(192, 143);
            this.cmbBoxAddType.Name = "cmbBoxAddType";
            this.cmbBoxAddType.Size = new System.Drawing.Size(185, 21);
            this.cmbBoxAddType.TabIndex = 26;
            // 
            // panelAddUser
            // 
            this.panelAddUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddUser.Controls.Add(this.label9);
            this.panelAddUser.Controls.Add(this.btnAddSubmit);
            this.panelAddUser.Controls.Add(this.cmbBoxAddType);
            this.panelAddUser.Controls.Add(this.addUserClsBtn);
            this.panelAddUser.Controls.Add(this.label7);
            this.panelAddUser.Controls.Add(this.label3);
            this.panelAddUser.Controls.Add(this.txtBoxAddLN);
            this.panelAddUser.Controls.Add(this.label2);
            this.panelAddUser.Controls.Add(this.txtBoxAddFN);
            this.panelAddUser.Enabled = false;
            this.panelAddUser.Location = new System.Drawing.Point(744, 46);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(407, 258);
            this.panelAddUser.TabIndex = 53;
            this.panelAddUser.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "TYPE OF PAYMENT:";
            // 
            // btnAddSubmit
            // 
            this.btnAddSubmit.BackColor = System.Drawing.Color.Wheat;
            this.btnAddSubmit.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubmit.Location = new System.Drawing.Point(131, 196);
            this.btnAddSubmit.Name = "btnAddSubmit";
            this.btnAddSubmit.Size = new System.Drawing.Size(134, 33);
            this.btnAddSubmit.TabIndex = 16;
            this.btnAddSubmit.Text = "order";
            this.btnAddSubmit.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Wheat;
            this.label7.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(131, 26);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(137, 39);
            this.label7.TabIndex = 23;
            this.label7.Text = "ORDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "QUANTITY:";
            // 
            // txtBoxAddLN
            // 
            this.txtBoxAddLN.Location = new System.Drawing.Point(192, 117);
            this.txtBoxAddLN.Name = "txtBoxAddLN";
            this.txtBoxAddLN.Size = new System.Drawing.Size(185, 20);
            this.txtBoxAddLN.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "FOOD:";
            // 
            // txtBoxAddFN
            // 
            this.txtBoxAddFN.Location = new System.Drawing.Point(192, 91);
            this.txtBoxAddFN.Name = "txtBoxAddFN";
            this.txtBoxAddFN.Size = new System.Drawing.Size(185, 20);
            this.txtBoxAddFN.TabIndex = 13;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Wheat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(84, 279);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(152, 33);
            this.btnDeleteUser.TabIndex = 50;
            this.btnDeleteUser.Text = "REMOVE ORDER";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // ManageUserAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frmCloseBtn);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.panelEditUser);
            this.Controls.Add(this.lblSearchText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.panelDeleteUser);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.panelAddUser);
            this.Controls.Add(this.btnDeleteUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUserAD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUserAD";
            this.Load += new System.EventHandler(this.ManageUserAD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBtn)).EndInit();
            this.panelEditUser.ResumeLayout(false);
            this.panelEditUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editUserClsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panelDeleteUser.ResumeLayout(false);
            this.panelDeleteUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delUserClsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addUserClsBtn)).EndInit();
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox frmCloseBtn;
        private System.Windows.Forms.PictureBox profileBtn;
        private System.Windows.Forms.Panel panelEditUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEditSubmit;
        private System.Windows.Forms.ComboBox txtBoxEditType;
        private System.Windows.Forms.PictureBox editUserClsBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBoxEditLN;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox t;
        private System.Windows.Forms.Label lblSearchText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panelDeleteUser;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox delUserClsBtn;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox addUserClsBtn;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cmbBoxAddType;
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxAddLN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxAddFN;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}