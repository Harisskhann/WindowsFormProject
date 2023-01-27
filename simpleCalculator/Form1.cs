namespace simpleCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Complete_Click(object sender, EventArgs e)
        {
            double op1, op2, ans;

            op1=Convert.ToDouble(txtOp1.Text);
            op2= Convert.ToDouble(txtOp2.Text);

            switch (cboOpr.SelectedItem.ToString())
            {
                case "+":
                ans = op1 + op2;
                    txtAns.Text = ans.ToString();
                    break;

                    case "-":
                        ans = op1 - op2;
                    txtAns.Text = ans.ToString();
                    break;

                    case "*":
                        ans = op1 / op2;
                    txtAns.Text = ans.ToString();
                    break;

                    case "/":
                        ans = op1 / op2;
                    txtAns.Text = ans.ToString();
                    if (op2 == 0)
                    {
                        MessageBox.Show("Divided by zero Error!!!", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                    case "%":
                        ans = op2 / op1;
                        txtAns.Text = ans.ToString();
                    break;
                
                    default:
                    break;
            }
        }
    }
}