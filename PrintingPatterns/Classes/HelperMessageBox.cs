using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingPatterns
{
    public class HelperMessageBox
    {
        private readonly MessageBoxCls _messageBoxCls;        

        public HelperMessageBox(MessageBoxCls messageBoxCls)
        {
            _messageBoxCls = messageBoxCls;
        }

        public void ShowMessageBox()
        {
            MessageBox.Show(_messageBoxCls.Message, _messageBoxCls.Caption, _messageBoxCls.Button,_messageBoxCls.Icon);
        }
    }
}
