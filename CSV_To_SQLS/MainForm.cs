using CSV_To_SQLS.Classes;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ToolTip = System.Windows.Forms.ToolTip;

namespace CSV_To_SQLS
{
    public partial class MainForm : Form
    {
        readonly ToolTip toolTip = new ToolTip();
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
                DataTable dataTable = readFromCSV.ReadFromCSVFile(txtFilePath.Text);
                dgMovies.DataSource = dataTable;    

                labelCount.Text = dataTable.Rows.Count.ToString();
            }
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
            //to do...
            /*
             read data from csv file and add into GridView DataSource 
             */
            if (string.IsNullOrEmpty(txtFilePath.Text))
            {
                MessageBox.Show("You need to select a file","Information", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                btnSelectCSV.Focus();
                return;
            }

            if (dgMovies.Rows.Count == 0)
            {
                MessageBox.Show("You must choose files that contain data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return;
            }

            try
            {
                

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
