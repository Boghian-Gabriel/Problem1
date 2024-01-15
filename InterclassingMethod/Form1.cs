namespace InterclassingMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array1 = Utility.ConvertTxtBoxToArrayOfInt(txtArray1);
            int[] array2 = Utility.ConvertTxtBoxToArrayOfInt(txtArray2);
            int[] mergedArray = new int[array1.Length + array2.Length];
            int iDim = mergedArray.Length;
            if (Utility.IsEmpty(txtArray1) && Utility.IsEmpty(txtArray2))
            {
                panel1.Visible = true;
                mergedArray = ArrayMerger.MergeSortedArrays(array1, array2, iDim);
            }
            else
            {
                MessageBox.Show("You must enter data into both arrays", "* Information *", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Console.WriteLine("Merged Array:");
            //Array.Sort(mergedArray);
            //foreach (var element in mergedArray)
            //{
            //    txtArrayResult.Text += element.ToString() + " ";
            //}

            txtArrayResult.Text = string.Join(" ", mergedArray.OrderBy(x => x));
            txtResDuplicates.Text = string.Join(" ", mergedArray.OrderBy(x => x).Distinct());
        }
    }
}