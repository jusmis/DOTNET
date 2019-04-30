using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String login;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'boooksDataSet.Authors' . Możesz go przenieść lub usunąć.
            //this.authorsTableAdapter.Fill(this.boooksDataSet.Authors);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
     
        private void AuthorsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String imie, nazwisko, adres, telefon, pesel, konto;
            float pensja;
            try
            {
                imie = imieTextBox.Text;
                nazwisko = nazwiskoTextBox.Text;
                adres = adresTextBox.Text;
                telefon = telefonTextBox.Text;
                pesel = peselTextBox.Text;
                pensja = float.Parse(pensjaTextBox.Text); //Zamieniamy na float
                konto = kontoTextBox.Text;

                dodajPracownika(imie, nazwisko, adres, telefon, pesel, pensja, konto);
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Wprowadzono niepoprawna wartosc jako pensje");
            }
        }
            //Stworz nowa metode dodajPracownika:
        private void dodajPracownika(String imie, String nazwisko, String adres,
                                     String telefon, String pesel, float pensja, String konto)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Boooks;Integrated Security=true"; //TUTAJ WAZNE, ZMIEN NA SWOJE PARAMETRY!!!!!!!!!
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            String sql;

            //Zeby zamienic przecinek na kropke w zapisie liczby
            String pensjaS;
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            pensjaS = pensja.ToString(nfi);

            sql = "INSERT INTO EMPLOYEES (empFirstName, empLastName, empAdress, empPhoneNumber, empPESEL, empSalary, empAccount) " +
                "VALUES ('" + imie + "', '" + nazwisko + "', '" + adres + "', '" + telefon + "', '" + pesel + "', " + pensjaS + ", '" + konto + "');";
            command = new SqlCommand(sql, cnn);
            dataAdapter.InsertCommand = new SqlCommand(sql, cnn);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show("Dodano pracownika"); //Jesli nic sie nie wysypalo, to znaczy ze dodalismy pracownika

            command.Dispose();
            cnn.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            this.Hide();
            menu.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String nazwa;
            
            try
            {
                nazwa = nazwaTextBox.Text;
                dodajAutora(nazwa);
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Wprowadzono niepoprawna wartosc jako pensje");
            }
        }

        private void dodajAutora(String nazwa)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Boooks;Integrated Security=true"; //TUTAJ WAZNE, ZMIEN NA SWOJE PARAMETRY!!!!!!!!!
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            String sql;

            sql = "INSERT INTO AUTHORS (AuthorName) " +
                "VALUES ('" + nazwa + "');";
            command = new SqlCommand(sql, cnn);
            dataAdapter.InsertCommand = new SqlCommand(sql, cnn);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show("Dodano autora"); //Jesli nic sie nie wysypalo, to znaczy ze dodalismy pracownika

            command.Dispose();
            cnn.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            String imie, nazwisko, adres, telefon;
            try
            {
                imie = imiecTextBox.Text;
                nazwisko = nazwiskocTextBox.Text;
                adres = adrescTextBox.Text;
                telefon = telefoncTextBox.Text;
               
                dodajKlienta(imie, nazwisko, adres, telefon);
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Wprowadzono niepoprawna wartosc jako pensje");
            }
        }
        private void dodajKlienta(String imie, String nazwisko, String adres,
                                     String telefon)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Boooks;Integrated Security=true"; //TUTAJ WAZNE, ZMIEN NA SWOJE PARAMETRY!!!!!!!!!
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            String sql;

            sql = "INSERT INTO CUSTOMERS (cusFirstName, cusLastName, cusAdress, cusPhoneNumber) " +
                "VALUES ('" + imie + "', '" + nazwisko + "', '" + adres + "', '" + telefon + "');";
            command = new SqlCommand(sql, cnn);
            dataAdapter.InsertCommand = new SqlCommand(sql, cnn);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show("Dodano klienta"); //Jesli nic sie nie wysypalo, to znaczy ze dodalismy pracownika

            command.Dispose();
            cnn.Close();
        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }
    }
    
}
