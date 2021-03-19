using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_Mateusz_Oleksik
{
    [Serializable]
    public class Osoba
    {
        string imie, nazwisko;
        
        
        public Osoba() //konstruktor osoby
        {
            Imie = string.Empty;
            Nazwisko = string.Empty;        
        }

        public string Imie 
        { 
            get => imie; 
            set 
          {
                //if (imie.Length < 3)
                //    throw new ArgumentException("Podane imię jest za krótkie");
                //else
                imie = value;
            }
        }
        public string Nazwisko 
        { 
            get => nazwisko;
            set
            {
                //if (nazwisko.Length < 2)
                //    throw new ArgumentException("Podane imię jest za krótkie");
                //else
                    nazwisko = value;
            }
        }
    }
}
