using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pp
{
    public partial class Mainn : Form
    {
        public int empp_id { get; set; }
        public Mainn()
        {
            InitializeComponent();
        }
        DataClassDataContext dcc = new DataClassDataContext();
        private void Main_Load(object sender, EventArgs e)
        {
            var emp_name = (from i in dcc.employees where i.id == empp_id select i.name).FirstOrDefault();
            label1.Text = "Welcome " + emp_name;
        }

        private void profil_Click(object sender, EventArgs e)
        {
            profill(empp_id);
        }

        private void apply1_Click(object sender, EventArgs e)
        {
            Mutation mutation = new Mutation();
            this.Hide();
            mutation.ShowDialog();
        }

        private void apply2_Click(object sender, EventArgs e)
        {
            Promotion promotion = new Promotion();
            this.Hide();
            promotion.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login login =new Login();
            this.Hide();
            login.ShowDialog();
        }
        void profill (int emp_id)
        {
            Profil profil = new Profil();
            profil.emp_id = emp_id;
            this.Hide();
            profil.ShowDialog();
        }
    }
}
