using PrintingPatterns.UserControls;
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
            ucDate ucDt = new ucDate();
            panel1.Controls.Add(ucDt);
        }
    }
}
