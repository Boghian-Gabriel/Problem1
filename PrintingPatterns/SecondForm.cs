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
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
            ucDateTime ucDate = new ucDateTime();
            panel1.Controls.Add(ucDate);
        }
    }
}
