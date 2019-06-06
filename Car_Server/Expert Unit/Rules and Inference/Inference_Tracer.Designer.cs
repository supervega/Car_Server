namespace Car_Server
{
    partial class Inference_Tracer
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
            this.BtnDrawAST = new System.Windows.Forms.Button();
            this.PContainer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBFiredRules = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.PBTracing = new System.Windows.Forms.PictureBox();
            this.PContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTracing)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDrawAST
            // 
            this.BtnDrawAST.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDrawAST.Location = new System.Drawing.Point(213, 27);
            this.BtnDrawAST.Name = "BtnDrawAST";
            this.BtnDrawAST.Size = new System.Drawing.Size(234, 41);
            this.BtnDrawAST.TabIndex = 21;
            this.BtnDrawAST.Text = "Draw Program Flow";
            this.BtnDrawAST.UseVisualStyleBackColor = true;
            this.BtnDrawAST.Click += new System.EventHandler(this.BtnDrawAST_Click);
            // 
            // PContainer
            // 
            this.PContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PContainer.Controls.Add(this.label3);
            this.PContainer.Controls.Add(this.label2);
            this.PContainer.Location = new System.Drawing.Point(595, 117);
            this.PContainer.Name = "PContainer";
            this.PContainer.Size = new System.Drawing.Size(497, 563);
            this.PContainer.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "The Acceleration Crisp Result :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Antecedent MemberShip Functions :";
            // 
            // LBFiredRules
            // 
            this.LBFiredRules.BackColor = System.Drawing.Color.Black;
            this.LBFiredRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBFiredRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFiredRules.ForeColor = System.Drawing.Color.White;
            this.LBFiredRules.FormattingEnabled = true;
            this.LBFiredRules.ItemHeight = 16;
            this.LBFiredRules.Location = new System.Drawing.Point(54, 433);
            this.LBFiredRules.Name = "LBFiredRules";
            this.LBFiredRules.Size = new System.Drawing.Size(535, 240);
            this.LBFiredRules.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rules Involved :";
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Location = new System.Drawing.Point(436, 74);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(153, 37);
            this.BtnNext.TabIndex = 22;
            this.BtnNext.Text = "Next Variable";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevious.Location = new System.Drawing.Point(69, 74);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(157, 37);
            this.BtnPrevious.TabIndex = 23;
            this.BtnPrevious.Text = "Previous Variable ";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // PBTracing
            // 
            this.PBTracing.BackColor = System.Drawing.Color.Black;
            this.PBTracing.Location = new System.Drawing.Point(69, 117);
            this.PBTracing.Name = "PBTracing";
            this.PBTracing.Size = new System.Drawing.Size(520, 267);
            this.PBTracing.TabIndex = 0;
            this.PBTracing.TabStop = false;
            // 
            // Inference_Tracer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1104, 730);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnDrawAST);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBFiredRules);
            this.Controls.Add(this.PContainer);
            this.Controls.Add(this.PBTracing);
            this.MaximumSize = new System.Drawing.Size(1120, 768);
            this.MinimumSize = new System.Drawing.Size(1120, 766);
            this.Name = "Inference_Tracer";
            this.ShowIcon = false;
            this.Text = "Inference Tracer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inference_Tracer_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inference_Tracer_FormClosing);
            this.PContainer.ResumeLayout(false);
            this.PContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTracing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBTracing;
        private System.Windows.Forms.Button BtnDrawAST;
        private System.Windows.Forms.Panel PContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LBFiredRules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrevious;
    }
}