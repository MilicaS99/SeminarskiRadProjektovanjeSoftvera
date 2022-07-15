using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public interface IDomainObject
    {

       string ImeTabele { get;  }
       string VrednostiUnos { get; }

       string Uslov { get; }

       string UslovSpajanje { get; }

        string UslovPretraga { get; }

        string UslovIzmena { get; }

        string IdUbacenogObjekta { get; }

        string PomocniUslov { get; }

        IDomainObject ProcitajRed(SqlDataReader reader);
       
    }
}
