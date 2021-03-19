using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_Mateusz_Oleksik
{
    [Serializable]
    public class Pacjenci : Osoba
    {
        static List<Pacjenci> listaPacjentow = new List<Pacjenci>();
        List<Pracownicy> listaUprawnionychDoInformacji = new List<Pracownicy>();
        List<Pracownicy> listaUprawnionychDoDokumentacji = new List<Pracownicy>();

        DateTime rok_urodzenia;
        string adres, adres_email, telefon, pesel;
        public Pacjenci()
        {
            Imie = string.Empty;
            Nazwisko = string.Empty;
            Rok_urodzenia = DateTime.Today;
            Adres = string.Empty;
            Adres_email = string.Empty;
            Pesel = string.Empty;
            Telefon = string.Empty;
        }

        public object[] Obiekty_tabeli_pacjenci
        {
            get => new object[] { Imie, Nazwisko, Pesel, Rok_urodzenia.ToShortDateString(), Adres, Telefon, Adres_email};
        }

        public override string ToString()
        {
            return Imie + " " + Nazwisko;
        }

        public static List<Pacjenci> ListaPacjentow { get => listaPacjentow; set => listaPacjentow = value; }
        public DateTime Rok_urodzenia { get => rok_urodzenia; set => rok_urodzenia = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Adres_email { get => adres_email; set => adres_email = value; }
        public List<Pracownicy> ListaUprawnionychDoInformacji { get => listaUprawnionychDoInformacji; set => listaUprawnionychDoInformacji = value; }
        public List<Pracownicy> ListaUprawnionychDoDokumentacji { get => listaUprawnionychDoDokumentacji; set => listaUprawnionychDoDokumentacji = value; }
        public string Pesel 
        { 
            get => pesel; set 
            {
                //if (value.Length != 11)
                //    throw new ArgumentOutOfRangeException("Pesel powinien składać się z 11 cyfr");
                
                pesel = value;
            } 
        }
        public string Telefon { get => telefon; set => telefon = value; }
    }
}
