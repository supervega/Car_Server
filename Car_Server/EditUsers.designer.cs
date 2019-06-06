namespace Car_Server
{
    partial class AddUsers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUsers));
            this.UserNameTXT = new System.Windows.Forms.TextBox();
            this.UserNamelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AgentNameTXT = new System.Windows.Forms.TextBox();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.Removebtn = new System.Windows.Forms.Button();
            this.AgentInfoGB = new System.Windows.Forms.GroupBox();
            this.ConfirmPasswordTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteInfoGB = new System.Windows.Forms.GroupBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.RemovePasswordTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PictureBrowser = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ConfirmRemovePB = new System.Windows.Forms.PictureBox();
            this.ConfirmPictureBox = new System.Windows.Forms.PictureBox();
            this.AgentPhotoPB = new System.Windows.Forms.PictureBox();
            this.DGVUsers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.AgentInfoGB.SuspendLayout();
            this.DeleteInfoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmRemovePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentPhotoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameTXT
            // 
            this.UserNameTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameTXT.Location = new System.Drawing.Point(196, 35);
            this.UserNameTXT.Name = "UserNameTXT";
            this.UserNameTXT.Size = new System.Drawing.Size(122, 20);
            this.UserNameTXT.TabIndex = 0;
            this.UserNameTXT.TextChanged += new System.EventHandler(this.UserNameTXT_TextChanged);
            // 
            // UserNamelbl
            // 
            this.UserNamelbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNamelbl.ForeColor = System.Drawing.Color.Black;
            this.UserNamelbl.Location = new System.Drawing.Point(21, 35);
            this.UserNamelbl.Name = "UserNamelbl";
            this.UserNamelbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserNamelbl.Size = new System.Drawing.Size(146, 23);
            this.UserNamelbl.TabIndex = 1;
            this.UserNamelbl.Text = "User Name :";
            this.UserNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 73);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordTXT
            // 
            this.PasswordTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTXT.Location = new System.Drawing.Point(196, 73);
            this.PasswordTXT.Name = "PasswordTXT";
            this.PasswordTXT.PasswordChar = '*';
            this.PasswordTXT.Size = new System.Drawing.Size(122, 20);
            this.PasswordTXT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 149);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(142, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Operator Full \r\nName :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AgentNameTXT
            // 
            this.AgentNameTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgentNameTXT.Location = new System.Drawing.Point(196, 160);
            this.AgentNameTXT.Name = "AgentNameTXT";
            this.AgentNameTXT.Size = new System.Drawing.Size(122, 20);
            this.AgentNameTXT.TabIndex = 3;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(434, 323);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(79, 35);
            this.Cancelbtn.TabIndex = 8;
            this.Cancelbtn.Text = "Close";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddUser.Location = new System.Drawing.Point(351, 153);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(74, 31);
            this.BtnAddUser.TabIndex = 4;
            this.BtnAddUser.Text = "Add";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // Removebtn
            // 
            this.Removebtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removebtn.Location = new System.Drawing.Point(291, 32);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(75, 34);
            this.Removebtn.TabIndex = 7;
            this.Removebtn.Text = "Remove";
            this.Removebtn.UseVisualStyleBackColor = true;
            this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
            // 
            // AgentInfoGB
            // 
            this.AgentInfoGB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AgentInfoGB.Controls.Add(this.ConfirmPictureBox);
            this.AgentInfoGB.Controls.Add(this.AgentPhotoPB);
            this.AgentInfoGB.Controls.Add(this.ConfirmPasswordTXT);
            this.AgentInfoGB.Controls.Add(this.label3);
            this.AgentInfoGB.Controls.Add(this.UserNamelbl);
            this.AgentInfoGB.Controls.Add(this.UserNameTXT);
            this.AgentInfoGB.Controls.Add(this.BtnAddUser);
            this.AgentInfoGB.Controls.Add(this.PasswordTXT);
            this.AgentInfoGB.Controls.Add(this.label1);
            this.AgentInfoGB.Controls.Add(this.label2);
            this.AgentInfoGB.Controls.Add(this.AgentNameTXT);
            this.AgentInfoGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentInfoGB.ForeColor = System.Drawing.Color.Black;
            this.AgentInfoGB.Location = new System.Drawing.Point(12, 22);
            this.AgentInfoGB.Name = "AgentInfoGB";
            this.AgentInfoGB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AgentInfoGB.Size = new System.Drawing.Size(501, 201);
            this.AgentInfoGB.TabIndex = 9;
            this.AgentInfoGB.TabStop = false;
            this.AgentInfoGB.Text = "Operator Info";
            // 
            // ConfirmPasswordTXT
            // 
            this.ConfirmPasswordTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmPasswordTXT.Location = new System.Drawing.Point(196, 111);
            this.ConfirmPasswordTXT.Name = "ConfirmPasswordTXT";
            this.ConfirmPasswordTXT.PasswordChar = '*';
            this.ConfirmPasswordTXT.Size = new System.Drawing.Size(122, 20);
            this.ConfirmPasswordTXT.TabIndex = 2;
            this.ConfirmPasswordTXT.Leave += new System.EventHandler(this.ConfirmPasswordTXT_Leave);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 111);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirm Password :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeleteInfoGB
            // 
            this.DeleteInfoGB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteInfoGB.Controls.Add(this.UserName);
            this.DeleteInfoGB.Controls.Add(this.ConfirmRemovePB);
            this.DeleteInfoGB.Controls.Add(this.RemovePasswordTXT);
            this.DeleteInfoGB.Controls.Add(this.label4);
            this.DeleteInfoGB.Controls.Add(this.label5);
            this.DeleteInfoGB.Controls.Add(this.Removebtn);
            this.DeleteInfoGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteInfoGB.Location = new System.Drawing.Point(12, 240);
            this.DeleteInfoGB.Name = "DeleteInfoGB";
            this.DeleteInfoGB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeleteInfoGB.Size = new System.Drawing.Size(384, 118);
            this.DeleteInfoGB.TabIndex = 10;
            this.DeleteInfoGB.TabStop = false;
            this.DeleteInfoGB.Text = "Delete Account";
            this.DeleteInfoGB.Enter += new System.EventHandler(this.DeleteInfoGB_Enter);
            // 
            // UserName
            // 
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName.Location = new System.Drawing.Point(142, 32);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(123, 20);
            this.UserName.TabIndex = 12;
            // 
            // RemovePasswordTXT
            // 
            this.RemovePasswordTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemovePasswordTXT.Location = new System.Drawing.Point(144, 68);
            this.RemovePasswordTXT.Name = "RemovePasswordTXT";
            this.RemovePasswordTXT.PasswordChar = '*';
            this.RemovePasswordTXT.Size = new System.Drawing.Size(121, 20);
            this.RemovePasswordTXT.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 28);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "User Name :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 66);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PictureBrowser
            // 
            this.PictureBrowser.FileName = "Your Picture File";
            this.PictureBrowser.InitialDirectory = "C:\\\\";
            this.PictureBrowser.RestoreDirectory = true;
            this.PictureBrowser.Title = "صورة العميل";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ip_icon_02_Ok.png");
            this.imageList1.Images.SetKeyName(1, "icon-xp-ex.ico");
            // 
            // ConfirmRemovePB
            // 
            this.ConfirmRemovePB.Location = new System.Drawing.Point(307, 68);
            this.ConfirmRemovePB.Name = "ConfirmRemovePB";
            this.ConfirmRemovePB.Size = new System.Drawing.Size(41, 34);
            this.ConfirmRemovePB.TabIndex = 11;
            this.ConfirmRemovePB.TabStop = false;
            // 
            // ConfirmPictureBox
            // 
            this.ConfirmPictureBox.Location = new System.Drawing.Point(431, 153);
            this.ConfirmPictureBox.Name = "ConfirmPictureBox";
            this.ConfirmPictureBox.Size = new System.Drawing.Size(41, 34);
            this.ConfirmPictureBox.TabIndex = 12;
            this.ConfirmPictureBox.TabStop = false;
            // 
            // AgentPhotoPB
            // 
            this.AgentPhotoPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AgentPhotoPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AgentPhotoPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgentPhotoPB.Location = new System.Drawing.Point(351, 23);
            this.AgentPhotoPB.Name = "AgentPhotoPB";
            this.AgentPhotoPB.Size = new System.Drawing.Size(114, 108);
            this.AgentPhotoPB.TabIndex = 10;
            this.AgentPhotoPB.TabStop = false;
            this.AgentPhotoPB.Click += new System.EventHandler(this.AgentPhotoPB_Click);
            // 
            // DGVUsers
            // 
            this.DGVUsers.AllowDrop = true;
            this.DGVUsers.AllowUserToAddRows = false;
            this.DGVUsers.AllowUserToDeleteRows = false;
            this.DGVUsers.AllowUserToOrderColumns = true;
            this.DGVUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVUserName,
            this.DGVPassword,
            this.DGVFullName,
            this.DGVImage});
            this.DGVUsers.GridColor = System.Drawing.Color.Black;
            this.DGVUsers.Location = new System.Drawing.Point(6, 30);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.Size = new System.Drawing.Size(309, 290);
            this.DGVUsers.TabIndex = 11;
            this.DGVUsers.SelectionChanged += new System.EventHandler(this.DGVUsers_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVUsers);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(519, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 336);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users Info";
            // 
            // DGVUserName
            // 
            this.DGVUserName.HeaderText = "User Name";
            this.DGVUserName.Name = "DGVUserName";
            this.DGVUserName.ReadOnly = true;
            // 
            // DGVPassword
            // 
            this.DGVPassword.HeaderText = "Password";
            this.DGVPassword.Name = "DGVPassword";
            this.DGVPassword.ReadOnly = true;
            // 
            // DGVFullName
            // 
            this.DGVFullName.HeaderText = "Full Name";
            this.DGVFullName.Name = "DGVFullName";
            this.DGVFullName.ReadOnly = true;
            // 
            // DGVImage
            // 
            this.DGVImage.HeaderText = "User Picture";
            this.DGVImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DGVImage.Name = "DGVImage";
            this.DGVImage.ReadOnly = true;
            this.DGVImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(850, 387);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteInfoGB);
            this.Controls.Add(this.AgentInfoGB);
            this.Controls.Add(this.Cancelbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(543, 387);
            this.Name = "AddUsers";
            this.Opacity = 0.9;
            this.Text = "Users Editor";
            this.Load += new System.EventHandler(this.AddUsers_Load);
            this.AgentInfoGB.ResumeLayout(false);
            this.AgentInfoGB.PerformLayout();
            this.DeleteInfoGB.ResumeLayout(false);
            this.DeleteInfoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmRemovePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentPhotoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameTXT;
        private System.Windows.Forms.Label UserNamelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AgentNameTXT;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.Button Removebtn;
        private System.Windows.Forms.GroupBox AgentInfoGB;
        private System.Windows.Forms.TextBox ConfirmPasswordTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox AgentPhotoPB;
        private System.Windows.Forms.GroupBox DeleteInfoGB;
        private System.Windows.Forms.TextBox RemovePasswordTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ConfirmPictureBox;
        private System.Windows.Forms.PictureBox ConfirmRemovePB;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog PictureBrowser;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVFullName;
        private System.Windows.Forms.DataGridViewImageColumn DGVImage;
    }
}