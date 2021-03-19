using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia_Mateusz_Oleksik
{
    public partial class FormDodawniePracownika : Form
    {
        Pracownicy pracownik;
        
        public FormDodawniePracownika(Pracownicy pracownik)
        {
            InitializeComponent();
            this.pracownik = pracownik;
        }

        private void dodaj_Click(object sender, EventArgs e) //podawanie danych dla nowego pracownika
        {
            try
            {
                pracownik.Imie = textBox1.Text;
                pracownik.Nazwisko = textBox2.Text;
                pracownik.Rok_rozpoczecia = dateTimePicker1.Value;
            }
            catch(Exception blad)
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
