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
    public partial class Form1 : Form
    {
        Person personInfo;
        public Form1()
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
            rchTextBoxInformation.AppendText($"First name: {personInfo.FirstName}\n");
            rchTextBoxInformation.AppendText($"Last name: {personInfo.LastName}\n");
            rchTextBoxInformation.AppendText($"Full name: {personInfo}");
        }

        private bool IsEmptyField(TextBox textBox, Label label)
        {
            if(string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show($"{nameof(label.Name)} is empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
