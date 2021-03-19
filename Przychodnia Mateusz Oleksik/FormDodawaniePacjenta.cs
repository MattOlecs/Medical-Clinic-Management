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
    
    public partial class FormDodawaniePacjenta : Form
    {
        public FormDodawaniePacjenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //uzupelnienie danych nowego pacjenta i dodanie go do listy pacjentow
        {
            try
            {
                Pacjenci pacjent = new Pacjenci();
                pacjent.Imie = textImie.Text;
                pacjent.Nazwisko = textNazwisko.Text;
                pacjent.Pesel = maskedTextBox1.Text;
                pacjent.Rok_urodzenia = dateTimePicker1.Value;
                pacjent.Adres = textAdres.Text;
                pacjent.Telefon = maskedTextBox2.Text;
                pacjent.Adres_email = textEmail.Text;
                Pacjenci.ListaPacjentow.Add(pacjent);
            }
            catch(Exception wyjatek)
            {
                MessageBox.Show("Wprowadzono niewłaściwe dane: \n" + wyjatek.Message);
                return;
            }
            

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e) //anulowanie dodania nowego pacjenta
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
