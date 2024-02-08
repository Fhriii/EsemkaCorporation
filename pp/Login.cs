namespace pp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DataClassDataContext dc =new DataClassDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            var employee = (from c in dc.employees where c.email == textBox1.Text select c).FirstOrDefault();
            if (employee != null)
            {
                if (employee.password == textBox2.Text)
                {
                    mainn(employee.id);

                }
                else
                {
                    MessageBox.Show("Password Salah");
                }
            }
            else
            {
                MessageBox.Show("User Tidak Ada");

            }
        }
        void mainn(int emp_id)
        {
            Mainn main = new Mainn();
            main.empp_id=emp_id;
            this.Hide();
            main.ShowDialog();
        }
    }
}
