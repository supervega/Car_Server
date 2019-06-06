namespace PathPanel
{
    partial class PathPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 200;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // PathPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PathPanel";
            this.Size = new System.Drawing.Size(769, 689);
            this.Load += new System.EventHandler(this.PathPanel_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PathPanel_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PathPanel_MouseMove);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PathPanel_MouseDoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PathPanel_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PathPanel_MouseDown);
            this.Resize += new System.EventHandler(this.PathPanel_Resize);
            this.MouseHover += new System.EventHandler(this.PathPanel_MouseHover);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PathPanel_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
    }
}
