namespace Calculator
{
    public partial class FrmCalc : Form
    {

        double firstnumber;
        double secondnumber;
        double result;
        string operationPerformed = " ";
    
        
        public FrmCalc()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtresult.Text = txtresult.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtresult.Text = txtresult.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtresult.Text = txtresult.Text+ btn3.Text;
       
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtresult.Text = txtresult.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            txtresult.Text = txtresult.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtresult.Text = txtresult.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtresult.Text = txtresult.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtresult.Text = txtresult.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtresult.Text = txtresult.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtresult.Text = txtresult.Text + btn0.Text;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(txtresult.Text);
            
            operationPerformed = "+";
            txtresult.Clear();

        }



        private void btndot_Click(object sender, EventArgs e)
        {
            txtresult.Text = txtresult.Text + ".";
        }

        private void btnsubtract_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(txtresult.Text);
            
            operationPerformed = "-";
            txtresult.Clear();

        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(txtresult.Text);
           
            operationPerformed = "*";
            txtresult.Clear();

        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(txtresult.Text);
            
            operationPerformed = "/";
            txtresult.Clear();

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtresult.Text = " ";
        }

        private void BTNclear_Click(object sender, EventArgs e)
        {
            txtresult.Text = " ";
        }
        private void btnequal_Click(object sender, EventArgs e)
        {
            secondnumber = Convert.ToDouble(txtresult.Text);

            switch (operationPerformed)
            {

                case "+":
                    result = (firstnumber + secondnumber);
                    txtresult.Text=Convert.ToString(result);
                   
                    break;

                case "-":
                    result = (firstnumber - secondnumber);
                    txtresult.Text = Convert.ToString(result);
                    
                    break;

                case "*":
                    result = (firstnumber * secondnumber);
                    txtresult.Text = Convert.ToString(result);
                 

                    break;

                case "/":
                    result = (firstnumber / secondnumber);
                    txtresult.Text = Convert.ToString(result);
                   
                    break;
                default:
                    break;


            }
        }
    }
}