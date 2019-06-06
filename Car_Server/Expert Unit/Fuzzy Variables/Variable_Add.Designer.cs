namespace Car_Server
{
    partial class Variable_Add
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
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTVariableName = new System.Windows.Forms.TextBox();
            this.CBVariableType = new System.Windows.Forms.ComboBox();
            this.NUDFrom = new System.Windows.Forms.NumericUpDown();
            this.NUDTo = new System.Windows.Forms.NumericUpDown();
            this.NUDMid = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnModify = new System.Windows.Forms.Button();
            this.LblMembershipID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnAddMembership = new System.Windows.Forms.Button();
            this.TXTMembershipParameters = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTMembershipName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddVariable = new System.Windows.Forms.Button();
            this.CBMembership = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnPreview = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.NUDCentroid_Step_Size = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCentroid_Step_Size)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Perfect Value :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Variable Type :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "From :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Variable Range :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Variable Name :";
            // 
            // TXTVariableName
            // 
            this.TXTVariableName.Location = new System.Drawing.Point(165, 28);
            this.TXTVariableName.Name = "TXTVariableName";
            this.TXTVariableName.Size = new System.Drawing.Size(104, 20);
            this.TXTVariableName.TabIndex = 19;
            // 
            // CBVariableType
            // 
            this.CBVariableType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBVariableType.FormattingEnabled = true;
            this.CBVariableType.Items.AddRange(new object[] {
            "input",
            "output"});
            this.CBVariableType.Location = new System.Drawing.Point(165, 67);
            this.CBVariableType.Name = "CBVariableType";
            this.CBVariableType.Size = new System.Drawing.Size(104, 21);
            this.CBVariableType.Sorted = true;
            this.CBVariableType.TabIndex = 20;
            // 
            // NUDFrom
            // 
            this.NUDFrom.Location = new System.Drawing.Point(165, 134);
            this.NUDFrom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDFrom.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.NUDFrom.Name = "NUDFrom";
            this.NUDFrom.Size = new System.Drawing.Size(104, 20);
            this.NUDFrom.TabIndex = 21;
            // 
            // NUDTo
            // 
            this.NUDTo.Location = new System.Drawing.Point(165, 160);
            this.NUDTo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDTo.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.NUDTo.Name = "NUDTo";
            this.NUDTo.Size = new System.Drawing.Size(104, 20);
            this.NUDTo.TabIndex = 22;
            // 
            // NUDMid
            // 
            this.NUDMid.Location = new System.Drawing.Point(165, 196);
            this.NUDMid.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDMid.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.NUDMid.Name = "NUDMid";
            this.NUDMid.Size = new System.Drawing.Size(104, 20);
            this.NUDMid.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.BtnModify);
            this.groupBox1.Controls.Add(this.LblMembershipID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.BtnAddMembership);
            this.groupBox1.Controls.Add(this.TXTMembershipParameters);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXTMembershipName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(284, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 151);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membership Functions";
            // 
            // BtnModify
            // 
            this.BtnModify.Enabled = false;
            this.BtnModify.Location = new System.Drawing.Point(224, 124);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(76, 23);
            this.BtnModify.TabIndex = 26;
            this.BtnModify.Text = "Modify";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // LblMembershipID
            // 
            this.LblMembershipID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMembershipID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMembershipID.ForeColor = System.Drawing.Color.Blue;
            this.LblMembershipID.Location = new System.Drawing.Point(173, 31);
            this.LblMembershipID.Name = "LblMembershipID";
            this.LblMembershipID.Size = new System.Drawing.Size(127, 20);
            this.LblMembershipID.TabIndex = 25;
            this.LblMembershipID.Text = "1";
            this.LblMembershipID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "ID :";
            // 
            // BtnAddMembership
            // 
            this.BtnAddMembership.Location = new System.Drawing.Point(173, 124);
            this.BtnAddMembership.Name = "BtnAddMembership";
            this.BtnAddMembership.Size = new System.Drawing.Size(45, 23);
            this.BtnAddMembership.TabIndex = 23;
            this.BtnAddMembership.Text = "Add";
            this.BtnAddMembership.UseVisualStyleBackColor = true;
            this.BtnAddMembership.Click += new System.EventHandler(this.BtnAddMembership_Click);
            // 
            // TXTMembershipParameters
            // 
            this.TXTMembershipParameters.Location = new System.Drawing.Point(173, 96);
            this.TXTMembershipParameters.Name = "TXTMembershipParameters";
            this.TXTMembershipParameters.Size = new System.Drawing.Size(128, 22);
            this.TXTMembershipParameters.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Parameters :";
            // 
            // TXTMembershipName
            // 
            this.TXTMembershipName.Location = new System.Drawing.Point(173, 60);
            this.TXTMembershipName.Name = "TXTMembershipName";
            this.TXTMembershipName.Size = new System.Drawing.Size(128, 22);
            this.TXTMembershipName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Membership Name :";
            // 
            // BtnAddVariable
            // 
            this.BtnAddVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddVariable.Location = new System.Drawing.Point(457, 212);
            this.BtnAddVariable.Name = "BtnAddVariable";
            this.BtnAddVariable.Size = new System.Drawing.Size(128, 39);
            this.BtnAddVariable.TabIndex = 25;
            this.BtnAddVariable.Text = "Add Variable";
            this.BtnAddVariable.UseVisualStyleBackColor = true;
            this.BtnAddVariable.Click += new System.EventHandler(this.BtnAddVariable_Click);
            // 
            // CBMembership
            // 
            this.CBMembership.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMembership.FormattingEnabled = true;
            this.CBMembership.Location = new System.Drawing.Point(443, 28);
            this.CBMembership.Name = "CBMembership";
            this.CBMembership.Size = new System.Drawing.Size(104, 21);
            this.CBMembership.TabIndex = 27;
            this.CBMembership.SelectedIndexChanged += new System.EventHandler(this.CBMembership_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(290, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Memberships :";
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(548, -1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(43, 26);
            this.BtnClose.TabIndex = 28;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnPreview
            // 
            this.BtnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreview.Location = new System.Drawing.Point(294, 217);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(90, 28);
            this.BtnPreview.TabIndex = 29;
            this.BtnPreview.Text = "Preview";
            this.BtnPreview.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Centroid Step Size :";
            // 
            // NUDCentroid_Step_Size
            // 
            this.NUDCentroid_Step_Size.Location = new System.Drawing.Point(188, 228);
            this.NUDCentroid_Step_Size.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDCentroid_Step_Size.Name = "NUDCentroid_Step_Size";
            this.NUDCentroid_Step_Size.Size = new System.Drawing.Size(81, 20);
            this.NUDCentroid_Step_Size.TabIndex = 31;
            // 
            // Variable_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(596, 259);
            this.Controls.Add(this.NUDCentroid_Step_Size);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnPreview);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.CBMembership);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnAddVariable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NUDMid);
            this.Controls.Add(this.NUDTo);
            this.Controls.Add(this.NUDFrom);
            this.Controls.Add(this.CBVariableType);
            this.Controls.Add(this.TXTVariableName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Variable_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variable_Add";
            this.Load += new System.EventHandler(this.Variable_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCentroid_Step_Size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTVariableName;
        private System.Windows.Forms.ComboBox CBVariableType;
        private System.Windows.Forms.NumericUpDown NUDFrom;
        private System.Windows.Forms.NumericUpDown NUDTo;
        private System.Windows.Forms.NumericUpDown NUDMid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXTMembershipName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddMembership;
        private System.Windows.Forms.TextBox TXTMembershipParameters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAddVariable;
        private System.Windows.Forms.ComboBox CBMembership;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnPreview;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NUDCentroid_Step_Size;
        private System.Windows.Forms.Label LblMembershipID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnModify;
    }
}