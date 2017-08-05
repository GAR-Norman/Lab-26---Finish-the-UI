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
            this.BMITable.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMITable
            // 
            this.BMITable.BackColor = System.Drawing.Color.MidnightBlue;
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
            this.BMITable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMITable.Location = new System.Drawing.Point(1, 33);
            this.BMITable.Name = "BMITable";
            this.BMITable.RowCount = 4;
            this.BMITable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITable.Size = new System.Drawing.Size(299, 334);
            this.BMITable.TabIndex = 0;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.ForeColor = System.Drawing.Color.LightCoral;
            this.ImperialRadioButton.Location = new System.Drawing.Point(153, 24);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(137, 36);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MetricButton
            // 
            this.MetricButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MetricButton.AutoSize = true;
            this.MetricButton.ForeColor = System.Drawing.Color.LightCoral;
            this.MetricButton.Location = new System.Drawing.Point(4, 24);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(113, 36);
            this.MetricButton.TabIndex = 1;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(4, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Weight";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.AllowDrop = true;
            this.WeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightTextBox.Location = new System.Drawing.Point(153, 106);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(137, 38);
            this.WeightTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(4, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "My Height";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MyHeightTextbox
            // 
            this.MyHeightTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MyHeightTextbox.Location = new System.Drawing.Point(153, 189);
            this.MyHeightTextbox.Name = "MyHeightTextbox";
            this.MyHeightTextbox.Size = new System.Drawing.Size(137, 38);
            this.MyHeightTextbox.TabIndex = 4;
            // 
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::Lab_26___Finish_the_UI.Properties.Resources._624871;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.BMITable);
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

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMITable;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox WeightTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MyHeightTextbox;
    }
}

