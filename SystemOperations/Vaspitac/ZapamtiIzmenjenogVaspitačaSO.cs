using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class ZapamtiIzmenjenogVaspitačaSO : SystemOperationBase
    {
        private Vaspitač vaspitač;

        public ZapamtiIzmenjenogVaspitačaSO(Vaspitač vaspitač)
        {
            this.vaspitač = vaspitač;
        }

        protected override void Execute()
        {
            //broker.SacuvajIzmenjenogVaspitaca(vaspitač);
            repository.IzmeniOdredjene(vaspitač);
        }
    }
}
