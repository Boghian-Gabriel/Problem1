using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CSV_To_SQLS
{
    public partial class SelecModule : Form
    {
        OpenFileDialog openFileDialog1;
        public string FolderPath { get; private set; } = Path.GetFullPath(AppContext.BaseDirectory);

        public SelecModule()
        {
            InitializeComponent();
            rbSelectFile.TabStop = false;
            rbAddMovieForm.TabStop = false;
        }

        #region "Close app"
        private void pbCloseApp_Click(object sender, EventArgs e)
        {
            if (rbSelectFile.TabStop == false && rbAddMovieForm.TabStop == false)
            {
                MessageBox.Show("You need to checked one option", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            { 
                this.Close(); 
            }
        }
        #endregion

        #region "Select Open File option"
        private void rbSelectFile_CheckedChanged(object sender, EventArgs e)
        {
            rbSelectFile.TabStop = true;

            openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = FolderPath + @"\CSV",
                Title = "Open File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "CSV",
                Filter = "csv File|*.csv|Excel File|*.xlsx|All Files|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FolderPath = openFileDialog1.FileName;
            }
           pbCloseApp_Click(sender, e);
        }
        #endregion

        #region "Select Add New Movie from Form"
        private void rbAddMovieForm_CheckedChanged(object sender, EventArgs e)
        {
            rbAddMovieForm.TabStop = true;

            List<Movie> list = new List<Movie>();   

            AddMovie addMovie = new AddMovie(list);
            var add = addMovie._movies;

            addMovie.ShowDialog();

            this.Close();

        }
        #endregion
    }
}
