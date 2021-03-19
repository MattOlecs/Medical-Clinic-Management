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
    public partial class FormEdycjaPracownika : Form
    {
        Pracownicy pracownik;
        public FormEdycjaPracownika(Pracownicy pracownik)
        {
            InitializeComponent();
            this.pracownik = pracownik;
        }
        private void FormEdycjaPracownika_Load(object sender, EventArgs e) //załadowanie danych do kontroler
        {
            textBox1.Text = pracownik.Imie;
            textBox2.Text = pracownik.Nazwisko;
            dateTimePicker1.Value = pracownik.Rok_rozpoczecia;
        }
        private void dodaj_Click(object sender, EventArgs e) //podanie zmienionych danych
        {
            try
            {
                pracownik.Imie = textBox1.Text;
                pracownik.Nazwisko = textBox2.Text;
                pracownik.Rok_rozpoczecia = dateTimePicker1.Value;
            }
            catch (Exception blad)
            {
                MessageBox.Show("Wprowadzone dane są niewłaściwe \n" + blad.Message);
            }

            DialogResult = DialogResult.OK;
        }

        private void anuluj_Click(object sender, EventArgs e) //anulowanie
        {
            DialogResult = DialogResult.Cancel;
        }


    }
}
