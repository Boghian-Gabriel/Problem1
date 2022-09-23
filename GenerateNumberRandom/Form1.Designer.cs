namespace GenerateNumberRandom
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
            this.txtGenerate = new System.Windows.Forms.TextBox();
            this.txtVerify = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudMinVal = new System.Windows.Forms.NumericUpDown();
            this.nudMaxVal = new System.Windows.Forms.NumericUpDown();
            this.btnVerify = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblMsgErr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxVal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGenerate
            // 
            this.txtGenerate.Location = new System.Drawing.Point(53, 193);
            this.txtGenerate.Name = "txtGenerate";
            this.txtGenerate.Size = new System.Drawing.Size(168, 23);
            this.txtGenerate.TabIndex = 2;
            // 
            // txtVerify
            // 
            this.txtVerify.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.txtVerify.Location = new System.Drawing.Point(279, 135);
            this.txtVerify.Name = "txtVerify";
            this.txtVerify.Size = new System.Drawing.Size(168, 23);
            this.txtVerify.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "GENERATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Min Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Max Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number Generate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "-";
            // 
            // nudMinVal
            // 
            this.nudMinVal.Location = new System.Drawing.Point(53, 97);
            this.nudMinVal.Name = "nudMinVal";
            this.nudMinVal.Size = new System.Drawing.Size(71, 23);
            this.nudMinVal.TabIndex = 9;
            // 
            // nudMaxVal
            // 
            this.nudMaxVal.Location = new System.Drawing.Point(150, 97);
            this.nudMaxVal.Name = "nudMaxVal";
            this.nudMaxVal.Size = new System.Drawing.Size(71, 23);
            this.nudMaxVal.TabIndex = 10;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(279, 78);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(168, 23);
            this.btnVerify.TabIndex = 11;
            this.btnVerify.Text = "Verify Number";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number Verify";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(53, 135);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(168, 23);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Verify Number";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblMsgErr
            // 
            this.lblMsgErr.AutoSize = true;
            this.lblMsgErr.Location = new System.Drawing.Point(279, 201);
            this.lblMsgErr.Name = "lblMsgErr";
            this.lblMsgErr.Size = new System.Drawing.Size(91, 15);
            this.lblMsgErr.TabIndex = 14;
            this.lblMsgErr.Text = "lblMessageError";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 231);
            this.Controls.Add(this.lblMsgErr);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.nudMaxVal);
            this.Controls.Add(this.nudMinVal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVerify);
            this.Controls.Add(this.txtGenerate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtGenerate;
        private TextBox txtVerify;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown nudMinVal;
        private NumericUpDown nudMaxVal;
        private Button btnVerify;
        private Label label6;
        private Button btnGenerate;
        private Label lblMsgErr;
    }
}