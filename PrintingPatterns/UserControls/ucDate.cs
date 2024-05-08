using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingPatterns.UserControls
{
    public partial class ucDate : UserControl
    {
        private readonly CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("ro-RO");

        public ucDate()
        {
            InitializeComponent();
            labelDate.Text = DateTime.Now.ToString("dd.MM.yyyy");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss", cultureInfo);
        }
    }
}
