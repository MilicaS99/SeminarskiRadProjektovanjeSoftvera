using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Pohadjanje : IDomainObject
    {
        public Grupa Grupa { get; set; }
        public Učenik Učenik { get; set; }

        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }

        [Browsable(false)]
        public string ImeTabele => "Pohadjanje";

        [Browsable(false)]
        public string VrednostiUnos => $" ( '{Učenik.UčenikID}', '{Grupa.GrupaID}', '{DatumOd}',   '{DatumDo}')";
        [Browsable(false)]
        /// public string Uslov => $"UčenikID={Učenik.UčenikID} and GrupaID={Grupa.GrupaID}";
        public string Uslov => "GrupaID=";
        [Browsable(false)]
        public string UslovSpajanje => "p join Učenik u on u.UčenikID=p.UčenikID join Grupa g on g.GrupaID=p.GrupaID";
        [Browsable(false)]
        public string UslovPretraga => "g.NazivGrupe=";
        [Browsable(false)]
        public string UslovIzmena => "";
        [Browsable(false)]
        public string IdUbacenogObjekta => "";
        [Browsable(false)]
        public string PomocniUslov => "p.GrupaID=";

        public IDomainObject ProcitajRed(SqlDataReader reader)
        {
            Pohadjanje pohadjanje = new Pohadjanje()
            {
                Učenik = new Učenik()
                {
                    UčenikID = reader.GetInt32(0),
                    Ime = reader.GetString(5),
                    Prezime = reader.GetString(6)
                },
                Grupa = new Grupa()
                {
                    GrupaID = reader.GetInt32(1),
                    NazivGrupe = reader.GetString(11)
                },
                DatumOd = reader.GetDateTime(2),
                DatumDo = reader.GetDateTime(3)

            };
            return pohadjanje;
        }

       
    }
}