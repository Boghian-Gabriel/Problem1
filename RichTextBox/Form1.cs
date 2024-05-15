using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBox
{
    public partial class FRichTextBox : Form
    {
        Person personInfo;
        public FRichTextBox()
        {
            InitializeComponent();
            lblFooter.Text = DateTime.Now.ToString("dd.MM.yyyy");
            rchTextBoxInformation.Clear();
            personInfo = new Person();
        }

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            if(!IsEmptyField(txtFirstName, lblFirstName)) { return; }
            if(!IsEmptyField(txtLastName, lblLastName)) { return; }
            
            personInfo = new Person
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
            };

            rchTextBoxInformation.SelectionBullet = true;

            rchTextBoxInformation.SelectionFont = new Font("Arial", 16);
            rchTextBoxInformation.SelectionColor = Color.DarkRed;
            rchTextBoxInformation.SelectedText = $"First name: {personInfo.FirstName}\n";

            rchTextBoxInformation.SelectionFont = new Font("Arial", 12);
            rchTextBoxInformation.SelectionColor = Color.DarkGreen;
            rchTextBoxInformation.SelectedText = $"Last name: {personInfo.LastName}\n";


            rchTextBoxInformation.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            rchTextBoxInformation.SelectionColor = Color.DarkBlue;
            rchTextBoxInformation.AppendText($"Full name: {personInfo}");

        }

        private bool IsEmptyField(TextBox textBox, Label label)
        {
            if(string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show($"{label.Text} is empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
