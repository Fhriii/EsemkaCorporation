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
    public partial class Profil : Form
    {
        public int emp_id {  get; set; }
        public Profil()
        {
            InitializeComponent();
        }
        DataClassDataContext dc3 = new DataClassDataContext();


        private void button1_Click(object sender, EventArgs e)
        {
            main();
        }
        void main()
        {
            Mainn mainn = new Mainn();
            this.Hide();
            mainn.ShowDialog();
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            try
            {
            var data = (from a in dc3.employees where a.id == emp_id select a).FirstOrDefault();
               
                if (data != null)
                {
                    textBox1.Text = data.name;
                    textBox2.Text = data.email;
                    textBox3.Text = data.phone_number;
                    textBox4.Text = data.hire_date.ToString();


                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            
        }
    }
}
