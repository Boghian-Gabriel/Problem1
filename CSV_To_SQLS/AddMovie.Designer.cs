namespace CSV_To_SQLS
{
    partial class AddMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovie));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTile = new System.Windows.Forms.TextBox();
            this.dtReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPdfName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnJSONPDF = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.btnSaveMovie = new System.Windows.Forms.Button();
            this.pbCloseApp = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseApp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(111)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Movie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(111)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.groupBox1.Location = new System.Drawing.Point(15, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 162);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movies";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.31034F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.68966F));
            this.tableLayoutPanel1.Controls.Add(this.txtGenre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTile, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtReleaseDate, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtGenre
            // 
            this.txtGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGenre.Location = new System.Drawing.Point(116, 36);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(171, 23);
            this.txtGenre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Genre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 34);
            this.label4.TabIndex = 2;
            this.label4.Text = "ReleaseDate";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTile
            // 
            this.txtTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTile.Location = new System.Drawing.Point(116, 3);
            this.txtTile.Name = "txtTile";
            this.txtTile.Size = new System.Drawing.Size(171, 23);
            this.txtTile.TabIndex = 0;
            // 
            // dtReleaseDate
            // 
            this.dtReleaseDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtReleaseDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReleaseDate.Location = new System.Drawing.Point(116, 69);
            this.dtReleaseDate.Name = "dtReleaseDate";
            this.dtReleaseDate.Size = new System.Drawing.Size(171, 23);
            this.dtReleaseDate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(111)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(15, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total numbers of movies added:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCount
            // 
            this.labelCount.BackColor = System.Drawing.Color.Transparent;
            this.labelCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(111)))), ((int)(((byte)(192)))));
            this.labelCount.Location = new System.Drawing.Point(267, 86);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(50, 23);
            this.labelCount.TabIndex = 16;
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(111)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 42);
            this.button1.TabIndex = 17;
            this.button1.Text = "Create PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtPdfName
            // 
            this.txtPdfName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPdfName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPdfName.Location = new System.Drawing.Point(3, 17);
            this.txtPdfName.Name = "txtPdfName";
            this.txtPdfName.Size = new System.Drawing.Size(296, 23);
            this.txtPdfName.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(111)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 42);
            this.button2.TabIndex = 20;
            this.button2.Text = "Save to JSON";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnJSONPDF
            // 
            this.btnJSONPDF.BackColor = System.Drawing.Color.White;
            this.btnJSONPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJSONPDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(111)))), ((int)(((byte)(192)))));
            this.btnJSONPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJSONPDF.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJSONPDF.Location = new System.Drawing.Point(170, 381);
            this.btnJSONPDF.Name = "btnJSONPDF";
            this.btnJSONPDF.Size = new System.Drawing.Size(147, 42);
            this.btnJSONPDF.TabIndex = 21;
            this.btnJSONPDF.Text = "JSON- PDF";
            this.btnJSONPDF.UseVisualStyleBackColor = false;
            this.btnJSONPDF.Click += new System.EventHandler(this.btnJSONPDF_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPdfName);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 42);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FileName";
            // 
            // pbBack
            // 
            this.pbBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(12, 12);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(24, 24);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 23;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // btnSaveMovie
            // 
            this.btnSaveMovie.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveMovie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(111)))), ((int)(((byte)(192)))));
            this.btnSaveMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMovie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMovie.ForeColor = System.Drawing.Color.White;
            this.btnSaveMovie.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveMovie.Image")));
            this.btnSaveMovie.Location = new System.Drawing.Point(15, 284);
            this.btnSaveMovie.Name = "btnSaveMovie";
            this.btnSaveMovie.Size = new System.Drawing.Size(302, 42);
            this.btnSaveMovie.TabIndex = 14;
            this.btnSaveMovie.Text = "  Add";
            this.btnSaveMovie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveMovie.UseVisualStyleBackColor = false;
            this.btnSaveMovie.Click += new System.EventHandler(this.button1_Click);
            this.btnSaveMovie.MouseLeave += new System.EventHandler(this.btnSaveMovie_MouseLeave);
            this.btnSaveMovie.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // pbCloseApp
            // 
            this.pbCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCloseApp.Image = ((System.Drawing.Image)(resources.GetObject("pbCloseApp.Image")));
            this.pbCloseApp.Location = new System.Drawing.Point(293, 12);
            this.pbCloseApp.Name = "pbCloseApp";
            this.pbCloseApp.Size = new System.Drawing.Size(24, 24);
            this.pbCloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCloseApp.TabIndex = 12;
            this.pbCloseApp.TabStop = false;
            this.pbCloseApp.Click += new System.EventHandler(this.pbCloseApp_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 483);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnJSONPDF);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSaveMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbCloseApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMovie";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCloseApp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveMovie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtTile;
        private System.Windows.Forms.DateTimePicker dtReleaseDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPdfName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnJSONPDF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbBack;
    }
}