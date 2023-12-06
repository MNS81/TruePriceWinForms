namespace TruePriceWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            WeightInput = new NumericUpDown();
            PriceInput = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            CalculateButton = new Button();
            ListWiewButton = new Button();
            ResetAllButton = new Button();
            CalculateOutput = new TextBox();
            BestPriseText = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WeightInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceInput).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(WeightInput);
            groupBox1.Controls.Add(PriceInput);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 85);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод значений";
            // 
            // WeightInput
            // 
            WeightInput.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            WeightInput.Location = new Point(84, 52);
            WeightInput.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            WeightInput.Name = "WeightInput";
            WeightInput.Size = new Size(120, 23);
            WeightInput.TabIndex = 3;
            // 
            // PriceInput
            // 
            PriceInput.Location = new Point(84, 30);
            PriceInput.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            PriceInput.Name = "PriceInput";
            PriceInput.Size = new Size(120, 23);
            PriceInput.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 54);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Вес гр.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Цена руб.";
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(12, 106);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(219, 32);
            CalculateButton.TabIndex = 1;
            CalculateButton.Text = "Рассчитать";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ListWiewButton
            // 
            ListWiewButton.Location = new Point(12, 253);
            ListWiewButton.Name = "ListWiewButton";
            ListWiewButton.Size = new Size(219, 32);
            ListWiewButton.TabIndex = 2;
            ListWiewButton.Text = "Список";
            ListWiewButton.UseVisualStyleBackColor = true;
            ListWiewButton.Click += ListWiewButton_Click;
            // 
            // ResetAllButton
            // 
            ResetAllButton.Location = new Point(12, 291);
            ResetAllButton.Name = "ResetAllButton";
            ResetAllButton.Size = new Size(219, 32);
            ResetAllButton.TabIndex = 4;
            ResetAllButton.Text = "Сброс";
            ResetAllButton.UseVisualStyleBackColor = true;
            ResetAllButton.Click += ResetAllButton_Click;
            // 
            // CalculateOutput
            // 
            CalculateOutput.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CalculateOutput.Location = new Point(12, 144);
            CalculateOutput.Multiline = true;
            CalculateOutput.Name = "CalculateOutput";
            CalculateOutput.ReadOnly = true;
            CalculateOutput.Size = new Size(219, 31);
            CalculateOutput.TabIndex = 5;
            CalculateOutput.TextAlign = HorizontalAlignment.Center;
            CalculateOutput.TextChanged += CalculateOutput_TextChanged;
            // 
            // BestPriseText
            // 
            BestPriseText.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BestPriseText.ForeColor = SystemColors.Desktop;
            BestPriseText.Location = new Point(12, 181);
            BestPriseText.Multiline = true;
            BestPriseText.Name = "BestPriseText";
            BestPriseText.Size = new Size(219, 66);
            BestPriseText.TabIndex = 6;
            BestPriseText.TextAlign = HorizontalAlignment.Center;
            BestPriseText.TextChanged += BestPriseText_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 332);
            Controls.Add(BestPriseText);
            Controls.Add(CalculateOutput);
            Controls.Add(ResetAllButton);
            Controls.Add(ListWiewButton);
            Controls.Add(CalculateButton);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Честная цена";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WeightInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown WeightInput;
        private NumericUpDown PriceInput;
        private Label label2;
        private Label label1;
        private Button CalculateButton;
        private Button ListWiewButton;
        private Button ResetAllButton;
        private TextBox CalculateOutput;
        private TextBox BestPriseText;
    }
}