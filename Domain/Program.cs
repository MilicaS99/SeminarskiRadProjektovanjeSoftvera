using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Program
    {
        [Browsable(false)]
        public int ProgramID { get; set; }
        public string NazivPrograma { get; set; }
        public string Opis { get; set; }
        public override bool Equals(object obj)
        {
            if (obj is Program p)
            {
                return p.ProgramID == ProgramID;
            }
            return false;
        }
        public override string ToString()
        {
            return NazivPrograma;
        }
    }
}
