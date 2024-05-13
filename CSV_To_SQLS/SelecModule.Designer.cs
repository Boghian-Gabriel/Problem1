namespace CSV_To_SQLS
{
    partial class SelecModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecModule));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rbSelectFile = new System.Windows.Forms.RadioButton();
            this.rbAddMovieForm = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbCloseApp = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseApp)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rbSelectFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbAddMovieForm, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(265, 82);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // rbSelectFile
            // 
            this.rbSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSelectFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbSelectFile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSelectFile.Image = global::CSV_To_SQLS.Properties.Resources.csv1;
            this.rbSelectFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbSelectFile.Location = new System.Drawing.Point(3, 3);
            this.rbSelectFile.Name = "rbSelectFile";
            this.rbSelectFile.Size = new System.Drawing.Size(259, 35);
            this.rbSelectFile.TabIndex = 12;
            this.rbSelectFile.Text = "  Chose file";
            this.rbSelectFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbSelectFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbSelectFile.UseVisualStyleBackColor = true;
            this.rbSelectFile.CheckedChanged += new System.EventHandler(this.rbSelectFile_CheckedChanged);
            // 
            // rbAddMovieForm
            // 
            this.rbAddMovieForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAddMovieForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbAddMovieForm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAddMovieForm.Image = ((System.Drawing.Image)(resources.GetObject("rbAddMovieForm.Image")));
            this.rbAddMovieForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbAddMovieForm.Location = new System.Drawing.Point(3, 44);
            this.rbAddMovieForm.Name = "rbAddMovieForm";
            this.rbAddMovieForm.Size = new System.Drawing.Size(259, 35);
            this.rbAddMovieForm.TabIndex = 13;
            this.rbAddMovieForm.Text = "  Open Movie Form";
            this.rbAddMovieForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAddMovieForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbAddMovieForm.UseVisualStyleBackColor = true;
            this.rbAddMovieForm.CheckedChanged += new System.EventHandler(this.rbAddMovieForm_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 104);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select option:";
            // 
            // pbBack
            // 
            this.pbBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::CSV_To_SQLS.Properties.Resources.arrow1;
            this.pbBack.Location = new System.Drawing.Point(15, 12);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(24, 24);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 24;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbCloseApp
            // 
            this.pbCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCloseApp.Image = ((System.Drawing.Image)(resources.GetObject("pbCloseApp.Image")));
            this.pbCloseApp.Location = new System.Drawing.Point(262, 12);
            this.pbCloseApp.Name = "pbCloseApp";
            this.pbCloseApp.Size = new System.Drawing.Size(24, 24);
            this.pbCloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCloseApp.TabIndex = 11;
            this.pbCloseApp.TabStop = false;
            this.pbCloseApp.Click += new System.EventHandler(this.pbCloseApp_Click);
            // 
            // SelecModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 170);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbCloseApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelecModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelecModule";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCloseApp;
        private System.Windows.Forms.RadioButton rbSelectFile;
        private System.Windows.Forms.RadioButton rbAddMovieForm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbBack;
    }
}