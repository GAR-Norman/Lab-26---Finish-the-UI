namespace Lab_26___Finish_the_UI
{
    partial class BMI
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
            this.BMITable = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MyHeightTextbox = new System.Windows.Forms.TextBox();
            this.CalculateButtonLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResetLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.YourBmiLabel = new System.Windows.Forms.Label();
            this.BMIResultTextbox = new System.Windows.Forms.TextBox();
            this.BmiProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.BMITable.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMITable
            // 
            this.BMITable.BackColor = System.Drawing.Color.Black;
            this.BMITable.BackgroundImage = global::Lab_26___Finish_the_UI.Properties.Resources.wavy_blue_shapes_for_abstract_backgrounds_1035_7268;
            this.BMITable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.BMITable.ColumnCount = 2;
            this.BMITable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITable.Controls.Add(this.ImperialRadioButton, 1, 0);
            this.BMITable.Controls.Add(this.MetricButton, 0, 0);
            this.BMITable.Controls.Add(this.WeightLabel, 0, 1);
            this.BMITable.Controls.Add(this.WeightTextBox, 1, 1);
            this.BMITable.Controls.Add(this.MyHeightTextbox, 1, 2);
            this.BMITable.Controls.Add(this.CalculateButtonLabel, 0, 3);
            this.BMITable.Controls.Add(this.CalculateButton, 1, 3);
            this.BMITable.Controls.Add(this.ResetLabel, 0, 4);
            this.BMITable.Controls.Add(this.ResetButton, 1, 4);
            this.BMITable.Controls.Add(this.HeightLabel, 0, 2);
            this.BMITable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMITable.Location = new System.Drawing.Point(0, 0);
            this.BMITable.Name = "BMITable";
            this.BMITable.RowCount = 5;
            this.BMITable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMITable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMITable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMITable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMITable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMITable.Size = new System.Drawing.Size(299, 315);
            this.BMITable.TabIndex = 0;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ImperialRadioButton.Location = new System.Drawing.Point(153, 15);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(129, 33);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = false;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButtonClickChanged);
            // 
            // MetricButton
            // 
            this.MetricButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MetricButton.AutoSize = true;
            this.MetricButton.BackColor = System.Drawing.Color.Transparent;
            this.MetricButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricButton.ForeColor = System.Drawing.Color.DarkRed;
            this.MetricButton.Location = new System.Drawing.Point(4, 13);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(119, 36);
            this.MetricButton.TabIndex = 1;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = false;
            this.MetricButton.CheckedChanged += new System.EventHandler(this.MetricButton_CheckedChanged);
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.WeightLabel.Location = new System.Drawing.Point(4, 81);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(115, 25);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "My Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.AllowDrop = true;
            this.WeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightTextBox.BackColor = System.Drawing.Color.White;
            this.WeightTextBox.Location = new System.Drawing.Point(153, 74);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(137, 38);
            this.WeightTextBox.TabIndex = 1;
            this.WeightTextBox.Text = "0";
            // 
            // MyHeightTextbox
            // 
            this.MyHeightTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MyHeightTextbox.BackColor = System.Drawing.Color.White;
            this.MyHeightTextbox.Location = new System.Drawing.Point(153, 136);
            this.MyHeightTextbox.Name = "MyHeightTextbox";
            this.MyHeightTextbox.Size = new System.Drawing.Size(137, 38);
            this.MyHeightTextbox.TabIndex = 4;
            this.MyHeightTextbox.Text = "0";
            // 
            // CalculateButtonLabel
            // 
            this.CalculateButtonLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CalculateButtonLabel.AutoSize = true;
            this.CalculateButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.CalculateButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButtonLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.CalculateButtonLabel.Location = new System.Drawing.Point(4, 192);
            this.CalculateButtonLabel.Name = "CalculateButtonLabel";
            this.CalculateButtonLabel.Size = new System.Drawing.Size(109, 50);
            this.CalculateButtonLabel.TabIndex = 5;
            this.CalculateButtonLabel.Text = "Calculate Your BMI";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalculateButton.BackColor = System.Drawing.Color.Transparent;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.ForeColor = System.Drawing.Color.DarkRed;
            this.CalculateButton.Location = new System.Drawing.Point(168, 195);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(111, 44);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Click to Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateBMI);
            // 
            // ResetLabel
            // 
            this.ResetLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ResetLabel.AutoSize = true;
            this.ResetLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ResetLabel.Location = new System.Drawing.Point(4, 265);
            this.ResetLabel.Name = "ResetLabel";
            this.ResetLabel.Size = new System.Drawing.Size(94, 32);
            this.ResetLabel.TabIndex = 7;
            this.ResetLabel.Text = "Reset";
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResetButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ResetButton.Location = new System.Drawing.Point(173, 259);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(102, 44);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.HeightLabel.Location = new System.Drawing.Point(4, 143);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(109, 25);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "My Height";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.White;
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ResultTextBox.Location = new System.Drawing.Point(121, 360);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(169, 30);
            this.ResultTextBox.TabIndex = 6;
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YourBmiLabel
            // 
            this.YourBmiLabel.BackColor = System.Drawing.Color.Transparent;
            this.YourBmiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourBmiLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.YourBmiLabel.Location = new System.Drawing.Point(3, 378);
            this.YourBmiLabel.Name = "YourBmiLabel";
            this.YourBmiLabel.Size = new System.Drawing.Size(105, 28);
            this.YourBmiLabel.TabIndex = 7;
            this.YourBmiLabel.Text = "Your BMI";
            this.YourBmiLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BMIResultTextbox
            // 
            this.BMIResultTextbox.BackColor = System.Drawing.Color.White;
            this.BMIResultTextbox.Enabled = false;
            this.BMIResultTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIResultTextbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BMIResultTextbox.Location = new System.Drawing.Point(121, 396);
            this.BMIResultTextbox.Multiline = true;
            this.BMIResultTextbox.Name = "BMIResultTextbox";
            this.BMIResultTextbox.ReadOnly = true;
            this.BMIResultTextbox.Size = new System.Drawing.Size(169, 33);
            this.BMIResultTextbox.TabIndex = 8;
            // 
            // BmiProgressBar
            // 
            this.BmiProgressBar.BackColor = System.Drawing.Color.Tomato;
            this.BmiProgressBar.ForeColor = System.Drawing.Color.DarkRed;
            this.BmiProgressBar.Location = new System.Drawing.Point(13, 330);
            this.BmiProgressBar.Name = "BmiProgressBar";
            this.BmiProgressBar.Size = new System.Drawing.Size(277, 10);
            this.BmiProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BmiProgressBar.TabIndex = 9;
            // 
            // ProgressBarTimer
            // 
            this.ProgressBarTimer.Tick += new System.EventHandler(this.ProgressBarTimer_Tick);
            // 
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::Lab_26___Finish_the_UI.Properties.Resources._240_F_135773765_5FUBf3zUi4nh2HEjjjdN75VUc8o7EY09;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.BmiProgressBar);
            this.Controls.Add(this.BMIResultTextbox);
            this.Controls.Add(this.YourBmiLabel);
            this.Controls.Add(this.BMITable);
            this.Controls.Add(this.ResultTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.BMITable.ResumeLayout(false);
            this.BMITable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMITable;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.MaskedTextBox WeightTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox MyHeightTextbox;
        private System.Windows.Forms.Label CalculateButtonLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label ResetLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label YourBmiLabel;
        private System.Windows.Forms.TextBox BMIResultTextbox;
        public System.Windows.Forms.ProgressBar BmiProgressBar;
        private System.Windows.Forms.Timer ProgressBarTimer;
    }
}

