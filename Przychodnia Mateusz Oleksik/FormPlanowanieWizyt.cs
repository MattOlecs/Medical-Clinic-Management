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
    public partial class FormPlanowanieWizyt : Form
    {
        public FormPlanowanieWizyt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBoxPacjent.SelectedIndex < 0) //zabezp. przed nie wybraniem pacjenta
            {
                MessageBox.Show("Wybierz pacjenta!");
                return;
            }
            
            if (dataGridView1.SelectedRows.Count != 1) //zabezp. przed nie wybraniem pracownika
            {
                MessageBox.Show("Wybierz jednego pracownika");
                return;
            }

            if(comboBoxCzynnosc.SelectedIndex < 0)
            {
                MessageBox.Show("Wybierz czynność medyczną!");
                return;
            }

            Czynności_medyczne czynnosc = (Czynności_medyczne)(comboBoxCzynnosc.SelectedItem);
            GodzinyPracy godzina = (GodzinyPracy)(dataGridView1.SelectedRows[0].Tag); 
            Pracownicy pracownik = godzina.Pracownik;
            Pacjenci pacjent = (Pacjenci)(comboBoxPacjent.SelectedItem);
            ZaplanowaneCzynnosciMedyczne zaplanowana_czynnosc = new ZaplanowaneCzynnosciMedyczne();
            
            //kazda wizyta trwa 10 minut;

            zaplanowana_czynnosc.Godz_rozpoczecia = (int)(numericUpDown1.Value);
            zaplanowana_czynnosc.Min_rozpoczecia = (int)(numericUpDown2.Value);
            if (zaplanowana_czynnosc.Min_rozpoczecia == 50)
            {
                zaplanowana_czynnosc.Godz_zakonczenia = zaplanowana_czynnosc.Godz_rozpoczecia + 1;
                zaplanowana_czynnosc.Min_zakonczenia = 0;
            }
            else
            {
                zaplanowana_czynnosc.Godz_zakonczenia = zaplanowana_czynnosc.Godz_rozpoczecia;
                zaplanowana_czynnosc.Min_zakonczenia = zaplanowana_czynnosc.Min_rozpoczecia + 10;
            }       
            zaplanowana_czynnosc.Pacjent = pacjent;
            zaplanowana_czynnosc.Pracownik = pracownik;
            zaplanowana_czynnosc.Nazwa_czynnosci = czynnosc.Nazwa_czynnosci;
            zaplanowana_czynnosc.Data_czynnosci = godzina.Data_dnia_pracy;

            if(zaplanowana_czynnosc.Godz_rozpoczecia < godzina.Czas_ropoczecia || zaplanowana_czynnosc.Godz_zakonczenia > godzina.Czas_zakonczenia || zaplanowana_czynnosc.Godz_rozpoczecia == godzina.Czas_zakonczenia)
            {
                MessageBox.Show("Wybierz godzinę i czas trwania wizyty w ramach czasowych pracy wybranego pracownika");
                return;
            }

            int licznik_bledu = 0;

            foreach (ZaplanowaneCzynnosciMedyczne zaplanowane in ZaplanowaneCzynnosciMedyczne.ListaZaplanowanychCzynnosci)
            {

                if (zaplanowana_czynnosc.Data_czynnosci.Year == zaplanowane.Data_czynnosci.Year && zaplanowana_czynnosc.Data_czynnosci.Month == zaplanowane.Data_czynnosci.Month && zaplanowana_czynnosc.Data_czynnosci.Day == zaplanowane.Data_czynnosci.Day && zaplanowana_czynnosc.Pracownik.Imie == zaplanowane.Pracownik.Imie && zaplanowana_czynnosc.Pracownik.Nazwisko == zaplanowane.Pracownik.Nazwisko && zaplanowana_czynnosc.Godz_rozpoczecia == zaplanowane.Godz_rozpoczecia && zaplanowana_czynnosc.Min_rozpoczecia == zaplanowane.Min_rozpoczecia)
                {
                    licznik_bledu = 1;
                    break;
                }
            }

            if(licznik_bledu == 1)
            {
                MessageBox.Show("Podane godziny kolidują z inną już zaplanowaną czynnością medyczną na ten dzień");
                return;
            }


            ZaplanowaneCzynnosciMedyczne.ListaZaplanowanychCzynnosci.Add(zaplanowana_czynnosc);
            sortowanie();
            zaladowanieListbox();
        }

        private void FormPlanowanieWizyt_Load(object sender, EventArgs e) //zaladowanie formatki
        {
            zaladowanieComboboxCzynnosc();
            zaladowanieComboboxPacjent();
        }

        private void comboBoxCzynnosc_SelectedIndexChanged(object sender, EventArgs e) //wybranie czynnosci medycznej
        {
            zaladowanieGridView();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) //wybranie daty
        {
            zaladowanieGridView();
        }

        void zaladowanieComboboxCzynnosc() //zaladowanie czynnosci medycznych do combobox
        {
            foreach (Czynności_medyczne czynnosc in Czynności_medyczne.ListaCzynnosciMedycznych)
                comboBoxCzynnosc.Items.Add(czynnosc);
        }

        void zaladowanieComboboxPacjent() //zaladowanie pacjentow do combobox 
        {
            foreach (Pacjenci pacjent in Pacjenci.ListaPacjentow)
                comboBoxPacjent.Items.Add(pacjent);
        }

        void zaladowanieGridView() //zaladowanie godzin pracy ze zgodną data i czynnoscia medyczna do grid view
        {
            if (comboBoxCzynnosc.SelectedIndex < 0)
                return;

            dataGridView1.Rows.Clear();

            Czynności_medyczne czynnosc = (Czynności_medyczne)(comboBoxCzynnosc.SelectedItem);
            DateTime data = dateTimePicker1.Value;

            //foreach (GodzinyPracy godzina in GodzinyPracy.ListaGodzinPracy)
            //    if (godzina.Pracownik.ListaCzynnosciPracownika.Contains(czynnosc) && godzina.Data_dnia_pracy.Year == data.Year && godzina.Data_dnia_pracy.Month == data.Month && godzina.Data_dnia_pracy.Day == data.Day)
            //    {
            //        int index = dataGridView1.Rows.Add(godzina.Obiekty_tabeli_zaplanowane_czynnosci);
            //        dataGridView1.Rows[index].Tag = godzina;
            //        label6.Text = "sra";
            //    }

            foreach (GodzinyPracy godzina in GodzinyPracy.ListaGodzinPracy)
                if (godzina.Data_dnia_pracy.Year == data.Year && godzina.Data_dnia_pracy.Month == data.Month && godzina.Data_dnia_pracy.Day == data.Day)
                {
                    foreach(Czynności_medyczne czynnosc_medyczna in godzina.Pracownik.ListaCzynnosciPracownika)
                        if(czynnosc_medyczna.Nazwa_czynnosci == czynnosc.Nazwa_czynnosci)
                        {
                            int index = dataGridView1.Rows.Add(godzina.Obiekty_tabeli_zaplanowane_czynnosci);
                            dataGridView1.Rows[index].Tag = godzina;
                        }
                }

        }

        void zaladowanieListbox() //zaladowanie listy pokazujacej juz zarezerwowane terminy
        {

            if (comboBoxCzynnosc.SelectedIndex < 0)
                return;

            if (dataGridView1.SelectedRows.Count != 1)
                return;

            GodzinyPracy godzina = (GodzinyPracy)(dataGridView1.SelectedRows[0].Tag);
            
            
            DateTime data = dateTimePicker1.Value;

            listBox1.Items.Clear();

            foreach (ZaplanowaneCzynnosciMedyczne zaplanowane in ZaplanowaneCzynnosciMedyczne.ListaZaplanowanychCzynnosci)
                if(zaplanowane.Data_czynnosci.Year == data.Year && zaplanowane.Data_czynnosci.Month == data.Month && zaplanowane.Data_czynnosci.Day == data.Day && zaplanowane.Pracownik.Imie == godzina.Pracownik.Imie && zaplanowane.Pracownik.Nazwisko == godzina.Pracownik.Nazwisko)
                    listBox1.Items.Add(zaplanowane);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            zaladowanieListbox();
        }

        private void button2_Click(object sender, EventArgs e) //usuniecie wizyty
        {
            ZaplanowaneCzynnosciMedyczne zaplanowana_do_usuniecia = (ZaplanowaneCzynnosciMedyczne)(listBox1.SelectedItem);

            if (listBox1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Wybierz jedną wizytę do usunięcia!");
                return;
            }
            else
                ZaplanowaneCzynnosciMedyczne.ListaZaplanowanychCzynnosci.Remove(zaplanowana_do_usuniecia);

            sortowanie();
            zaladowanieListbox();
        }

        void sortowanie()
        {
            ZaplanowaneCzynnosciMedyczne.ListaZaplanowanychCzynnosci.Sort((x, y) => x.Godz_rozpoczecia.CompareTo(y.Godz_rozpoczecia));
        }

    }
}
