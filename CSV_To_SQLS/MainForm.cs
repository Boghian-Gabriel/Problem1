using CSV_To_SQLS.Classes;
using iTextSharp.text.pdf.qrcode;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ToolTip = System.Windows.Forms.ToolTip;

namespace CSV_To_SQLS
{
    public partial class MainForm : Form
    {
        readonly ToolTip toolTip = new ToolTip();
        List<Movie> listMovies;
        DataTable dataTable;
        public MainForm()
        {
            InitializeComponent();
            SetToolTipToComponents();
            pbCloseApp.Visible = false;
            CheckRows();
        }

        #region "Toll Tip"
        public void SetToolTipToComponents()
        {
            toolTip.SetToolTip(btnSelectCSV, "Select csv file");
            toolTip.SetToolTip(btnSaveFile, "Save to database");
            toolTip.SetToolTip(pbCloseApp, "Close app");
        }
        #endregion

        #region "Check if exist rows in data gridview"
        private void CheckRows()
        {
            if(dgMovies.Rows.Count == 0) 
            {
                labelCount.Text = "No records";
            }
            else
            {
                labelCount.Text = dgMovies.Rows.Count.ToString();
            }
        }
        #endregion

        #region "Select file from PC"
        /// <summary>
        /// to do select csv file 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectCSV_Click(object sender, EventArgs e)
        {          
            SelecModule selecModule = new SelecModule();
            selecModule.ShowDialog();
            if (!string.IsNullOrEmpty(selecModule.FolderPath))
            {
                txtFilePath.Text = selecModule.FolderPath;
                toolTip.SetToolTip(txtFilePath, $"{selecModule.FolderPath}");

                ReadFromCSV readFromCSV = new ReadFromCSV();
                dataTable = readFromCSV.ReadFromCSVFile(txtFilePath.Text);
                if(dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Select other file because this is empty.","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgMovies.DataSource = dataTable;
                } 

                labelCount.Text = dataTable.Rows.Count.ToString();
            }
        }
        #endregion

        #region "From DataTable to List
        public List<Movie> ConvertToListFromDataTable(DataTable dataTable)
        {
            listMovies = new List<Movie>();

            for(int i=0; i<dataTable.Rows.Count; i++)
            {
                Movie movie = new Movie();
                movie.Title = dataTable.Rows[i]["Title"].ToString();
                movie.Genre = dataTable.Rows[i]["Genre"].ToString();
                movie.ReleaseDate = DateTime.Parse(dataTable.Rows[i]["ReleaseDate"].ToString());
                
                listMovies.Add(movie);
            }

            return listMovies;

        }
        #endregion

        #region "Save Info"
        /// <summary>
        /// to do save data to sql server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text))
            {
                MessageBox.Show("You need to select a file","Information", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                btnSelectCSV.Focus();
                return;
            }

            if (dgMovies.Rows.Count == 0)
            {
                MessageBox.Show("You must choose files that contain data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSelectCSV.Focus();
                return;
            }

            try
            {
                DatabaseHelper connDb = new DatabaseHelper();

                if(dataTable.Rows.Count != 0)
                {
                    var movies = ConvertToListFromDataTable(dataTable);
                    foreach (var movie in movies)
                    {
                        connDb.InsertData(movie);
                    }
                    MessageBox.Show("All information has been successfully inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Exception: " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }
        #endregion

        #region "Resize main form"
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                pbCloseApp.Visible = true;
            }
            else
            {
                pbCloseApp.Visible = false;
            }
        }
        #endregion

        #region "Close app"
        private void pbCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion       
    }
}
