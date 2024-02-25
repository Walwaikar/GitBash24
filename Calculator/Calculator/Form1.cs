namespace Calculator
{
    public partial class Form1 : Form
    {
        float num1, num2, results;
        String Var;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtboxDisplayResult.Text += btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtboxDisplayResult.Text += btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtboxDisplayResult.Text += btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtboxDisplayResult.Text += btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtboxDisplayResult.Text += btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtboxDisplayResult.Text = btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtboxDisplayResult.Text += btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtboxDisplayResult.Text += btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtboxDisplayResult.Text += btnNine.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Var = "+";
            float.TryParse(txtboxDisplayResult.Text, out num1);
            txtboxDisplayResult.Text = " ";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Var = "-";
            float.TryParse(txtboxDisplayResult.Text, out num1);
            txtboxDisplayResult.Text = " ";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            Var = "*";
            float.TryParse(txtboxDisplayResult.Text, out num1);
            txtboxDisplayResult.Text = " ";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Var = "/";
            float.TryParse(txtboxDisplayResult.Text, out num1);
            txtboxDisplayResult.Text = " ";
        }

        private void btnEqualto_Click(object sender, EventArgs e)
        {
            float.TryParse(txtboxDisplayResult.Text, out num2);

            if (Var == "+")
            {
                results = num1 + num2;
            }
            else if (Var == "-")
            {
                results = num1 - num2;
            }
            else if (Var == "*")
            {
                results = num1 * num2;
            }
            else if (Var == "/")
            {
                results = num1 / num2;
            }

            txtboxDisplayResult.Text = results.ToString();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtboxDisplayResult.Text += btnZero.Text;
        }

        private void btnDoublezero_Click(object sender, EventArgs e)
        {
            txtboxDisplayResult.Text += btnDoublezero.Text;
        }

        private void txtboxDisplayResult_TextChanged(object sender, EventArgs e)
        {
            txtboxDisplayResult.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxDisplayResult.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
