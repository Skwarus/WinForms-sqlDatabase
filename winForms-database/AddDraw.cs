using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForms_database
{
    public partial class AddDraw : Form
    {
        public DateTime data;
        public int []liczby=new int[6];
        public AddDraw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                data = Convert.ToDateTime(dateTimePicker1.Text);
                liczby[0] = Convert.ToInt32(textBox1.Text);
                liczby[1] = Convert.ToInt32(textBox2.Text);
                liczby[2] = Convert.ToInt32(textBox3.Text);
                liczby[3] = Convert.ToInt32(textBox4.Text);
                liczby[4] = Convert.ToInt32(textBox5.Text);
                liczby[5] = Convert.ToInt32(textBox6.Text);
                DialogResult = DialogResult.OK;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
