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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'boooksDataSet4.Authors' . Możesz go przenieść lub usunąć.
            this.authorsTableAdapter.Fill(this.boooksDataSet4.Authors);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'boooksDataSet3.Customers' . Możesz go przenieść lub usunąć.
            this.customersTableAdapter.Fill(this.boooksDataSet3.Customers);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'boooksDataSet2.Books' . Możesz go przenieść lub usunąć.
            this.booksTableAdapter.Fill(this.boooksDataSet2.Books);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'boooksDataSet1.Employees' . Możesz go przenieść lub usunąć.
            this.employeesTableAdapter.Fill(this.boooksDataSet1.Employees);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String pesel = peselTextBox.Text;
            usunPracownika(pesel);
            this.employeesTableAdapter.Fill(this.boooksDataSet1.Employees);
        }

        private void usunPracownika(String pesel)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Boooks;Integrated Security=true"; 
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            String sql;

            sql = "delete from Employees where empPESEL = '"+pesel+"'";
            command = new SqlCommand(sql, cnn);
            dataAdapter.DeleteCommand = new SqlCommand(sql, cnn);
            dataAdapter.DeleteCommand.ExecuteNonQuery();

            MessageBox.Show("Usunięto pracownika"); 

            command.Dispose();
            cnn.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            this.Hide();
            menu.Show();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void IDKsiążki_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            String id = IDTextBox.Text;
            usunKsiazke(id);
            this.booksTableAdapter.Fill(this.boooksDataSet2.Books);
        }

        private void usunKsiazke(String id)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Boooks;Integrated Security=true";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            String sql;

            sql = "delete from Books where BookID = '" + id + "'";
            command = new SqlCommand(sql, cnn);
            dataAdapter.DeleteCommand = new SqlCommand(sql, cnn);
            dataAdapter.DeleteCommand.ExecuteNonQuery();

            MessageBox.Show("Usunięto książkę");

            command.Dispose();
            cnn.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            String id = idcTextBox.Text;
            usunKlienta(id);
            this.customersTableAdapter.Fill(this.boooksDataSet3.Customers);
        }

        private void usunKlienta(String id)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Boooks;Integrated Security=true";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            String sql;

            sql = "delete from Customers where customerID = '" + id + "'";
            command = new SqlCommand(sql, cnn);
            dataAdapter.DeleteCommand = new SqlCommand(sql, cnn);
            dataAdapter.DeleteCommand.ExecuteNonQuery();

            MessageBox.Show("Usunięto klienta");

            command.Dispose();
            cnn.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            String id = idaTextBox.Text;
            usunAutora(id);
            this.authorsTableAdapter.Fill(this.boooksDataSet4.Authors);
        }

        private void usunAutora(String id)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Boooks;Integrated Security=true";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            String sql;

            sql = "delete from Authors where authorID = '" + id + "'";
            command = new SqlCommand(sql, cnn);
            dataAdapter.DeleteCommand = new SqlCommand(sql, cnn);
            dataAdapter.DeleteCommand.ExecuteNonQuery();

            MessageBox.Show("Usunięto autora");

            command.Dispose();
            cnn.Close();
        }
    }
}
