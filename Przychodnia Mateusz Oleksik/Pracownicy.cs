using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_Mateusz_Oleksik
{
    [Serializable]
    public class Pracownicy : Osoba //Klasa pracownicy, dziedzicząca po klasie osoba
    {
        static List<Pracownicy> listaPracownikow = new List<Pracownicy>(); //lista wszystkich pracowników
        List<Czynności_medyczne> listaCzynnosciPracownika = new List<Czynności_medyczne>();

        DateTime rok_rozpoczecia;

        public Pracownicy() //Konstruktor pracownika
        {
            rok_rozpoczecia = DateTime.Today;   
        }

        public override string ToString()
        {
            return Imie + " " + Nazwisko;
        }


        public static List<Pracownicy> ListaPracownikow { get => listaPracownikow; set => listaPracownikow = value; }
        public DateTime Rok_rozpoczecia { get => rok_rozpoczecia; set => rok_rozpoczecia = value; }

        public object[] Obiekty_tabeli_pracowniy
        {
            get => new object[] {Imie, Nazwisko, Rok_rozpoczecia.ToShortDateString(), listaCzynnosciPracownika.ToString()};
        }

        public List<Czynności_medyczne> ListaCzynnosciPracownika { get => listaCzynnosciPracownika; set => listaCzynnosciPracownika = value; }
    }
}
