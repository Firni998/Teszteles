using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaratKezelo
{
    class NegativeKesesException:Exception
    {
        public NegativeKesesException(int keses)
            : base("Nem lehet negativ a végleges késés: " + keses.ToString())
        {
           
        }
        
    }
}
