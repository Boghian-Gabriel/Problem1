namespace InterclassingMethod
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
            txtArray1 = new TextBox();
            txtArray2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            txtResDuplicates = new TextBox();
            txtArrayResult = new TextBox();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtArray1
            // 
            txtArray1.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtArray1.Location = new Point(67, 93);
            txtArray1.Margin = new Padding(3, 2, 3, 2);
            txtArray1.Name = "txtArray1";
            txtArray1.Size = new Size(316, 29);
            txtArray1.TabIndex = 0;
            // 
            // txtArray2
            // 
            txtArray2.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtArray2.Location = new Point(67, 147);
            txtArray2.Margin = new Padding(3, 2, 3, 2);
            txtArray2.Name = "txtArray2";
            txtArray2.Size = new Size(316, 29);
            txtArray2.TabIndex = 1;
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 26);
            label1.Name = "label1";
            label1.Size = new Size(316, 33);
            label1.TabIndex = 2;
            label1.Text = "In this form, you can add two arrays:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(67, 74);
            label2.Name = "label2";
            label2.Size = new Size(55, 18);
            label2.TabIndex = 3;
            label2.Text = "Array1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(67, 130);
            label3.Name = "label3";
            label3.Size = new Size(55, 18);
            label3.TabIndex = 4;
            label3.Text = "Array2:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtResDuplicates);
            panel1.Controls.Add(txtArrayResult);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 237);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 118);
            panel1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(69, 61);
            label6.Name = "label6";
            label6.Size = new Size(186, 18);
            label6.TabIndex = 10;
            label6.Text = "Result without duplicates:";
            // 
            // txtResDuplicates
            // 
            txtResDuplicates.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtResDuplicates.Location = new Point(67, 80);
            txtResDuplicates.Margin = new Padding(3, 2, 3, 2);
            txtResDuplicates.Name = "txtResDuplicates";
            txtResDuplicates.Size = new Size(316, 29);
            txtResDuplicates.TabIndex = 8;
            // 
            // txtArrayResult
            // 
            txtArrayResult.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtArrayResult.Location = new Point(67, 32);
            txtArrayResult.Margin = new Padding(3, 2, 3, 2);
            txtArrayResult.Name = "txtArrayResult";
            txtArrayResult.Size = new Size(316, 29);
            txtArrayResult.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(67, 61);
            label5.Name = "label5";
            label5.Size = new Size(0, 18);
            label5.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(67, 14);
            label4.Name = "label4";
            label4.Size = new Size(55, 18);
            label4.TabIndex = 7;
            label4.Text = "Result:";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = SystemColors.GradientActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(67, 202);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(315, 31);
            button1.TabIndex = 6;
            button1.Text = "Result";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(436, 355);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtArray2);
            Controls.Add(txtArray1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interclassing Method";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArray1;
        private TextBox txtArray2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Button button1;
        private TextBox txtArrayResult;
        private Label label4;
        private Label label6;
        private TextBox txtResDuplicates;
        private Label label5;
    }
}