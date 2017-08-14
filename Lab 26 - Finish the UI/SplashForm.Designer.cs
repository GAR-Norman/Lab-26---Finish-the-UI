namespace Lab_26___Finish_the_UI
{
    partial class SplashForm
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
            this.SplashFormTitle = new System.Windows.Forms.Label();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SplashFormTitle
            // 
            this.SplashFormTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SplashFormTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SplashFormTitle.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashFormTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SplashFormTitle.Location = new System.Drawing.Point(41, 89);
            this.SplashFormTitle.Name = "SplashFormTitle";
            this.SplashFormTitle.Size = new System.Drawing.Size(231, 126);
            this.SplashFormTitle.TabIndex = 0;
            this.SplashFormTitle.Text = "Welcome to my \r\n\r\nBMI Calculator";
            this.SplashFormTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SplashTimer
            // 
            this.SplashTimer.Enabled = true;
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Lab_26___Finish_the_UI.Properties.Resources._624871;
            this.ClientSize = new System.Drawing.Size(320, 480);
            this.Controls.Add(this.SplashFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SplashFormTitle;
        private System.Windows.Forms.Timer SplashTimer;
    }
}