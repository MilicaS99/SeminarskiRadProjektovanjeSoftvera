using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
   public  class VratiListuUčenikaSO : SystemOperationBase
    {
        public List<Učenik> Rezultat { get; set; }
        protected override void Execute()
        {
            Rezultat = broker.vratiListuUčenika();
        }
    }
}
