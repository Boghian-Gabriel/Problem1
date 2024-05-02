using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingPatterns
{
    public partial class Form1 : Form
    {
        #region "Properties"
        DateTime localDate;
        #endregion

        #region "Constructor"
        public Form1()
        {
            InitializeComponent();

            LoadForm();
        }
        #endregion

        #region "Load Form"
        private void LoadForm()
        {
            panelUcDateTime.Visible = false;
            comboBox1.Items.Add("Select");
            comboBox1.SelectedItem = "Select";
            localDate = DateTime.Now;
            DateTimeBtn.Text = localDate.ToString("dd.MM.yyyy");
        }
        #endregion

        #region "Close btn"
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "DateTime uc"
        private void DateTime_Click(object sender, EventArgs e)
        {
            //to do...
            //ucDateTime ucDateTime = new ucDateTime(localDate);
            //panelUcDateTime.Controls.Add(ucDateTime);
            //panelUcDateTime.Visible = true;
        }
        #endregion       

        #region "Verify componenets"
        private bool IsEmpty(ComboBox combo, NumericUpDown numericUpDown1)
        {
            
            if ((string)combo.SelectedItem == "Select")
            {
                MessageBox.Show($"Field {lbla1.Text} are required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                combo.Focus();
                combo.DroppedDown = true;
                return false;
            }

            if (String.IsNullOrEmpty(numericUpDown1.Text))
            {
                MessageBox.Show($"Field {lbla2.Text} are required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDown1.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region "Events for combobox"
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Remove("Select");
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                comboBox1.Items.Add("Select");
                comboBox1.SelectedItem = "Select";
            }
        }
        #endregion

        #region "Buttons"
        #region "Buttons 1"
        private void Printing1_Click(object sender, EventArgs e)
        {
            if (IsEmpty(comboBox1, numericUpDown1))
            {
                int nr = int.Parse(numericUpDown1.Text);
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine(comboBox1.Text);
                stringBuilder.AppendLine(numericUpDown1.Text);
                for (int i = 0; i < nr; i++)
                {
                    stringBuilder.AppendLine($"{i + 1}. {comboBox1.Text}");
                }
                result.Text = stringBuilder.ToString();
            }
        }
        #endregion
        private void Printing2_Click(object sender, EventArgs e)
        {
            // to do...
        }
        private void Printing3_Click(object sender, EventArgs e)
        {
            // to do...
        }
        private void Printing4_Click(object sender, EventArgs e)
        {
            // to do...
        }
        private void Printing5_Click(object sender, EventArgs e)
        {
            // to do...
        }
        #endregion

        #region "Reset"
        private void ResetInfo()
        {
            comboBox1.Items.Clear();
            numericUpDown1.ResetText();
            result.ResetText();
        }
        #endregion
    }
}
