using System.Windows.Forms;

namespace RichTextBox
{
    public static class ToolTipInformation
    {
        public static void AddToolTip(Button button, string info)
        {
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(button, info);
        }
    }
}
