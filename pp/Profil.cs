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
            var data2 = (from b in dc3.positions where b.job_id == emp_id select b).FirstOrDefault();
            var data3 = (from c in dc3.jobs where c.id== data2.job_id select c).FirstOrDefault();
            var data4 = (from d in dc3.departments where d.id== data3.department_id select d).FirstOrDefault();
               
                if (data != null || data2 != null)
                {
                    textBox1.Text = data.name;
                    textBox2.Text = data.email;
                    textBox3.Text = data.phone_number;
                    textBox4.Text = data.hire_date.ToString();
                    textBox5.Text = data2.job_id.ToString();
                    textBox6.Text = data3.name;
                    textBox7.Text = data4.name;
                }


            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            
        }
    }
}
