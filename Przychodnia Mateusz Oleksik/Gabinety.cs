using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_Mateusz_Oleksik
{
    [Serializable]
    class Gabinety
    {
        static List<Gabinety> lista_gabinetow = new List<Gabinety>();

        int numer_gabinetu;
        public Gabinety()
        {
            Numer_gabinetu = int.MinValue;
        }

        public override string ToString()
        {
            return Numer_gabinetu.ToString();
        }

        internal static List<Gabinety> Lista_gabinetow 
        { 
            get => lista_gabinetow; 
            set 
            { 
                lista_gabinetow = value;
            } 
        }
        public int Numer_gabinetu { get => numer_gabinetu; set => numer_gabinetu = value; }

    }
}
