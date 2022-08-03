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
    public class Program:IDomainObject
    {
        [Browsable(false)]
        public int ProgramID { get; set; }
        public string NazivPrograma { get; set; }
        public string Opis { get; set; }
        [Browsable(false)]
        public string ImeTabele => "Program";
        [Browsable(false)]
        public string VrednostiUnos => $" ('{NazivPrograma}', '{Opis}')";
        [Browsable(false)]
        public string Uslov => $"ProgramID={ProgramID}";
        [Browsable(false)]
        public string UslovSpajanje => "";
        [Browsable(false)]
        public string UslovPretraga => "Naziv like";
        [Browsable(false)]
        public string UslovIzmena => "";
        [Browsable(false)]
        public string  IdUbacenogObjekta => "ProgramID";
        [Browsable(false)]
        public string PomocniUslov => "";

        public override bool Equals(object obj)
        {
            if (obj is Program p)
            {
                return p.ProgramID == ProgramID;
            }
            return false;
        }

        public IDomainObject ProcitajRed(SqlDataReader reader)
        {
            Program program = new Program
            {
                ProgramID = reader.GetInt32(0),
                NazivPrograma = reader.GetString(1),
                Opis = reader.GetString(2)
            };
            return program;
        }

      

        public override string ToString()
        {
            return NazivPrograma;
        }
    }
}