using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class ZapamtiVaspitačaSO : SystemOperationBase
    {
        private readonly Vaspitač vaspitač;
        public ZapamtiVaspitačaSO(Vaspitač vaspitač)
        {
            this.vaspitač = vaspitač;
        }
      
        protected override void Execute()
        {
            broker.SacuvajVaspitaca(vaspitač);
        }
    }
}
