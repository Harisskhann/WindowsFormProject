namespace NewForm
{
    public partial class frmnewform : Form
    {
        string UserName="HashimAmla", Password="HashimAmla2";
        public frmnewform()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmnewform_Load(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            txtusername.Clear();
        }

        private void txtpwd_TextChanged(object sender, EventArgs e)
        {
            txtpwd.Clear();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
          if(UserName==txtusername.Text && Password == txtpwd.Text)
          {
                MessageBox.Show("Login sucessfull : " + UserName); 

          }
            else
            {
                MessageBox.Show("invalid User Name or Password");
            }
        }
    }
}