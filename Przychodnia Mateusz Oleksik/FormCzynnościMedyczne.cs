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
    public partial class FormCzynnościMedyczne : Form
    {
        public FormCzynnościMedyczne()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) //dodanie nowej czynnosci medycznej
        {
            Czynności_medyczne czynnosc = new Czynności_medyczne();

            czynnosc.Nazwa_czynnosci = textBox1.Text;

            foreach(Czynności_medyczne czyn in Czynności_medyczne.ListaCzynnosciMedycznych)
                if(czyn.Nazwa_czynnosci == czynnosc.Nazwa_czynnosci)
                {
                    MessageBox.Show("Ta czynność medyczna jest już na liście");
                    return;
                }

            Czynności_medyczne.ListaCzynnosciMedycznych.Add(czynnosc);
            sortowanie();
            zaladowanieListyCzynnosci();

            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e) //usuniecie czynnosci medycznej
        {
            Czynności_medyczne czynnosc_do_usuniecia = (Czynności_medyczne)(listBox1.SelectedItem);

            if (listBox1.SelectedItems.Count == 1)
            {                
                //foreach (Pracownicy pracownik in Pracownicy.ListaPracownikow)
                //    foreach (Czynności_medyczne czynnosc in pracownik.ListaCzynnosciPracownika)
                //        if (czynnosc.Nazwa_czynnosci == czynnosc_do_usuniecia.Nazwa_czynnosci)
                //            pracownik.ListaCzynnosciPracownika.Remove(czynnosc_do_usuniecia);

                Czynności_medyczne.ListaCzynnosciMedycznych.Remove(czynnosc_do_usuniecia);
            }
            else
                MessageBox.Show("Proszę wybrać jedną czynność medyczną do usunięcia");

            sortowanie();
            zaladowanieListyCzynnosci();
        }

        private void FormCzynnościMedyczne_Load(object sender, EventArgs e) //ladowanie formatki
        {
            zaladowanieListyCzynnosci();
        }

        void zaladowanieListyCzynnosci() //umieszenie obiektow listy czynnosci medycznych w listboxie1
        {
            listBox1.Items.Clear();
            foreach (Czynności_medyczne czynnosc in Czynności_medyczne.ListaCzynnosciMedycznych)
                listBox1.Items.Add(czynnosc);
        }

        void sortowanie()
        {
            Czynności_medyczne.ListaCzynnosciMedycznych.Sort((x, y) => x.Nazwa_czynnosci.CompareTo(y.Nazwa_czynnosci));
        }
    }
}
