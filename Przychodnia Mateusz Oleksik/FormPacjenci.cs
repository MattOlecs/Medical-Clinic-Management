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
    public partial class FormPacjenci : Form
    {
        public FormPacjenci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //dodanie nowego pacjenta
        {
            //Pacjenci pacjent = new Pacjenci();

            FormDodawaniePacjenta formatka = new FormDodawaniePacjenta();
            formatka.ShowDialog();

            zaladowanieGridView();
        }

        private void button2_Click(object sender, EventArgs e) //edytowanie danych pacjenta
        {
            if(dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Proszę wybrać jednego pacjenta do edycji");
                return;
            }

            Pacjenci pacjent = (Pacjenci)dataGridView1.SelectedRows[0].Tag;

            FormEdycjaPacjenta formatka = new FormEdycjaPacjenta(pacjent);
            formatka.ShowDialog();

            zaladowanieGridView();
        }

        void zaladowanieGridView()
        {
            dataGridView1.Rows.Clear();

            foreach(Pacjenci pacjent in Pacjenci.ListaPacjentow)
            {
                int index = dataGridView1.Rows.Add(pacjent.Obiekty_tabeli_pacjenci);
                dataGridView1.Rows[index].Tag = pacjent;
            }
        }

        private void buttonNadajUprawnieneiZdrowia_Click(object sender, EventArgs e) //nadanie uprawnien do info o zdrowiu
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                Pacjenci pacjent = (Pacjenci)dataGridView1.SelectedRows[0].Tag;
                Pracownicy pracownik = (Pracownicy)(comboBoxZdrowie.SelectedItem);

                if (comboBoxZdrowie.SelectedIndex < 0)
                    return;
                else
                    pacjent.ListaUprawnionychDoInformacji.Add(pracownik); 
            }

            zaladowanieListBoxZdrowie();

        }

        private void buttonOdbierzUprawnienieZdrowia_Click(object sender, EventArgs e) //odebranie uprawnien do info o zdrowiu
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Pracownicy pracownik = (Pracownicy)(comboBoxZdrowie.SelectedItem);
                Pacjenci pacjent = (Pacjenci)dataGridView1.SelectedRows[0].Tag;

                if (comboBoxZdrowie.SelectedIndex < 0)
                    return;
                else
                    pacjent.ListaUprawnionychDoInformacji.Remove(pracownik);
            }

            zaladowanieListBoxZdrowie();
        }

        void zaladowanieComboBoxZdrowie() //zaladowanie danych combobox info o zdrowiu
        {
            foreach (Pracownicy pracownik in Pracownicy.ListaPracownikow)
                comboBoxZdrowie.Items.Add(pracownik);
        }

        void zaladowanieComboBoxDokumentacja() //zaladowanie danych combobox dokumentacja
        {
            foreach (Pracownicy pracownik in Pracownicy.ListaPracownikow)
                comboBoxDokumentacja.Items.Add(pracownik);
        }

        void zaladowanieListBoxZdrowie() // zaladowanie danych do listbox info o zdrowiu
        {
            listBoxZdrowie.Items.Clear();

            if (dataGridView1.SelectedRows.Count == 1)
            {
                Pacjenci pacjent = (Pacjenci)dataGridView1.SelectedRows[0].Tag;
                foreach (Pracownicy pracownik in pacjent.ListaUprawnionychDoInformacji)
                    listBoxZdrowie.Items.Add(pracownik);
            }
        }

        void zaladowanieListBoxDokumentacja() // zaladowanie danych do listbox dokumentacja
        {
            listBoxDokumentacja.Items.Clear();

            if (dataGridView1.SelectedRows.Count == 1)
            {
                Pacjenci pacjent = (Pacjenci)dataGridView1.SelectedRows[0].Tag;
                foreach (Pracownicy pracownik in pacjent.ListaUprawnionychDoDokumentacji)
                    listBoxDokumentacja.Items.Add(pracownik);
            }
        }

        private void FormPacjenci_Load(object sender, EventArgs e) // zaladowanie formatki
        {
            zaladowanieComboBoxZdrowie();
            zaladowanieComboBoxDokumentacja();
            zaladowanieListBoxZdrowie();
            zaladowanieListBoxDokumentacja();
            zaladowanieGridView();
        }

        private void button3_Click(object sender, EventArgs e) // usuniecie pacjenta
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Wybierz jednego pacjenta do usunięcia");
                return;
            }

            Pacjenci pacjent = (Pacjenci)dataGridView1.SelectedRows[0].Tag;
            Pacjenci.ListaPacjentow.Remove(pacjent);
            zaladowanieGridView();

        }

        private void buttonNadajUprawnienieDokumentacji_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Pacjenci pacjent = (Pacjenci)dataGridView1.SelectedRows[0].Tag;
                Pracownicy pracownik = (Pracownicy)(comboBoxDokumentacja.SelectedItem);

                if (comboBoxZdrowie.SelectedIndex < 0)
                    return;
                else
                    pacjent.ListaUprawnionychDoDokumentacji.Add(pracownik);
            }

            zaladowanieListBoxDokumentacja();
        }

        private void buttonOdbierzUprawnienieDokumentacji_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Pacjenci pacjent = (Pacjenci)dataGridView1.SelectedRows[0].Tag;
                Pracownicy pracownik = (Pracownicy)(comboBoxDokumentacja.SelectedItem);

                if (comboBoxZdrowie.SelectedIndex < 0)
                    return;
                else
                    pacjent.ListaUprawnionychDoDokumentacji.Remove(pracownik);
            }

            zaladowanieListBoxDokumentacja();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            zaladowanieListBoxDokumentacja();
            zaladowanieListBoxZdrowie();
        }
    }
}
