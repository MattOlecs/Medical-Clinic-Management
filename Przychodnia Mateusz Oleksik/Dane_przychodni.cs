using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia_Mateusz_Oleksik
{
    public static class Dane_przychodni
    {
        public static void Deserializacja()
        {
                FileStream fs = new FileStream(@"C:\Users\Mateusz\Desktop\Dane_przychodnia.med", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Pracownicy.ListaPracownikow = (List<Pracownicy>)bf.Deserialize(fs);
                Pacjenci.ListaPacjentow = (List<Pacjenci>)bf.Deserialize(fs);
                GodzinyPracy.ListaGodzinPracy = (List<GodzinyPracy>)bf.Deserialize(fs);
                Czynności_medyczne.ListaCzynnosciMedycznych = (List<Czynności_medyczne>)bf.Deserialize(fs);
                Gabinety.Lista_gabinetow = (List<Gabinety>)bf.Deserialize(fs);
                ZaplanowaneCzynnosciMedyczne.ListaZaplanowanychCzynnosci = (List<ZaplanowaneCzynnosciMedyczne>)bf.Deserialize(fs);
                fs.Close(); 
        }
    }
}
