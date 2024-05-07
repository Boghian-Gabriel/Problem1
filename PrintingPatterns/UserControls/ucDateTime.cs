using System;
using System.Windows.Forms;

namespace PrintingPatterns
{
    public partial class ucDateTime : UserControl
    {
        public bool IsOpen { get; private set; } = false;
        public ucDateTime()
        {
            InitializeComponent();
            labelDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            IsOpen = true;
            Dock = DockStyle.Fill;
        }

        private void ucButtons1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
