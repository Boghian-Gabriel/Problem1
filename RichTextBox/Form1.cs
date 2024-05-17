using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace RichTextBox
{
    public partial class FRichTextBox : Form
    {
        Person personInfo;
        public FRichTextBox()
        {
            InitializeComponent();
            
            AddToolTip();
            lblFooter.Text = DateTime.Now.ToString("dd.MM.yyyy");

            btnReset.Enabled = false;
            rchTextBoxInformation.Clear();
            personInfo = new Person();


            // for new fonts
            string sBasePath = Path.GetFullPath(AppContext.BaseDirectory);
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile($@"{sBasePath}\Font\Poppins-Bold.ttf");
            pfc.AddFontFile($@"{sBasePath}\Font\Poppins-Medium.ttf");
            pfc.AddFontFile($@"{sBasePath}\Font\Poppins-Semibold.ttf");
            
            lblText.Font = new Font(pfc.Families[0], 12, FontStyle.Bold);
            lblFirstName.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            lblLastName.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);

            txtFirstName.Font = new Font(pfc.Families[0], 12, FontStyle.Bold);
            txtLastName.Font = new Font(pfc.Families[0], 12, FontStyle.Bold);

            rchTextBoxInformation.Font = new Font(pfc.Families[0], 12, FontStyle.Bold);

            lblFooter.Font = new Font(pfc.Families[0], 10, FontStyle.Bold);

        }

        private void AddToolTip()
        {
            ToolTipInformation.AddToolTip(btnAddInfo, "Add info to RichTextBox");
            ToolTipInformation.AddToolTip(btnReset, "Reset info from RichTextBox");
        }

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            rchTextBoxInformation.Clear();

            if(!IsEmptyField(txtFirstName, lblFirstName)) { return; }
            if(!IsEmptyField(txtLastName, lblLastName)) { return; }
            
            personInfo = new Person
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
            };

            rchTextBoxInformation.SelectionBullet = true;

            rchTextBoxInformation.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            rchTextBoxInformation.SelectionColor = Color.DarkRed;
            rchTextBoxInformation.SelectedText = $"First name: {personInfo.FirstName}\n";

            rchTextBoxInformation.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            rchTextBoxInformation.SelectionColor = Color.DarkGreen;
            rchTextBoxInformation.SelectedText = $"Last name: {personInfo.LastName}\n";


            rchTextBoxInformation.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            rchTextBoxInformation.SelectionColor = Color.DarkBlue;
            rchTextBoxInformation.AppendText($"Full name: {personInfo}");

            RichTextBoxEmpty();

        }

        private bool IsEmptyField(TextBox textBox, System.Windows.Forms.Label label)
        {
            if(string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show($"{label.Text} is empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }

        private void RichTextBoxEmpty()
        {
            if (!string.IsNullOrEmpty(rchTextBoxInformation.Text))
            {
                btnReset.Enabled = true;
            }
            else
            {
                btnReset.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rchTextBoxInformation.Clear();
            rchTextBoxInformation.SelectionBullet = false;
        }
    }
}
