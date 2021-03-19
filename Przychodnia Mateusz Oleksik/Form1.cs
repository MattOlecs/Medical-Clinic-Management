using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Przychodnia_Mateusz_Oleksik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //odpalenie formatki z pracownikami
        {
            FormPracownicy formatka = new FormPracownicy();
            formatka.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //odpalenie formatki z czynnosciami medycznymi
        {
            FormCzynnościMedyczne formatka = new FormCzynnościMedyczne();
            formatka.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) //odpalenie formatki z pacjentami
        {
            FormPacjenci formatka = new FormPacjenci();
            formatka.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) //odpalenie formatki z godzinami pracy pracowników
        {
            FormGodzinyPracy formatka = new FormGodzinyPracy();
            formatka.ShowDialog();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e) //przycisk menu do zapisu
        {
            zapis_danych();
        }

        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e) //przycisk menu do wczytania
        {
            wczytanie_danych();
        }

        void zapis_danych() // funkcja zapisu danych
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Plik aplikacji Przychodnia(*.med)|*.med";

            if (sfd.ShowDialog() != DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;
                return;
            }

            FileStream file = new FileStream(sfd.FileName, FileMode.Create, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, Pracownicy.ListaPracownikow);
            bf.Serialize(file, Pacjenci.ListaPacjentow);
            bf.Serialize(file, GodzinyPracy.ListaGodzinPracy);
            bf.Serialize(file, Czynności_medyczne.ListaCzynnosciMedycznych);
            bf.Serialize(file, Gabinety.Lista_gabinetow);
            bf.Serialize(file, ZaplanowaneCzynnosciMedyczne.ListaZaplanowanychCzynnosci);
            file.Close();
        }

        void wczytanie_danych() // funkcja wczytania danych
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = string.Empty;

            try
            {
                Dane_przychodni.Deserializacja();
                //ofd.Filter = "Plik aplikacji Przychodnia(*.med)|*.med";
                //if (ofd.ShowDialog() != DialogResult.OK)
                //{
                //    DialogResult = DialogResult.Cancel;
                //    return;
                //}

                //FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                //BinaryFormatter bf = new BinaryFormatter();
                //Pracownicy.ListaPracownikow = (List<Pracownicy>)bf.Deserialize(fs);
                //Pacjenci.ListaPacjentow = (List<Pacjenci>)bf.Deserialize(fs);
                //GodzinyPracy.ListaGodzinPracy = (List<GodzinyPracy>)bf.Deserialize(fs);
                //Czynności_medyczne.ListaCzynnosciMedycznych = (List<Czynności_medyczne>)bf.Deserialize(fs);
                //Gabinety.Lista_gabinetow = (List<Gabinety>)bf.Deserialize(fs);
                //ZaplanowaneCzynnosciMedyczne.ListaZaplanowanychCzynnosci = (List<ZaplanowaneCzynnosciMedyczne>)bf.Deserialize(fs);
                //fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało sie wczytać pliku: " + ofd.FileName + "\n" + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e) //odpalenie formatki z gabinetami
        {
            FormGabinety formatka = new FormGabinety();
            formatka.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormPlanowanieWizyt formatka = new FormPlanowanieWizyt();
            formatka.ShowDialog();
        }
    }
}
