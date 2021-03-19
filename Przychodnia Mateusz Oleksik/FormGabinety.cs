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
    public partial class FormGabinety : Form
    {
        public FormGabinety()
        {
            InitializeComponent();
        }

        private void buttonDodajGabinet_Click(object sender, EventArgs e)
        {
            Gabinety gabinet = new Gabinety();
            gabinet.Numer_gabinetu = (int)numericUpDown1.Value;

            foreach(Gabinety gab in Gabinety.Lista_gabinetow)
                if(gab.Numer_gabinetu == gabinet.Numer_gabinetu)
                {
                    MessageBox.Show("Na liście jest już gabinet z takim numerem!");
                    return;
                }

            Gabinety.Lista_gabinetow.Add(gabinet);
            sortowanie();
            zaladowanieListBox();
        }

        private void buttonUsunGabinet_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Wybierz jeden gabinet do usunięcia z listy");
                return;
            }
            else
                Gabinety.Lista_gabinetow.Remove((Gabinety)(listBox1.SelectedItem));
            sortowanie();
            zaladowanieListBox();
        }

        private void FormGabinety_Load(object sender, EventArgs e)
        {
            zaladowanieListBox();
        }

        void zaladowanieListBox()
        {
            listBox1.Items.Clear();

            foreach (Gabinety gabinet in Gabinety.Lista_gabinetow)
                listBox1.Items.Add(gabinet);
        }

        void sortowanie()
        {
            Gabinety.Lista_gabinetow.Sort((x, y) => x.Numer_gabinetu.CompareTo(y.Numer_gabinetu));
        }
    }
}
