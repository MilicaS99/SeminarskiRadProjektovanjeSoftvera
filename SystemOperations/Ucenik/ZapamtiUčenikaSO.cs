using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
   public class ZapamtiUčenikaSO : SystemOperationBase
    {
        private Učenik učenik;

        public ZapamtiUčenikaSO(Učenik učenik)
        {
            this.učenik = učenik;
        }

        protected override void Execute()
        {
            int ucenikid = repository.DodajSaVracanjem(učenik);
        }
    }
}
