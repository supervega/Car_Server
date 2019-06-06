namespace Car_Server
{
    partial class Variable_Delete
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDeleteVariable = new System.Windows.Forms.Button();
            this.CBVariableType = new System.Windows.Forms.ComboBox();
            this.BtnPreview = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Variable Name :";
            // 
            // BtnDeleteVariable
            // 
            this.BtnDeleteVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteVariable.Location = new System.Drawing.Point(145, 85);
            this.BtnDeleteVariable.Name = "BtnDeleteVariable";
            this.BtnDeleteVariable.Size = new System.Drawing.Size(128, 39);
            this.BtnDeleteVariable.TabIndex = 26;
            this.BtnDeleteVariable.Text = "Delete Variable";
            this.BtnDeleteVariable.UseVisualStyleBackColor = true;
            this.BtnDeleteVariable.Click += new System.EventHandler(this.BtnDeleteVariable_Click);
            // 
            // CBVariableType
            // 
            this.CBVariableType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBVariableType.FormattingEnabled = true;
            this.CBVariableType.Location = new System.Drawing.Point(146, 45);
            this.CBVariableType.Name = "CBVariableType";
            this.CBVariableType.Size = new System.Drawing.Size(127, 21);
            this.CBVariableType.TabIndex = 27;
            // 
            // BtnPreview
            // 
            this.BtnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreview.Location = new System.Drawing.Point(7, 96);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(90, 28);
            this.BtnPreview.TabIndex = 28;
            this.BtnPreview.Text = "Preview";
            this.BtnPreview.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(251, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(43, 26);
            this.BtnClose.TabIndex = 46;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Variable_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(295, 136);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnPreview);
            this.Controls.Add(this.CBVariableType);
            this.Controls.Add(this.BtnDeleteVariable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Variable_Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variable_Delete";
            this.Load += new System.EventHandler(this.Variable_Delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDeleteVariable;
        private System.Windows.Forms.ComboBox CBVariableType;
        private System.Windows.Forms.Button BtnPreview;
        private System.Windows.Forms.Button BtnClose;
    }
}