using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace CSV_To_SQLS
{
    public partial class MainForm : Form
    {
        readonly ToolTip toolTip = new ToolTip();
        readonly string FolderPath = Path.GetFullPath(Application.StartupPath);
        OpenFileDialog openFileDialog1;
        public MainForm()
        {
            InitializeComponent();
            SetToolTipToComponents();
        }

        public void SetToolTipToComponents()
        {
            toolTip.SetToolTip(btnSelectCSV, "Select csv file");
            toolTip.SetToolTip(btnSaveFile, "Save to database");            
        }

        /// <summary>
        /// to do select csv file 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectCSV_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = FolderPath + @"\CSV",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
                toolTip.SetToolTip(txtFilePath, $"{openFileDialog1.FileName}");
            }
        }

        /// <summary>
        /// to do save data to sql server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
