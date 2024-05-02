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
    public partial class ucDateTime : UserControl
    {
        private readonly DateTime datetime;
        public ucDateTime(DateTime datetime)
        {
            InitializeComponent();
            this.datetime = datetime;

            labelDate.Text = datetime.ToString("dd.MM.yyyy");
        }

        private void ucButtons1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
