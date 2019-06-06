namespace Car_Server
{
    partial class SystemInitializer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemInitializer));
            this.PBResult = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DBServerNameTXT = new System.Windows.Forms.TextBox();
            this.BtnTestConnection = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DBNameTXT = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DBPasswordTXT = new System.Windows.Forms.TextBox();
            this.DBUserNameTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.TXTHostName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBResult)).BeginInit();
            this.SuspendLayout();
            // 
            // PBResult
            // 
            this.PBResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBResult.Location = new System.Drawing.Point(159, 247);
            this.PBResult.Name = "PBResult";
            this.PBResult.Size = new System.Drawing.Size(39, 32);
            this.PBResult.TabIndex = 26;
            this.PBResult.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 169);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(170, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Data Base Server Name :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DBServerNameTXT
            // 
            this.DBServerNameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBServerNameTXT.Location = new System.Drawing.Point(222, 169);
            this.DBServerNameTXT.Name = "DBServerNameTXT";
            this.DBServerNameTXT.Size = new System.Drawing.Size(150, 20);
            this.DBServerNameTXT.TabIndex = 3;
            // 
            // BtnTestConnection
            // 
            this.BtnTestConnection.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTestConnection.Location = new System.Drawing.Point(31, 247);
            this.BtnTestConnection.Name = "BtnTestConnection";
            this.BtnTestConnection.Size = new System.Drawing.Size(121, 31);
            this.BtnTestConnection.TabIndex = 5;
            this.BtnTestConnection.Text = "Connection Test";
            this.BtnTestConnection.UseVisualStyleBackColor = true;
            this.BtnTestConnection.Click += new System.EventHandler(this.BtnTestConnection_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 198);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Data Base Name :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DBNameTXT
            // 
            this.DBNameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBNameTXT.Location = new System.Drawing.Point(222, 197);
            this.DBNameTXT.Name = "DBNameTXT";
            this.DBNameTXT.Size = new System.Drawing.Size(150, 20);
            this.DBNameTXT.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(297, 248);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 31);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data Base Password :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 92);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Data Base User Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DBPasswordTXT
            // 
            this.DBPasswordTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBPasswordTXT.Location = new System.Drawing.Point(222, 117);
            this.DBPasswordTXT.Name = "DBPasswordTXT";
            this.DBPasswordTXT.PasswordChar = '*';
            this.DBPasswordTXT.Size = new System.Drawing.Size(150, 20);
            this.DBPasswordTXT.TabIndex = 1;
            // 
            // DBUserNameTXT
            // 
            this.DBUserNameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBUserNameTXT.Location = new System.Drawing.Point(222, 91);
            this.DBUserNameTXT.Name = "DBUserNameTXT";
            this.DBUserNameTXT.Size = new System.Drawing.Size(150, 20);
            this.DBUserNameTXT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(297, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "This is the first run of the server  ...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icon-xp-ex.ico");
            this.imageList1.Images.SetKeyName(1, "ip_icon_02_Ok.png");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 143);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Host Name :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXTHostName
            // 
            this.TXTHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTHostName.Location = new System.Drawing.Point(222, 143);
            this.TXTHostName.Name = "TXTHostName";
            this.TXTHostName.Size = new System.Drawing.Size(150, 20);
            this.TXTHostName.TabIndex = 2;
            // 
            // SystemInitializer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(395, 291);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTHostName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PBResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DBServerNameTXT);
            this.Controls.Add(this.BtnTestConnection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DBNameTXT);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DBPasswordTXT);
            this.Controls.Add(this.DBUserNameTXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemInitializer";
            this.Text = "System Initializer";
            ((System.ComponentModel.ISupportInitialize)(this.PBResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DBServerNameTXT;
        private System.Windows.Forms.Button BtnTestConnection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DBNameTXT;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DBPasswordTXT;
        private System.Windows.Forms.TextBox DBUserNameTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTHostName;
    }
}