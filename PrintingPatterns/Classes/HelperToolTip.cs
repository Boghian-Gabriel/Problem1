using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingPatterns.Classes
{
    public class HelperToolTip
    {
        private readonly ToolTip _toolTip;

        public HelperToolTip()
        {
            _toolTip = new ToolTip();
        }   

        public void SetToolTip(Control control, string toolTip)
        {
            _toolTip.SetToolTip(control, toolTip);
        }
    }
}
