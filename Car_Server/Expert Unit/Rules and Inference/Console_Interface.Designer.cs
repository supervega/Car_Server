namespace Car_Server
{
    partial class Console_Interface
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
            this.RTBConsole = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RTBConsole
            // 
            this.RTBConsole.BackColor = System.Drawing.Color.Black;
            this.RTBConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBConsole.ForeColor = System.Drawing.Color.White;
            this.RTBConsole.Location = new System.Drawing.Point(0, 0);
            this.RTBConsole.Name = "RTBConsole";
            this.RTBConsole.Size = new System.Drawing.Size(1120, 0);
            this.RTBConsole.TabIndex = 0;
            this.RTBConsole.Text = "";
            this.RTBConsole.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RTBConsole_KeyUp);
            this.RTBConsole.TextChanged += new System.EventHandler(this.RTBConsole_TextChanged);
            // 
            // Console_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1120, 0);
            this.Controls.Add(this.RTBConsole);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1120, 400);
            this.MinimumSize = new System.Drawing.Size(1120, 0);
            this.Name = "Console_Interface";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Console_Interface";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Console_Interface_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox RTBConsole;

    }
}