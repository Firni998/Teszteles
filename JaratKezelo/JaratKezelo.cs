using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaratKezelo
{
    public class JaratKezelo
    {
        public class Jarat
        {
            public Jarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
            {
                JaratSzam = jaratSzam;
                RepterHonnan = repterHonnan;
                RepterHova = repterHova;
                Indulas = indulas;
                Keses = 0;

            }

            public string JaratSzam { get; set; }
            public string RepterHonnan { get; set; }
            public string RepterHova { get; set; }
            public DateTime Indulas { get; set; }
            public int Keses { get; set; }


        }
    
         public List<Jarat> Jaratok = new List<Jarat>();

        public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas) {

            var j = new Jarat(jaratSzam, repterHonnan, repterHova, indulas);
            Jaratok.Add(j);
        }
        public void Keses(string jaratSzam, int keses) {
            foreach(var jarat in Jaratok)
            {
                int kesesek = 0;
                if (jarat.JaratSzam.Equals(jaratSzam))
                {
                    if((kesesek + keses) > kesesek)
                    {
                        kesesek += keses;

                    }else {
                        throw new NegativeKesesException(keses);
                    }
                    kesesek += keses;
                }

            }
        }

        public DateTime MikorIndul(string jaratSzam) {

            return DateTime.Now;
        }


        public  List<string>JaratokRepuloterrol(string repter)
        {
            List<string> Jaratok = new List<string>();
            return Jaratok;
        }
    }
}
