using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public  class Učenik
    {
       
        public int UčenikID  { get; set; }
        public string  Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Pol { get; set; }
        public string TelefonRoditelja { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
