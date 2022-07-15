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
    public  class Učenik:IDomainObject
    {
       [Browsable(false)]
        public int UčenikID  { get; set; }
        public string  Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Pol { get; set; }
        public string TelefonRoditelja { get; set; }

        [Browsable(false)]
        public string ImeTabele => "Učenik";
        [Browsable(false)]
        public string VrednostiUnos => $" ('{Ime}', '{Prezime}','{DatumRodjenja}', '{Pol}','{TelefonRoditelja}')";
        [Browsable(false)]
        public string Uslov => $"UčenikID={UčenikID}";
        [Browsable(false)]
        public string UslovSpajanje => "";
        [Browsable(false)]
        public string UslovPretraga => "Ime =";
        [Browsable(false)]
        public string UslovIzmena => "";
        [Browsable(false)]
        public string IdUbacenogObjekta => "";
        [Browsable(false)]
        public string PomocniUslov => "";

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Učenik u)
            {
                return u.UčenikID == UčenikID;
            }
            return false;
        }

        public IDomainObject ProcitajRed(SqlDataReader reader)
        {
            Učenik ucenik = new Učenik
            {
                UčenikID = reader.GetInt32(0),
                Ime = reader.GetString(1),
                Prezime = reader.GetString(2),
                DatumRodjenja = reader.GetDateTime(3),
                Pol = reader.GetString(4),
                TelefonRoditelja = reader.GetString(5)
            };
            return ucenik;
        }

        
    }
}
