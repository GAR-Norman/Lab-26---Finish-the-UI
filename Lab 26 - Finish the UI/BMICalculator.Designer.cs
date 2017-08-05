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
            this.BMITable = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MyHeightTextbox = new System.Windows.Forms.TextBox();
            this.ButtonLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.BMITable.Controls.Add(this.label1, 0, 1);
            this.BMITable.Controls.Add(this.WeightTextBox, 1, 1);
            this.BMITable.Controls.Add(this.label2, 0, 2);
            this.BMITable.Controls.Add(this.MyHeightTextbox, 1, 2);
            this.BMITable.Controls.Add(this.ButtonLabel, 0, 3);
            this.BMITable.Controls.Add(this.CalculateButton, 1, 3);
            this.BMITable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMITable.Location = new System.Drawing.Point(0, 0);
            this.BMITable.Name = "BMITable";
            this.BMITable.RowCount = 4;
            this.BMITable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITable.Size = new System.Drawing.Size(299, 334);
            this.BMITable.TabIndex = 0;
            this.BMITable.Paint += new System.Windows.Forms.PaintEventHandler(this.BMITable_Paint);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ImperialRadioButton.Location = new System.Drawing.Point(153, 25);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(129, 33);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = false;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MetricButton
            // 
            this.MetricButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MetricButton.AutoSize = true;
            this.MetricButton.BackColor = System.Drawing.Color.Transparent;
            this.MetricButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricButton.ForeColor = System.Drawing.Color.DarkRed;
            this.MetricButton.Location = new System.Drawing.Point(4, 24);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(119, 36);
            this.MetricButton.TabIndex = 1;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(4, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Weight";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.AllowDrop = true;
            this.WeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightTextBox.BackColor = System.Drawing.Color.White;
            this.WeightTextBox.Location = new System.Drawing.Point(153, 106);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(137, 38);
            this.WeightTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(4, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 64);
            this.label2.TabIndex = 3;
            this.label2.Text = "My Height";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MyHeightTextbox
            // 
            this.MyHeightTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MyHeightTextbox.BackColor = System.Drawing.Color.White;
            this.MyHeightTextbox.Location = new System.Drawing.Point(153, 189);
            this.MyHeightTextbox.Name = "MyHeightTextbox";
            this.MyHeightTextbox.Size = new System.Drawing.Size(137, 38);
            this.MyHeightTextbox.TabIndex = 4;
            // 
            // ButtonLabel
            // 
            this.ButtonLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonLabel.AutoSize = true;
            this.ButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ButtonLabel.Location = new System.Drawing.Point(4, 266);
            this.ButtonLabel.Name = "ButtonLabel";
            this.ButtonLabel.Size = new System.Drawing.Size(109, 50);
            this.ButtonLabel.TabIndex = 5;
            this.ButtonLabel.Text = "Calculate Your BMI";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalculateButton.BackColor = System.Drawing.Color.Transparent;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.ForeColor = System.Drawing.Color.DarkRed;
            this.CalculateButton.Location = new System.Drawing.Point(168, 269);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(111, 44);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Click to Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(12, 369);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(278, 43);
            this.textBox1.TabIndex = 6;
            // 
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::Lab_26___Finish_the_UI.Properties.Resources._240_F_135773765_5FUBf3zUi4nh2HEjjjdN75VUc8o7EY09;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.BMITable);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BMITable.ResumeLayout(false);
            this.BMITable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMITable;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox WeightTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MyHeightTextbox;
        private System.Windows.Forms.Label ButtonLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CalculateButton;
    }
}

