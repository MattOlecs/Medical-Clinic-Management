using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_Mateusz_Oleksik
{
    [Serializable]
    public class ZaplanowaneCzynnosciMedyczne : Czynności_medyczne
    {
        static List<ZaplanowaneCzynnosciMedyczne> listaZaplanowanychCzynnosci = new List<ZaplanowaneCzynnosciMedyczne>();
        Pracownicy pracownik;
        Pacjenci pacjent;
        DateTime data_czynnosci;
        int godz_rozpoczecia, min_rozpoczecia, czas_trwania, godz_zakonczenia, min_zakonczenia;

        public ZaplanowaneCzynnosciMedyczne() 
        {
            Nazwa_czynnosci = string.Empty;
            Pracownik = new Pracownicy();
            Pacjent = new Pacjenci();
            Data_czynnosci = DateTime.MinValue;
            Godz_rozpoczecia = int.MinValue;
            Min_rozpoczecia = int.MinValue;
            Godz_zakonczenia = int.MinValue;
            Min_zakonczenia = int.MinValue;
            Czas_trwania = int.MinValue;
        }

        public override string ToString()
        {
            //if ( Math.Floor(Math.Log10(Godz_rozpoczecia) + 1) == 1 && Math.Floor(Math.Log10(Godz_zakonczenia) + 1) == 1 && Math.Floor(Math.Log10(Min_rozpoczecia) + 1) == 1 && Math.Floor(Math.Log10(Min_zakonczenia) + 1) == 1)
            //    return Nazwa_czynnosci.ToString() + ": 0" + (Godz_rozpoczecia) + ":0" + (Min_rozpoczecia) + " - 0" + (Godz_zakonczenia) + ":0" + (Min_zakonczenia);


            if (Godz_rozpoczecia >= 5 && Godz_rozpoczecia <= 9 && Godz_zakonczenia >= 5 && Godz_zakonczenia <= 9 && Min_rozpoczecia == 0 && Min_zakonczenia == 0) //obie godziny od 5 do 9 i minuty po 0
                return Nazwa_czynnosci.ToString() + ": 0" + (Godz_rozpoczecia) + ":0" + (Min_rozpoczecia) + " - 0" + (Godz_zakonczenia) + ":0" + (Min_zakonczenia);

            if (Godz_rozpoczecia >= 5 && Godz_rozpoczecia <= 9 && Godz_zakonczenia >= 5 && Godz_zakonczenia <= 9 && Min_rozpoczecia == 0) //obie godziny od 5 do 9 i minuty rozpoczecia 0
                return Nazwa_czynnosci.ToString() + ": 0" + (Godz_rozpoczecia) + ":0" + (Min_rozpoczecia) + " - 0" + (Godz_zakonczenia) + ":" + (Min_zakonczenia);

            if (Godz_rozpoczecia >= 5 && Godz_rozpoczecia <= 9 && Godz_zakonczenia >= 5 && Godz_zakonczenia <= 9 && Min_zakonczenia == 0) //obie godziny od 5 do 9 i minuty zakonczenia 0
                return Nazwa_czynnosci.ToString() + ": 0" + (Godz_rozpoczecia) + ":" + (Min_rozpoczecia) + " - " + (Godz_zakonczenia) + ":0" + (Min_zakonczenia);
            
            if (Godz_rozpoczecia >= 5 && Godz_rozpoczecia <= 9 && Godz_zakonczenia >= 5 && Godz_zakonczenia <= 9) //obie godziny od 5 do 9
                return Nazwa_czynnosci.ToString() + ": 0" + (Godz_rozpoczecia) + ":" + (Min_rozpoczecia) + " - 0" + (Godz_zakonczenia) + ":" + (Min_zakonczenia);

            if (Godz_rozpoczecia >= 5 && Godz_rozpoczecia <= 9 && Godz_zakonczenia > 9 && Min_rozpoczecia == 0 && Min_zakonczenia == 0) //rozpoczecia od 5 do 9 i minuty po 0
                return Nazwa_czynnosci.ToString() + ": 0" + (Godz_rozpoczecia) + ":0" + (Min_rozpoczecia) + " - " + (Godz_zakonczenia) + ":0" + (Min_zakonczenia);

            if (Godz_rozpoczecia >= 5 && Godz_rozpoczecia <= 9 && Godz_zakonczenia > 9 && Min_rozpoczecia == 0) //rozpoczecia od 5 do 9 i minuty rozpoczecia 0
                return Nazwa_czynnosci.ToString() + ": 0" + (Godz_rozpoczecia) + ":0" + (Min_rozpoczecia) + " - " + (Godz_zakonczenia) + ":" + (Min_zakonczenia);

            if (Godz_rozpoczecia >= 5 && Godz_rozpoczecia <= 9 && Godz_zakonczenia > 9 && Min_zakonczenia == 0) //rozpoczecia od 5 do 9 i minuty zakoczenia 0
                return Nazwa_czynnosci.ToString() + ": 0" + (Godz_rozpoczecia) + ":" + (Min_rozpoczecia) + " - " + (Godz_zakonczenia) + ":0" + (Min_zakonczenia);

            if (Godz_zakonczenia >= 5 && Godz_zakonczenia <= 9 && Min_rozpoczecia == 0 && Min_zakonczenia == 0) //zakonczenia od 5 do 9 i minuty po 0
                return Nazwa_czynnosci.ToString() + ": " + (Godz_rozpoczecia) + ":0" + (Min_rozpoczecia) + " - 0" + (Godz_zakonczenia) + ":0" + (Min_zakonczenia);

            if (Godz_zakonczenia >= 5 && Godz_zakonczenia <= 9 && Min_rozpoczecia == 0) //zakonczenia od 5 do 9 i minuty rozpoczecia 0
                return Nazwa_czynnosci.ToString() + ": " + (Godz_rozpoczecia) + ":0" + (Min_rozpoczecia) + " - 0" + (Godz_zakonczenia) + ":" + (Min_zakonczenia);

            if (Godz_zakonczenia >= 5 && Godz_zakonczenia <= 9 && Min_zakonczenia == 0) //zakonczenia od 5 do 9 i minuty zakonczenia 0
                return Nazwa_czynnosci.ToString() + ": " + (Godz_rozpoczecia) + ":0" + (Min_rozpoczecia) + " - " + (Godz_zakonczenia) + ":0" + (Min_zakonczenia);
            
            if (Godz_rozpoczecia < 9 && Godz_zakonczenia < 9 && Min_rozpoczecia == 0 && Min_zakonczenia == 0) //obie godziny powyzej 9 i minuty po 0
                return Nazwa_czynnosci.ToString() + ": " + (Godz_rozpoczecia) + ":" + (Min_rozpoczecia) + " - 0" + (Godz_zakonczenia) + ":0" + (Min_zakonczenia);

            if (Godz_rozpoczecia < 9 && Godz_zakonczenia < 9 && Min_rozpoczecia == 0) //obie godziny powyzej 9 i minuty rozpoczecia 0
                return Nazwa_czynnosci.ToString() + ": " + (Godz_rozpoczecia) + ":" + (Min_rozpoczecia) + " - 0" + (Godz_zakonczenia) + ":" + (Min_zakonczenia);
            
            if (Godz_rozpoczecia > 9 && Godz_zakonczenia > 9 && Min_zakonczenia == 0) //obie godziny powyzej 9 i minuty zakonczenia po 0
                return Nazwa_czynnosci.ToString() + ": " + (Godz_rozpoczecia) + ":" + (Min_rozpoczecia) + " - " + (Godz_zakonczenia) + ":0" + (Min_zakonczenia);



            else
            return Nazwa_czynnosci.ToString() + ": " + (Godz_rozpoczecia) + ":" + (Min_rozpoczecia) + " - " + (Godz_zakonczenia) + ":" + (Min_zakonczenia);
        }

        public static List<ZaplanowaneCzynnosciMedyczne> ListaZaplanowanychCzynnosci { get => listaZaplanowanychCzynnosci; set => listaZaplanowanychCzynnosci = value; }
        public Pracownicy Pracownik { get => pracownik; set => pracownik = value; }
        public Pacjenci Pacjent { get => pacjent; set => pacjent = value; }
        public DateTime Data_czynnosci { get => data_czynnosci; set => data_czynnosci = value; }
        public int Godz_rozpoczecia { get => godz_rozpoczecia; set => godz_rozpoczecia = value; }
        public int Min_rozpoczecia { get => min_rozpoczecia; set => min_rozpoczecia = value; }
        public int Czas_trwania { get => czas_trwania; set => czas_trwania = value; }
        public int Godz_zakonczenia { get => godz_zakonczenia; set => godz_zakonczenia = value; }
        public int Min_zakonczenia { get => min_zakonczenia; set => min_zakonczenia = value; }
    }
}
