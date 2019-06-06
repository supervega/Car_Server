namespace Car_Server
{
    partial class Path_Controller
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NUDPenWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnSavePath = new System.Windows.Forms.Button();
            this.CBShowGrid = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RBFreeHand = new System.Windows.Forms.RadioButton();
            this.RBDrawBlock = new System.Windows.Forms.RadioButton();
            this.RBSelect = new System.Windows.Forms.RadioButton();
            this.BtnPColor = new System.Windows.Forms.Button();
            this.BtnForward = new System.Windows.Forms.Button();
            this.BtnBackward = new System.Windows.Forms.Button();
            this.BtnRunpath = new System.Windows.Forms.Button();
            this.BtnMForeColor = new System.Windows.Forms.Button();
            this.BtnMBackColor = new System.Windows.Forms.Button();
            this.BtnLoadPath = new System.Windows.Forms.Button();
            this.TXTPath = new System.Windows.Forms.TextBox();
            this.LblCurrentPath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRecordPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBShowAxis = new System.Windows.Forms.CheckBox();
            this.CBTrackPath = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBNeuralNetwork = new System.Windows.Forms.RadioButton();
            this.RBFuzzy = new System.Windows.Forms.RadioButton();
            this.MainColorDialog = new System.Windows.Forms.ColorDialog();
            this.BtnClear = new System.Windows.Forms.Button();
            this.pathPanel1 = new PathPanel.PathPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPenWidth)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.BtnClear);
            this.groupBox1.Controls.Add(this.NUDPenWidth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnExport);
            this.groupBox1.Controls.Add(this.BtnSavePath);
            this.groupBox1.Controls.Add(this.CBShowGrid);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.BtnPColor);
            this.groupBox1.Controls.Add(this.BtnForward);
            this.groupBox1.Controls.Add(this.BtnBackward);
            this.groupBox1.Controls.Add(this.BtnRunpath);
            this.groupBox1.Controls.Add(this.BtnMForeColor);
            this.groupBox1.Controls.Add(this.BtnMBackColor);
            this.groupBox1.Controls.Add(this.BtnLoadPath);
            this.groupBox1.Controls.Add(this.TXTPath);
            this.groupBox1.Controls.Add(this.LblCurrentPath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnRecordPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBShowAxis);
            this.groupBox1.Controls.Add(this.CBTrackPath);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 689);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // NUDPenWidth
            // 
            this.NUDPenWidth.Location = new System.Drawing.Point(105, 349);
            this.NUDPenWidth.Name = "NUDPenWidth";
            this.NUDPenWidth.Size = new System.Drawing.Size(68, 20);
            this.NUDPenWidth.TabIndex = 22;
            this.NUDPenWidth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NUDPenWidth.ValueChanged += new System.EventHandler(this.NUDPenWidth_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Pen Width :";
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(68, 569);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(169, 29);
            this.BtnExport.TabIndex = 20;
            this.BtnExport.Text = "Export As Image";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnSavePath
            // 
            this.BtnSavePath.Location = new System.Drawing.Point(68, 534);
            this.BtnSavePath.Name = "BtnSavePath";
            this.BtnSavePath.Size = new System.Drawing.Size(169, 29);
            this.BtnSavePath.TabIndex = 19;
            this.BtnSavePath.Text = "Save Path";
            this.BtnSavePath.UseVisualStyleBackColor = true;
            this.BtnSavePath.Click += new System.EventHandler(this.button9_Click);
            // 
            // CBShowGrid
            // 
            this.CBShowGrid.AutoSize = true;
            this.CBShowGrid.Location = new System.Drawing.Point(210, 87);
            this.CBShowGrid.Name = "CBShowGrid";
            this.CBShowGrid.Size = new System.Drawing.Size(84, 17);
            this.CBShowGrid.TabIndex = 18;
            this.CBShowGrid.Text = "Show Grid";
            this.CBShowGrid.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gray;
            this.groupBox3.Controls.Add(this.RBFreeHand);
            this.groupBox3.Controls.Add(this.RBDrawBlock);
            this.groupBox3.Controls.Add(this.RBSelect);
            this.groupBox3.Location = new System.Drawing.Point(24, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 136);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cursor State";
            // 
            // RBFreeHand
            // 
            this.RBFreeHand.AutoSize = true;
            this.RBFreeHand.Location = new System.Drawing.Point(30, 96);
            this.RBFreeHand.Name = "RBFreeHand";
            this.RBFreeHand.Size = new System.Drawing.Size(84, 17);
            this.RBFreeHand.TabIndex = 2;
            this.RBFreeHand.Text = "Free Hand";
            this.RBFreeHand.UseVisualStyleBackColor = true;
            this.RBFreeHand.CheckedChanged += new System.EventHandler(this.RBFreeHand_CheckedChanged);
            // 
            // RBDrawBlock
            // 
            this.RBDrawBlock.AutoSize = true;
            this.RBDrawBlock.Location = new System.Drawing.Point(30, 63);
            this.RBDrawBlock.Name = "RBDrawBlock";
            this.RBDrawBlock.Size = new System.Drawing.Size(96, 17);
            this.RBDrawBlock.TabIndex = 1;
            this.RBDrawBlock.Text = "Draw Blocks";
            this.RBDrawBlock.UseVisualStyleBackColor = true;
            this.RBDrawBlock.CheckedChanged += new System.EventHandler(this.RBDrawBlock_CheckedChanged);
            // 
            // RBSelect
            // 
            this.RBSelect.AutoSize = true;
            this.RBSelect.Checked = true;
            this.RBSelect.Location = new System.Drawing.Point(30, 31);
            this.RBSelect.Name = "RBSelect";
            this.RBSelect.Size = new System.Drawing.Size(61, 17);
            this.RBSelect.TabIndex = 0;
            this.RBSelect.TabStop = true;
            this.RBSelect.Text = "Select";
            this.RBSelect.UseVisualStyleBackColor = true;
            this.RBSelect.CheckedChanged += new System.EventHandler(this.RBSelect_CheckedChanged);
            // 
            // BtnPColor
            // 
            this.BtnPColor.Location = new System.Drawing.Point(68, 302);
            this.BtnPColor.Name = "BtnPColor";
            this.BtnPColor.Size = new System.Drawing.Size(169, 29);
            this.BtnPColor.TabIndex = 16;
            this.BtnPColor.Text = "Path Color";
            this.BtnPColor.UseVisualStyleBackColor = true;
            this.BtnPColor.Click += new System.EventHandler(this.BtnPColor_Click);
            // 
            // BtnForward
            // 
            this.BtnForward.Location = new System.Drawing.Point(238, 614);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(67, 41);
            this.BtnForward.TabIndex = 15;
            this.BtnForward.Text = "Forward";
            this.BtnForward.UseVisualStyleBackColor = true;
            // 
            // BtnBackward
            // 
            this.BtnBackward.Location = new System.Drawing.Point(8, 614);
            this.BtnBackward.Name = "BtnBackward";
            this.BtnBackward.Size = new System.Drawing.Size(82, 41);
            this.BtnBackward.TabIndex = 14;
            this.BtnBackward.Text = "Backward";
            this.BtnBackward.UseVisualStyleBackColor = true;
            // 
            // BtnRunpath
            // 
            this.BtnRunpath.Location = new System.Drawing.Point(164, 614);
            this.BtnRunpath.Name = "BtnRunpath";
            this.BtnRunpath.Size = new System.Drawing.Size(73, 41);
            this.BtnRunpath.TabIndex = 13;
            this.BtnRunpath.Text = "Run Path";
            this.BtnRunpath.UseVisualStyleBackColor = true;
            // 
            // BtnMForeColor
            // 
            this.BtnMForeColor.Location = new System.Drawing.Point(68, 270);
            this.BtnMForeColor.Name = "BtnMForeColor";
            this.BtnMForeColor.Size = new System.Drawing.Size(169, 26);
            this.BtnMForeColor.TabIndex = 12;
            this.BtnMForeColor.Text = "Maze Fore Color";
            this.BtnMForeColor.UseVisualStyleBackColor = true;
            this.BtnMForeColor.Click += new System.EventHandler(this.BtnMForeColor_Click);
            // 
            // BtnMBackColor
            // 
            this.BtnMBackColor.Location = new System.Drawing.Point(68, 234);
            this.BtnMBackColor.Name = "BtnMBackColor";
            this.BtnMBackColor.Size = new System.Drawing.Size(169, 30);
            this.BtnMBackColor.TabIndex = 11;
            this.BtnMBackColor.Text = "Maze Back Color";
            this.BtnMBackColor.UseVisualStyleBackColor = true;
            this.BtnMBackColor.Click += new System.EventHandler(this.BtnMBackColor_Click);
            // 
            // BtnLoadPath
            // 
            this.BtnLoadPath.Location = new System.Drawing.Point(250, 165);
            this.BtnLoadPath.Name = "BtnLoadPath";
            this.BtnLoadPath.Size = new System.Drawing.Size(28, 23);
            this.BtnLoadPath.TabIndex = 8;
            this.BtnLoadPath.Text = "...";
            this.BtnLoadPath.UseVisualStyleBackColor = true;
            // 
            // TXTPath
            // 
            this.TXTPath.Location = new System.Drawing.Point(105, 167);
            this.TXTPath.Name = "TXTPath";
            this.TXTPath.Size = new System.Drawing.Size(153, 20);
            this.TXTPath.TabIndex = 7;
            // 
            // LblCurrentPath
            // 
            this.LblCurrentPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCurrentPath.ForeColor = System.Drawing.Color.Blue;
            this.LblCurrentPath.Location = new System.Drawing.Point(105, 200);
            this.LblCurrentPath.Name = "LblCurrentPath";
            this.LblCurrentPath.Size = new System.Drawing.Size(173, 22);
            this.LblCurrentPath.TabIndex = 6;
            this.LblCurrentPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Curren Path :";
            // 
            // BtnRecordPath
            // 
            this.BtnRecordPath.Location = new System.Drawing.Point(92, 614);
            this.BtnRecordPath.Name = "BtnRecordPath";
            this.BtnRecordPath.Size = new System.Drawing.Size(71, 41);
            this.BtnRecordPath.TabIndex = 4;
            this.BtnRecordPath.Text = "Record Path";
            this.BtnRecordPath.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Load Path :";
            // 
            // CBShowAxis
            // 
            this.CBShowAxis.AutoSize = true;
            this.CBShowAxis.Location = new System.Drawing.Point(210, 64);
            this.CBShowAxis.Name = "CBShowAxis";
            this.CBShowAxis.Size = new System.Drawing.Size(84, 17);
            this.CBShowAxis.TabIndex = 2;
            this.CBShowAxis.Text = "Show Axis";
            this.CBShowAxis.UseVisualStyleBackColor = true;
            // 
            // CBTrackPath
            // 
            this.CBTrackPath.AutoSize = true;
            this.CBTrackPath.Location = new System.Drawing.Point(210, 41);
            this.CBTrackPath.Name = "CBTrackPath";
            this.CBTrackPath.Size = new System.Drawing.Size(89, 17);
            this.CBTrackPath.TabIndex = 1;
            this.CBTrackPath.Text = "Track Path";
            this.CBTrackPath.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.RBNeuralNetwork);
            this.groupBox2.Controls.Add(this.RBFuzzy);
            this.groupBox2.Location = new System.Drawing.Point(20, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 96);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Base";
            // 
            // RBNeuralNetwork
            // 
            this.RBNeuralNetwork.AutoSize = true;
            this.RBNeuralNetwork.Location = new System.Drawing.Point(30, 63);
            this.RBNeuralNetwork.Name = "RBNeuralNetwork";
            this.RBNeuralNetwork.Size = new System.Drawing.Size(113, 17);
            this.RBNeuralNetwork.TabIndex = 1;
            this.RBNeuralNetwork.Text = "Neural Network";
            this.RBNeuralNetwork.UseVisualStyleBackColor = true;
            // 
            // RBFuzzy
            // 
            this.RBFuzzy.AutoSize = true;
            this.RBFuzzy.Checked = true;
            this.RBFuzzy.Location = new System.Drawing.Point(30, 31);
            this.RBFuzzy.Name = "RBFuzzy";
            this.RBFuzzy.Size = new System.Drawing.Size(92, 17);
            this.RBFuzzy.TabIndex = 0;
            this.RBFuzzy.TabStop = true;
            this.RBFuzzy.Text = "Fuzzy Logic";
            this.RBFuzzy.UseVisualStyleBackColor = true;
            // 
            // MainColorDialog
            // 
            this.MainColorDialog.ShowHelp = true;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(215, 110);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(66, 29);
            this.BtnClear.TabIndex = 23;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // pathPanel1
            // 
            this.pathPanel1.BackColor = System.Drawing.Color.Black;
            this.pathPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathPanel1.ForeColor = System.Drawing.Color.White;
            this.pathPanel1.Location = new System.Drawing.Point(323, 13);
            this.pathPanel1.Name = "pathPanel1";
            this.pathPanel1.OperationType = PathPanel.PathPanel.DrawingType.select;
            this.pathPanel1.PathColor = System.Drawing.Color.Empty;
            this.pathPanel1.PenWidth = 8;
            this.pathPanel1.ShowAxis = false;
            this.pathPanel1.ShowGrid = false;
            this.pathPanel1.Size = new System.Drawing.Size(769, 689);
            this.pathPanel1.TabIndex = 1;
            this.pathPanel1.TrackPath = false;
            // 
            // Path_Controller
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1104, 732);
            this.Controls.Add(this.pathPanel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1120, 768);
            this.MinimumSize = new System.Drawing.Size(1120, 766);
            this.Name = "Path_Controller";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Path Controller";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Path_Controller_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPenWidth)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBFuzzy;
        private System.Windows.Forms.RadioButton RBNeuralNetwork;
        private System.Windows.Forms.CheckBox CBShowAxis;
        private System.Windows.Forms.CheckBox CBTrackPath;
        private System.Windows.Forms.Button BtnRecordPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLoadPath;
        private System.Windows.Forms.TextBox TXTPath;
        private System.Windows.Forms.Label LblCurrentPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog MainColorDialog;
        private System.Windows.Forms.Button BtnMForeColor;
        private System.Windows.Forms.Button BtnMBackColor;
        private System.Windows.Forms.Button BtnRunpath;
        private System.Windows.Forms.Button BtnBackward;
        private System.Windows.Forms.Button BtnForward;
        private System.Windows.Forms.Button BtnPColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RBFreeHand;
        private System.Windows.Forms.RadioButton RBDrawBlock;
        private System.Windows.Forms.RadioButton RBSelect;
        private System.Windows.Forms.CheckBox CBShowGrid;
        private System.Windows.Forms.Button BtnSavePath;
        private PathPanel.PathPanel pathPanel1;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.NumericUpDown NUDPenWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnClear;
    }
}