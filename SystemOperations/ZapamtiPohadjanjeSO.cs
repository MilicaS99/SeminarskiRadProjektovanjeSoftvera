using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class ZapamtiPohadjanjeSO : SystemOperationBase
    {
        private Pohadjanje pohadjanje;

        public ZapamtiPohadjanjeSO(Pohadjanje pohadjanje)
        {
            this.pohadjanje = pohadjanje;
        }

        protected override void Execute()
        {
            int id = broker.VratiIdPoslednjeUneteGrupe();
            pohadjanje.Grupa = new Grupa();
            pohadjanje.Grupa.GrupaID = id;
            broker.ZapamtiPohadjanje(pohadjanje);
        }
    }
}
