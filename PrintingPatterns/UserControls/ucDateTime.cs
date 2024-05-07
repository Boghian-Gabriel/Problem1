using System;
using System.Windows.Forms;

namespace PrintingPatterns
{
    public partial class ucDateTime : UserControl
    {
        public ucDateTime()
        {
            InitializeComponent();
            labelDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void ucButtons1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
