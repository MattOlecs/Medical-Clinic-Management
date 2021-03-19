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
    public partial class FormGodzinyPracy : Form
    {
        public FormGodzinyPracy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // dodanie obiektu dzien_pracy do listy godzinpracy
        {
            GodzinyPracy dzien_pracy = new GodzinyPracy();
            Pracownicy pracownik = (Pracownicy)comboBox1.SelectedItem;

            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Wybierz pracownika");
                return;
            }

            if (comboBox2.SelectedIndex < 0)
            {
                MessageBox.Show("Wybierz gabinet");
                return;
            }

            if (numericUpDown1.Value > numericUpDown2.Value || numericUpDown1.Value == numericUpDown2.Value) // zabezpieczenie przed dodaniem godziny rozpoczecia pracy wiekszej niz zakonczenia lub takiej samiej
            {
                MessageBox.Show("Godzina rozpoczęcia pracy nie może być większa od godziny zakończenia pracy lub taka sama");
                return;
            }

            else
            {
                dzien_pracy.Pracownik = pracownik;
                dzien_pracy.Data_dnia_pracy = dateTimePicker1.Value;
                dzien_pracy.Czas_ropoczecia = (int)(numericUpDown1.Value);
                dzien_pracy.Czas_zakonczenia = (int)(numericUpDown2.Value);
                dzien_pracy.Gabinet = (Gabinety)(comboBox2.SelectedItem);
            }

            int licznik_bledu = 0; //zabezpieczenie przed dodaniem do listy mimo spelnienia warunkow bledu, wymyslec bardziej elegancki sposob

            foreach (GodzinyPracy godziny in GodzinyPracy.ListaGodzinPracy)
            {
                if (pracownik.Imie == godziny.Pracownik.Imie && pracownik.Nazwisko == godziny.Pracownik.Nazwisko && dzien_pracy.Data_dnia_pracy.Year == godziny.Data_dnia_pracy.Year && dzien_pracy.Data_dnia_pracy.Month == godziny.Data_dnia_pracy.Month && dzien_pracy.Data_dnia_pracy.Day == godziny.Data_dnia_pracy.Day)
                {
                    MessageBox.Show("Pracownik ma już zaplanowane godziny pracy tego dnia");
                    licznik_bledu = 1;
                    break;
                }
            }

            foreach (GodzinyPracy godziny in GodzinyPracy.ListaGodzinPracy)
            {
                if (dzien_pracy.Data_dnia_pracy.Year == godziny.Data_dnia_pracy.Year && dzien_pracy.Data_dnia_pracy.Month == godziny.Data_dnia_pracy.Month && dzien_pracy.Data_dnia_pracy.Day == godziny.Data_dnia_pracy.Day && dzien_pracy.Gabinet.Numer_gabinetu == godziny.Gabinet.Numer_gabinetu)
                {
                    MessageBox.Show("Gabinet jest już zarezerwowany na ten dzień");
                    licznik_bledu = 1;
                    break;
                }
            }

            if (licznik_bledu == 0)
                GodzinyPracy.ListaGodzinPracy.Add(dzien_pracy);
            sortowanie();
            zaladowanieGridView();
        }

        void zaladowanieComboBox() //zaladowanie pracowników do combobox1
        {
            foreach (Pracownicy pracownik in Pracownicy.ListaPracownikow)
                comboBox1.Items.Add(pracownik);

            foreach (Gabinety gabinet in Gabinety.Lista_gabinetow)
                comboBox2.Items.Add(gabinet);
        }

        void zaladowanieGridView() //wyswietlenie dataGridView
        {
            dataGridView1.Rows.Clear();

            foreach (GodzinyPracy godziny in GodzinyPracy.ListaGodzinPracy)
            {
                int index = dataGridView1.Rows.Add(godziny.Obiekty_tabeli_godziny);
                dataGridView1.Rows[index].Tag = godziny;
            }
        }

        private void FormGodzinyPracy_Load(object sender, EventArgs e) //odpalenie sie formatki
        {
            zaladowanieComboBox();
            zaladowanieGridView();
        }

        private void button2_Click(object sender, EventArgs e) // usuwanie godzin pracy
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Wybierz jeden dzień pracy do usunięcia!");
                return;
            }

            GodzinyPracy godzina = (GodzinyPracy)(dataGridView1.SelectedRows[0].Tag);
            GodzinyPracy.ListaGodzinPracy.Remove(godzina);
            sortowanie();
            zaladowanieGridView();
        }

        void sortowanie()
        {
            GodzinyPracy.ListaGodzinPracy.Sort((x, y) => x.Data_dnia_pracy.CompareTo(y.Data_dnia_pracy));
        }
    }
}
