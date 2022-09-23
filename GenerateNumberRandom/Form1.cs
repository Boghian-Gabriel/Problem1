namespace GenerateNumberRandom
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            lblMsgErr.Visible = false;

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (nudMinVal.Value < 0 || nudMaxVal.Value < 0)
            {
                lblMsgErr.Visible = true;
                lblMsgErr.Text = "Valorile trebuie sa fie pozitive";
            }
            else if(nudMinVal.Value == 0 || nudMaxVal.Value == 0)
            {
                txtGenerate.Text = "0";
            }
            else
            {
                Random random = new Random();
                int number = random.Next((int)nudMinVal.Value, (int)nudMaxVal.Value);

                txtGenerate.Text = number.ToString();
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtGenerate.Text == "")
            {
                lblMsgErr.Text = "Lipseste valoarea din campul alaturat";
            }
            else
            {
                int rez = Convert.ToInt32(txtGenerate.Text);

                if (rez % 2 == 0)
                {
                    txtVerify.Text = $"The number {rez} is the even number";
                }
                else
                {
                    txtVerify.Text = $"The number {rez} is the even number";

                }
            }
        }
    }
}