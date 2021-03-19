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
    public partial class FormPracownicy : Form
    {
        
        public FormPracownicy()
        {
            InitializeComponent();
        }

        private void Pracownik_Load(object sender, EventArgs e) //zaladowanie się formatki
        {
            odswiez_liste();
            zaladowanieComboBox();
        }

        void odswiez_liste() //wyświetlenie obiektów pracownicy z listy pracowników w datagridview
        {
            dataGridView1.Rows.Clear();
            
            foreach(Pracownicy p in Pracownicy.ListaPracownikow)
            {
                int index = dataGridView1.Rows.Add(p.Obiekty_tabeli_pracowniy);
                dataGridView1.Rows[index].Tag = p;
            }
        }

        private void dodaj_pracownika_Click(object sender, EventArgs e) //okno do dodawania pracownika
        {
            Pracownicy pracownik = new Pracownicy();
            FormDodawniePracownika formatka = new FormDodawniePracownika(pracownik);

            if (formatka.ShowDialog() == DialogResult.OK)
                Pracownicy.ListaPracownikow.Add(pracownik);
            else
                return;

            odswiez_liste();
        }

        private void edytuj_pracownika_Click(object sender, EventArgs e) //okno do edycji pracownika
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Brak pracowników do edycji");
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Proszę wybrać jednego pracownika");
                return;
            }
            else
            {
                Pracownicy pracownik = (Pracownicy)(dataGridView1.SelectedRows[0].Tag);
                FormEdycjaPracownika formatka = new FormEdycjaPracownika(pracownik);

                if (formatka.ShowDialog() != DialogResult.OK)
                    return;
                else
                    odswiez_liste();
            }
        }

        private void usuń_pracownika_Click(object sender, EventArgs e) //usuwanie pracownika
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Brak pracowników do edycji");
                return;
            }

            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Proszę wybrać jednego pracownika");
                return;
            }
            else
            {
                Pracownicy pracownik = (Pracownicy)(dataGridView1.SelectedRows[0].Tag);
                Pracownicy.ListaPracownikow.Remove(pracownik);
                odswiez_liste();
            }
        }

        private void buttonNadajUprawnienia_Click(object sender, EventArgs e) //dodaje uprawnienia do wykonywania czynnosci
        {
            if (dataGridView1.SelectedRows.Count != 1 || comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Wybierz jednego pracownika i czynność medyczną");
                return;
            }
            
            Pracownicy pracownik = (Pracownicy)(dataGridView1.SelectedRows[0].Tag);
            Czynności_medyczne czynnosc = (Czynności_medyczne)(comboBox1.SelectedItem);

            foreach(Czynności_medyczne czyn in pracownik.ListaCzynnosciPracownika)
                if(czyn.Nazwa_czynnosci == czynnosc.Nazwa_czynnosci)
                {
                    MessageBox.Show("Pracownik już posiada te uprawnienia!");
                    return;
                }
            
            pracownik.ListaCzynnosciPracownika.Add(czynnosc);
            zaladowanieListBox();
        }

        private void buttonOdbierzUprawnienia_Click(object sender, EventArgs e) //odebranie uprawnień do wykonywania czynnośći
        {
            if (dataGridView1.SelectedRows.Count != 1 || comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Wybierz jednego pracownika i czynność medyczną");
                return;
            }

            Pracownicy pracownik = (Pracownicy)(dataGridView1.SelectedRows[0].Tag);
            Czynności_medyczne czynnosc = (Czynności_medyczne)(comboBox1.SelectedItem);

            pracownik.ListaCzynnosciPracownika.Remove(czynnosc);
            zaladowanieListBox();
        }

        void zaladowanieComboBox() //laduje dane (czynnosci) w combbox
        {
            foreach (Czynności_medyczne czynnosc in Czynności_medyczne.ListaCzynnosciMedycznych)
                comboBox1.Items.Add(czynnosc);
        }

        void zaladowanieListBox() //laduje uprawnienia wybranego pracownika do listBox
        {
            listBox1.Items.Clear();

            if (dataGridView1.SelectedRows.Count == 1)
            {
                Pracownicy pracownik = (Pracownicy)(dataGridView1.SelectedRows[0].Tag);
                foreach (Czynności_medyczne czynnosc in pracownik.ListaCzynnosciPracownika)
                    listBox1.Items.Add(czynnosc);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            zaladowanieListBox();
        }

    }
}
