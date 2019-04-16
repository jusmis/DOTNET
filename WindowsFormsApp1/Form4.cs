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

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        String login = null;
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<String> logins = pobierzListePracownikow();

            if (logins.Contains(login))
            {
                this.login = textBox1.Text;
                MessageBox.Show("Yay");
            }
            else
            {
                MessageBox.Show("Nie znaleziono pracownika");
                this.login = null;
            }
            this.login = textBox1.Text;
            logins = null;
        }
        //Robisz pod tą funkcjąą nową funkcję:

        private List<String> pobierzListePracownikow()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Boooks;Integrated Security=true"; //TUTAJ WAZNE, ZMIEN NA SWOJE PARAMETRY!!!!!!!!!
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            sql = "Select empPESEL from Employees";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            List<String> logins = new List<String>(); //Przygotujmy liste pracownikow

            while (dataReader.Read())
            {
                logins.Add(dataReader.GetValue(0).ToString()); //GetValue(0), bo pobieramy tylko jedna kolumne, więc będzie automatycznie pierwsza
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return logins;
        }
    }
}
