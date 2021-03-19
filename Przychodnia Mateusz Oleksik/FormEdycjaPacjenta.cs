using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia_Mateusz_Oleksik
{
    public partial class FormEdycjaPacjenta : Form
    {
        Pacjenci pacjent;
        public FormEdycjaPacjenta(Pacjenci pacjent)
        {
            InitializeComponent();
            this.pacjent = pacjent;
        }

        private void button1_Click(object sender, EventArgs e) // potwierdzenie edycji danych
        {
            try
            {
                pacjent.Imie = textImie.Text;
                pacjent.Nazwisko = textNazwisko.Text;
                pacjent.Pesel = maskedTextBox1.Text;
                pacjent.Rok_urodzenia = dateTimePicker1.Value;
                pacjent.Adres = textAdres.Text;
                pacjent.Telefon = maskedTextBox2.Text;
                pacjent.Adres_email = textEmail.Text;
            }
            catch (Exception wyjatek)
            {
                MessageBox.Show("Wprowadzono niewłaściwe dane: \n" + wyjatek.Message);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e) //anulowanie edycji danych
        {
            DialogResult = DialogResult.Cancel;
        }
        private void FormEdycjaPacjenta_Load(object sender, EventArgs e) // zaladowanie danych pracownika do formatki
        {
                textImie.Text = pacjent.Imie;
                textNazwisko.Text = pacjent.Nazwisko;
                maskedTextBox1.Text = pacjent.Pesel;
                dateTimePicker1.Value = pacjent.Rok_urodzenia;
                textAdres.Text = pacjent.Adres;
                maskedTextBox2.Text = pacjent.Telefon;
                textEmail.Text = pacjent.Adres_email;

        }
    }
}
