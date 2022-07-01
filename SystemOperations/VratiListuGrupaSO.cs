using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class VratiListuGrupaSO : SystemOperationBase
    {
        public List<Grupa> Rezultat { get; set; }
        protected override void Execute()
        {
            Rezultat = broker.VratiSveGrupe();
        }
    }
}
