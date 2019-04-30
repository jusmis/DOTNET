using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'boooksDataSet6.toOrder' . Możesz go przenieść lub usunąć.
            this.toOrderTableAdapter.Fill(this.boooksDataSet6.toOrder);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'boooksDataSet5.Authors' . Możesz go przenieść lub usunąć.
            this.authorsTableAdapter.Fill(this.boooksDataSet5.Authors);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Boooks;Integrated Security=true";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            String sql;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                var cell = item.Cells[0].Value;
                if (cell != null)
                {
                    if (bool.Parse(cell.ToString()))
                    {
                        String id = item.Cells[1].Value.ToString();
                        //MessageBox.Show("Selected rows: " + item.Cells[1].Value.ToString());
                        sql = "delete from toOrder where BookID = '" + id + "'";
                        command = new SqlCommand(sql, cnn);
                        dataAdapter.DeleteCommand = new SqlCommand(sql, cnn);
                        dataAdapter.DeleteCommand.ExecuteNonQuery();

                        command.Dispose();
                        cnn.Close();
                    }
                }
            }
            //
          

            MessageBox.Show("Usunięto wybrane");
        }
    }
}
