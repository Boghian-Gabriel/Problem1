using PrintingPatterns.Classes;
using PrintingPatterns.UserControls;
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PrintingPatterns
{
    public partial class MainForm : Form
    {
        #region "Properties"
        DateTime localDate;
        readonly StringBuilder stringBuilder = new StringBuilder();
        ucDate ucDateTime;
        int flag = 1;

        /// <summary>
        /// Properties for moving the window with the mouse
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region "Constructor"
        public MainForm()
        {
            InitializeComponent();            
            LoadForm();
        }
        #endregion

        #region "Load Form"
        private void LoadForm()
        {
            panelUcDateTime.Visible = false;
            comboBox1.Items.Add(Constants.SelectComboBox);
            comboBox1.SelectedItem = Constants.SelectComboBox;
            localDate = DateTime.Now;
            DateTimeBtn.Text = localDate.ToString("  dd.MM.yyyy");
            SetToolTip();
        }
        #endregion

        #region "Close btn"
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion       

        #region "Verify components"
        private bool IsEmpty(ComboBox combo, NumericUpDown numericUpDown1)
        {
            MessageBoxCls messageBoxCls = new MessageBoxCls
            {
                Message = $"Field {lbla1.Text} are required.",
                Caption = Constants.CaptionInformation,
                Button = MessageBoxButtons.OK,
                Icon = MessageBoxIcon.Warning
            };
            HelperMessageBox helperMessageBox = new HelperMessageBox(messageBoxCls);
            if ((string)combo.SelectedItem == Constants.SelectComboBox)
            {
                helperMessageBox.ShowMessageBox();
                combo.Focus();
                combo.DroppedDown = true;
                return false;
            }

            messageBoxCls.Message = $"Field {lbla2.Text} are required and must not be equal to zero...";
            if (String.IsNullOrEmpty(numericUpDown1.Text) || int.Parse(numericUpDown1.Text) == 0)
            {
                helperMessageBox.ShowMessageBox();
                numericUpDown1.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region "Events for combobox"
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(Constants.SelectComboBox);
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.Items.Insert(0, Constants.SelectComboBox);
                comboBox1.SelectedIndex = 0;
            }
        }
        #endregion

        #region "Buttons"

        #region "Button 1"
        /// <summary>
        /// if we select the * simbol and number equals to 5
        /// the result is:
        /// 1. *
        /// 2. *
        /// 3. *
        /// 4. *
        /// 5. *
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Printing1_Click(object sender, EventArgs e)
        {
            ClearStringBuilder();
            if (IsEmpty(comboBox1, numericUpDown1))
            {
                int nr = int.Parse(numericUpDown1.Text);                
                stringBuilder.AppendLine($"Symbol: {comboBox1.Text}" + " - " + $"Number: {numericUpDown1.Text}");
                stringBuilder.AppendLine("Result: ");
                for (int i = 0; i < nr; i++)
                {
                    stringBuilder.AppendLine($"{i + 1}. {comboBox1.Text}");
                }
                result.Text = stringBuilder.ToString();
            }
        }
        #endregion

        #region "Button 2"
        /// <summary>
        /// if we select the $ simbol and number equals to 5
        /// the result is:
        /// $$$$$ 
        /// $$$$
        /// $$$
        /// $$
        /// $
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Printing2_Click(object sender, EventArgs e)
        {
            ClearStringBuilder();
            if (IsEmpty(comboBox1, numericUpDown1))
            {
                int nr = int.Parse(numericUpDown1.Text);

                stringBuilder.AppendLine($"Symbol: {comboBox1.Text}" + " - " + $"Number: {numericUpDown1.Text}");
                stringBuilder.AppendLine("Result: ");

                for (int i = 0; i < nr; i++)
                {
                    for (int j = i; j < nr; j++)
                    {
                        stringBuilder.Append($"{comboBox1.Text}");
                    }
                    stringBuilder.AppendLine("");
                }
                result.Text = stringBuilder.ToString();
            }
        }
        #endregion

        #region "Button 3"
        /// <summary>
        /// if we select the # simbol and number equals to 5
        /// the result is:
        /// #
        /// ##
        /// ###
        /// ####
        /// #####
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Printing3_Click(object sender, EventArgs e)
        {
            //ToDo();
            ClearStringBuilder();
            if (IsEmpty(comboBox1, numericUpDown1))
            {
                int nr = int.Parse(numericUpDown1.Text);
                stringBuilder.AppendLine($"Symbol: {comboBox1.Text}" + " - " + $"Number: {numericUpDown1.Text}");
                stringBuilder.AppendLine("Result: ");
                
                for(int i = 0; i < nr; i++)
                {
                    for(int j = 0; j <=i; j++)
                    {
                        stringBuilder.Append($"{comboBox1.Text}");
                    }
                    stringBuilder.AppendLine("");
                }

                result.Text = stringBuilder.ToString();
            }
        }
        #endregion

        #region "Button 4"
        /// <summary>
        /// <summary>
        /// if we select the # simbol and number equals to 5
        /// the result is:        
        ///     @
        ///    @@
        ///   @@@
        ///  @@@@
        /// @@@@@
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Printing4_Click(object sender, EventArgs e)
        {
            //ToDo();
            ClearStringBuilder();
            if (IsEmpty(comboBox1, numericUpDown1))
            {
                int nr = int.Parse(numericUpDown1.Text);
                stringBuilder.AppendLine($"Symbol: {comboBox1.Text}" + " - " + $"Number: {numericUpDown1.Text}");
                stringBuilder.AppendLine("Result: ");

                for (int i = 0; i < nr; i++)
                {
                    for (int j = 0; j < nr - i - 1; j++)
                    {
                        stringBuilder.Append(" ");
                    }

                    for (int j = 0; j < i+1; j++)
                    {
                        stringBuilder.Append($"{comboBox1.Text}");
                    }
                    stringBuilder.AppendLine(" ");
                }

                result.Text = stringBuilder.ToString();
            }
        }
        #endregion

        #region "Button 5"
        /// <summary>
        ///  ***
        ///  **
        ///  *
        ///  *
        ///  **
        ///  ***
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Printing5_Click(object sender, EventArgs e)
        {
            //ToDo();
            ClearStringBuilder();
            if (IsEmpty(comboBox1, numericUpDown1))
            {
                int nr = int.Parse(numericUpDown1.Text);
                stringBuilder.AppendLine($"Symbol: {comboBox1.Text}" + " - " + $"Number: {numericUpDown1.Text}");
                stringBuilder.AppendLine("Result: ");

                for (int i = 0; i < nr; i++)
                {
                    for (int j = i; j < nr; j++)
                    {
                        stringBuilder.Append($"{comboBox1.Text}");
                    }
                    stringBuilder.AppendLine("");
                }
                for (int i = 0; i < nr; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        stringBuilder.Append($"{comboBox1.Text}");
                    }
                    stringBuilder.AppendLine("");
                }
                result.Text = stringBuilder.ToString();

            }
        }
        #endregion

        #region "Open User control DateTime"
        private void DateTime_Click(object sender, EventArgs e)
        {
            //to do... bug fix: display ucDateTime
            if (flag == 1)
            {
                panelUcDateTime.Visible = true;
                ucDateTime = new ucDate();
                //{
                //    Dock = DockStyle.Fill,
                //};
                
                panelUcDateTime.Controls.Add(ucDateTime);
                //panelUcDateTime.BringToFront();
                ucDateTime.BringToFront();
                flag = 0;
                return;
            }

            if (flag == 0)
            {
                ucDateTime.Dispose();
                panelUcDateTime.Visible = false;
                flag = 1;
            }
        }
        #endregion

        #endregion

        #region "To do"
        public void ToDo()
        {
            MessageBoxCls messageBoxCls = new MessageBoxCls
            {
                Message = Constants.MessageBoxToDo,
                Caption = Constants.CaptionInformation,
                Button = MessageBoxButtons.OK,
                Icon = MessageBoxIcon.Information
            };

            HelperMessageBox helperMessageBox = new HelperMessageBox(messageBoxCls);
            helperMessageBox.ShowMessageBox();
        }
        #endregion

        #region "Reset"
        private void ResetInfo()
        {
            comboBox1.Items.Insert(0, Constants.SelectComboBox);
            comboBox1.SelectedIndex = 0;

            numericUpDown1.Value = 0;
            result.ResetText();
        }
        
        private void BtnResetInfo_Click(object sender, EventArgs e)
        {
            //SecondForm secondForm = new SecondForm();
            //secondForm.ShowDialog();
            ResetInfo();
        }
        #endregion

        #region "Move window"
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region "ToolTip"
        /// <summary>
        /// \u0020 = ' ' (space)
        /// </summary>
        private void SetToolTip()
        {
            HelperToolTip helperToolTip = new HelperToolTip();

            helperToolTip.SetToolTip(Printing1, "1. *\n2. *\n3. *");
            helperToolTip.SetToolTip(Printing2, "***\n**\n*");
            helperToolTip.SetToolTip(Printing3, "*\n**\n***");
            helperToolTip.SetToolTip(Printing4, "    # \r\n   ## \r\n  ### \r\n");
            helperToolTip.SetToolTip(Printing5, "To do...");            
            helperToolTip.SetToolTip(DateTimeBtn, "You can expand this option ↓ or ↑  ");
        }
        #endregion

        #region "Dispose"
        public void ClearStringBuilder()
        {
            if(!String.IsNullOrEmpty(stringBuilder.ToString()))
            {
                stringBuilder.Clear();
            }            
        }
        #endregion
    }
}
