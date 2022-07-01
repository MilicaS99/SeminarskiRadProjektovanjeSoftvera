using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Vaspitač
    {
        [Browsable(false)]
        public int VaspitačID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Pol { get; set; }
        public string Kontakt { get; set; }
        public Program Program { get; set; }
        public override bool Equals(object obj)
        {
            if (obj is Vaspitač v)
            {
                return v.VaspitačID == VaspitačID;
            }
            return false;
        }
        public override string ToString()
        {
            return   $"{Ime} {Prezime}";
        }
    }
}
