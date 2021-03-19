using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_Mateusz_Oleksik
{
    [Serializable]
    public class GodzinyPracy
    {
        static List<GodzinyPracy> listaGodzinPracy = new List<GodzinyPracy>();

        int czas_ropoczecia, czas_zakonczenia;
        Pracownicy pracownik;
        DateTime data_dnia_pracy;
        Gabinety gabinet;

        public GodzinyPracy()
        {
            Czas_ropoczecia = int.MinValue;
            Czas_zakonczenia = int.MinValue;
            Pracownik = new Pracownicy();
            Data_dnia_pracy = DateTime.MinValue;
            Gabinet = new Gabinety();
        }

        public override string ToString()
        {
            return Pracownik.Imie + " " + Pracownik.Nazwisko + ": " + Czas_ropoczecia.ToString() + " - " + Czas_zakonczenia.ToString();
        }

        public object[] Obiekty_tabeli_godziny
        {
            get => new object[] { Pracownik.Imie, Pracownik.Nazwisko, Data_dnia_pracy.ToShortDateString(), Gabinet, Czas_ropoczecia, Czas_zakonczenia};
        }

        public object[] Obiekty_tabeli_zaplanowane_czynnosci
        {
            get => new object[] { Pracownik.Imie, Pracownik.Nazwisko, Czas_ropoczecia, Czas_zakonczenia};
        }

        public static List<GodzinyPracy> ListaGodzinPracy { get => listaGodzinPracy; set => listaGodzinPracy = value; }
        public int Czas_ropoczecia { get => czas_ropoczecia; set => czas_ropoczecia = value; }
        public int Czas_zakonczenia { get => czas_zakonczenia; set => czas_zakonczenia = value; }
        public Pracownicy Pracownik { get => pracownik; set => pracownik = value; }
        public DateTime Data_dnia_pracy { get => data_dnia_pracy; set => data_dnia_pracy = value; }
        internal Gabinety Gabinet { get => gabinet; set => gabinet = value; }
    }
}
