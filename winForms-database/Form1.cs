using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForms_database
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data source='localhost\\SQLEXPRESS';Integrated Security=True;Pooling=false;Initial Catalog='lotto'";
        private SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            LoadWyniki();
        }

        private void LoadWyniki()
        {
            string sql = "SELECT * FROM duzy;";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            dataGridView1.Rows.Clear();
            while(reader.Read())
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
            }
            reader.Close();
            connection.Close();
        }
        //model polaczeniowy
        private void button1_Click(object sender, EventArgs e)
        {
            AddDraw ad = new AddDraw();
            if(ad.ShowDialog()==DialogResult.OK)
            {
                connection.Open();
                string sql = "insert into duzy values (@data,@liczba1,@liczba2,@liczba3,@liczba4,@liczba5,@liczba6);";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@data", ad.data);
                command.Parameters.AddWithValue("@liczba1", ad.liczby[0]);
                command.Parameters.AddWithValue("@liczba2", ad.liczby[1]);
                command.Parameters.AddWithValue("@liczba3", ad.liczby[2]);
                command.Parameters.AddWithValue("@liczba4", ad.liczby[3]);
                command.Parameters.AddWithValue("@liczba5", ad.liczby[4]);
                command.Parameters.AddWithValue("@liczba6", ad.liczby[5]);
                command.ExecuteNonQuery();
                connection.Close();
                LoadWyniki();

                MessageBox.Show("Added a result of draw !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                

            }
        }
        //bezpolaczeniowy model
        private void button2_Click(object sender, EventArgs e)
        {
            AddDraw ad = new AddDraw();
            if (ad.ShowDialog() == DialogResult.OK)
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("insert into duzy values (@data,@liczba1,@liczba2,@liczba3,@liczba4,@liczba5,@liczba6);", connection);
                //To do continue...
            }
        }
    }
}
