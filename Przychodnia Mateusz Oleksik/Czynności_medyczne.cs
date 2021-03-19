using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_Mateusz_Oleksik
{
    [Serializable]
    public class Czynności_medyczne
    {
        static List<Czynności_medyczne> listaCzynnosciMedycznych = new List<Czynności_medyczne>();
        

        string nazwa_czynnosci;

       public Czynności_medyczne()
        {
            Nazwa_czynnosci = string.Empty;
        }

        public override string ToString()
        {
            return Nazwa_czynnosci;
        }

        public static List<Czynności_medyczne> ListaCzynnosciMedycznych { get => listaCzynnosciMedycznych; set => listaCzynnosciMedycznych = value; }
        public string Nazwa_czynnosci { get => nazwa_czynnosci; set => nazwa_czynnosci = value; }
    }
}
