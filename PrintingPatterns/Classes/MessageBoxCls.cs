using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingPatterns
{
    public class MessageBoxCls
    {
        public string Message { get;set; }
        public string Caption { get;set; }

        public MessageBoxButtons Button { get;set; }

        public MessageBoxIcon Icon { get;set; }

    }
}
