namespace Car_Server
{
    partial class Variable_Modify
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
            this.BtnPreview = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.CBMembership = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnModifyVariable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnModifyMembership = new System.Windows.Forms.Button();
            this.TXTMembershipParameters = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTMembershipName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NUDMid = new System.Windows.Forms.NumericUpDown();
            this.NUDTo = new System.Windows.Forms.NumericUpDown();
            this.NUDFrom = new System.Windows.Forms.NumericUpDown();
            this.CBVariableType = new System.Windows.Forms.ComboBox();
            this.TXTVariableName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblVariableID = new System.Windows.Forms.Label();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.LblMembershipID = new System.Windows.Forms.Label();
            this.NUDCentroid_Step_Size = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCentroid_Step_Size)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPreview
            // 
            this.BtnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreview.Location = new System.Drawing.Point(334, 261);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(90, 28);
            this.BtnPreview.TabIndex = 46;
            this.BtnPreview.Text = "Preview";
            this.BtnPreview.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(608, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(43, 26);
            this.BtnClose.TabIndex = 45;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // CBMembership
            // 
            this.CBMembership.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMembership.FormattingEnabled = true;
            this.CBMembership.Location = new System.Drawing.Point(165, 270);
            this.CBMembership.Name = "CBMembership";
            this.CBMembership.Size = new System.Drawing.Size(104, 21);
            this.CBMembership.TabIndex = 44;
            this.CBMembership.SelectedIndexChanged += new System.EventHandler(this.CBMembership_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Memberships :";
            // 
            // BtnModifyVariable
            // 
            this.BtnModifyVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifyVariable.Location = new System.Drawing.Point(507, 249);
            this.BtnModifyVariable.Name = "BtnModifyVariable";
            this.BtnModifyVariable.Size = new System.Drawing.Size(128, 39);
            this.BtnModifyVariable.TabIndex = 42;
            this.BtnModifyVariable.Text = "Modify Variable";
            this.BtnModifyVariable.UseVisualStyleBackColor = true;
            this.BtnModifyVariable.Click += new System.EventHandler(this.BtnModifyVariable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.LblMembershipID);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.BtnModifyMembership);
            this.groupBox1.Controls.Add(this.TXTMembershipParameters);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXTMembershipName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(334, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 165);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membership Functions";
            // 
            // BtnModifyMembership
            // 
            this.BtnModifyMembership.Location = new System.Drawing.Point(213, 128);
            this.BtnModifyMembership.Name = "BtnModifyMembership";
            this.BtnModifyMembership.Size = new System.Drawing.Size(88, 23);
            this.BtnModifyMembership.TabIndex = 23;
            this.BtnModifyMembership.Text = "Modify";
            this.BtnModifyMembership.UseVisualStyleBackColor = true;
            this.BtnModifyMembership.Click += new System.EventHandler(this.BtnModifyMembership_Click);
            // 
            // TXTMembershipParameters
            // 
            this.TXTMembershipParameters.Location = new System.Drawing.Point(173, 97);
            this.TXTMembershipParameters.Name = "TXTMembershipParameters";
            this.TXTMembershipParameters.Size = new System.Drawing.Size(128, 22);
            this.TXTMembershipParameters.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Parameters :";
            // 
            // TXTMembershipName
            // 
            this.TXTMembershipName.Location = new System.Drawing.Point(173, 61);
            this.TXTMembershipName.Name = "TXTMembershipName";
            this.TXTMembershipName.Size = new System.Drawing.Size(128, 22);
            this.TXTMembershipName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Membership Name :";
            // 
            // NUDMid
            // 
            this.NUDMid.Location = new System.Drawing.Point(165, 210);
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
            this.NUDMid.TabIndex = 40;
            // 
            // NUDTo
            // 
            this.NUDTo.Location = new System.Drawing.Point(165, 174);
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
            this.NUDTo.TabIndex = 39;
            // 
            // NUDFrom
            // 
            this.NUDFrom.Location = new System.Drawing.Point(165, 148);
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
            this.NUDFrom.TabIndex = 38;
            // 
            // CBVariableType
            // 
            this.CBVariableType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBVariableType.FormattingEnabled = true;
            this.CBVariableType.Items.AddRange(new object[] {
            "input",
            "output"});
            this.CBVariableType.Location = new System.Drawing.Point(165, 81);
            this.CBVariableType.Name = "CBVariableType";
            this.CBVariableType.Size = new System.Drawing.Size(104, 21);
            this.CBVariableType.Sorted = true;
            this.CBVariableType.TabIndex = 37;
            // 
            // TXTVariableName
            // 
            this.TXTVariableName.Location = new System.Drawing.Point(165, 42);
            this.TXTVariableName.Name = "TXTVariableName";
            this.TXTVariableName.Size = new System.Drawing.Size(151, 20);
            this.TXTVariableName.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Perfect Value :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Variable Type :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "From :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Variable Range :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Variable Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 47;
            this.label9.Text = "Variable ID :";
            // 
            // LblVariableID
            // 
            this.LblVariableID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblVariableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVariableID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblVariableID.Location = new System.Drawing.Point(165, 9);
            this.LblVariableID.Name = "LblVariableID";
            this.LblVariableID.Size = new System.Drawing.Size(151, 20);
            this.LblVariableID.TabIndex = 48;
            this.LblVariableID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevious.Location = new System.Drawing.Point(335, 37);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(90, 28);
            this.BtnPrevious.TabIndex = 49;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Location = new System.Drawing.Point(431, 37);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(90, 28);
            this.BtnNext.TabIndex = 50;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "ID :";
            // 
            // LblMembershipID
            // 
            this.LblMembershipID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMembershipID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMembershipID.ForeColor = System.Drawing.Color.Blue;
            this.LblMembershipID.Location = new System.Drawing.Point(173, 24);
            this.LblMembershipID.Name = "LblMembershipID";
            this.LblMembershipID.Size = new System.Drawing.Size(128, 20);
            this.LblMembershipID.TabIndex = 25;
            this.LblMembershipID.Text = "1";
            this.LblMembershipID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NUDCentroid_Step_Size
            // 
            this.NUDCentroid_Step_Size.Location = new System.Drawing.Point(183, 241);
            this.NUDCentroid_Step_Size.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDCentroid_Step_Size.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.NUDCentroid_Step_Size.Name = "NUDCentroid_Step_Size";
            this.NUDCentroid_Step_Size.Size = new System.Drawing.Size(86, 20);
            this.NUDCentroid_Step_Size.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 20);
            this.label11.TabIndex = 51;
            this.label11.Text = "Centroid Step Size :";
            // 
            // Variable_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(652, 303);
            this.Controls.Add(this.NUDCentroid_Step_Size);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.LblVariableID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnPreview);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.CBMembership);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnModifyVariable);
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
            this.Name = "Variable_Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variable_Modify";
            this.Load += new System.EventHandler(this.Variable_Modify_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCentroid_Step_Size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPreview;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ComboBox CBMembership;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnModifyVariable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnModifyMembership;
        private System.Windows.Forms.TextBox TXTMembershipParameters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTMembershipName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUDMid;
        private System.Windows.Forms.NumericUpDown NUDTo;
        private System.Windows.Forms.NumericUpDown NUDFrom;
        private System.Windows.Forms.ComboBox CBVariableType;
        private System.Windows.Forms.TextBox TXTVariableName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblVariableID;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label LblMembershipID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown NUDCentroid_Step_Size;
        private System.Windows.Forms.Label label11;
    }
}