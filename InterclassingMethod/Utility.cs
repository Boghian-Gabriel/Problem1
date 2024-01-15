using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterclassingMethod
{
    public static class Utility
    {       
        public static int[] ConvertTxtBoxToArrayOfInt(TextBox sTxtBox)
        {
            string[] strArray = sTxtBox.Text.Split(new char[] { ',', ';', ',', ';', ' ' });
            int[] intArray = strArray.Select(s => int.Parse(s.Trim())).ToArray();

            return intArray;
        }
        
        public static bool IsEmpty(TextBox textBox)
        {
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                return true;
            }
            return false;
        }
    }   
}
