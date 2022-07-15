using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
   public  class UcitajListuVaspitačaSO:SystemOperationBase
    {
        public List<Vaspitač> Rezultat { get; set; }

        protected override void Execute()
        {
            // Rezultat = broker.vratiListuVaspitaca();
            Rezultat = repository.VratiSve(new Vaspitač()).OfType<Vaspitač>().ToList();
        }
    }
}
