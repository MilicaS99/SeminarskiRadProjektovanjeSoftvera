using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public  class Grupa
    {
        [Browsable(false)]
        public int GrupaID { get; set; }
        public string NazivGrupe { get; set; }
        public Uzrast Uzrast { get; set; }
        public Program Program { get; set; }
        public Vaspitač  Vaspitač { get; set; }

        public override string ToString()
        {
            return NazivGrupe;
        }
    }
}
