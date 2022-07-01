using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class  Pohadjanje
    {
        public Grupa Grupa { get; set; }
        public Učenik Učenik { get; set; }
       
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }

      
    }
}
