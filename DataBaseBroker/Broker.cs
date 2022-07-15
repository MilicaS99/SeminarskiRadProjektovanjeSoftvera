using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseBroker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seminarskirad;
            Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection.Close();
        }


        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public SqlCommand CreateCommand()
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            return command;
        }

        #region Broker staro
        /*
        public Korisnik Login(Korisnik k)
        {


            Korisnik korisnik = new Korisnik();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select * from Korisnik  where KorisnickoIme='{k.KorisnickoIme}' and Lozinka='{k.Lozinka}'";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                    korisnik.Ime = reader.GetString(1);
                    korisnik.Prezime = reader.GetString(2);
                    korisnik.KorisnickoIme = reader.GetString(3);
                    korisnik.Lozinka = reader.GetString(4);
                    


                }
            }
         


            return korisnik;
        }

      
        public List<Vaspitač> vratiVaspitačeNaProgramu(Program program)
        {
                 List<Vaspitač> vaspitaci = new List<Vaspitač>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select * from Vaspitač  where ProgramID = {program.ProgramID}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Vaspitač v = new Vaspitač();
                    v.VaspitačID = reader.GetInt32(0);
                    v.Ime = reader.GetString(1);
                    v.Prezime = reader.GetString(2);
                    v.Pol = reader.GetString(3);
                    v.Kontakt = reader.GetString(4);
                    v.Program = new Program();
                    v.Program.ProgramID = reader.GetInt32(5);
                    
                    vaspitaci.Add(v);
                }
            }
            return vaspitaci;
        }

        public void ObisiUcenikaIzGrupe(Pohadjanje pohadjanje)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"delete from Pohadjanje  where (UčenikID={pohadjanje.Učenik.UčenikID} and GrupaID={pohadjanje.Grupa.GrupaID}) ";
            command.ExecuteNonQuery();
        }

        public Grupa UčitajGrupe(Grupa grupa)
        {

            Grupa ucitanagrupa = new Grupa();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select * from Grupa g join Program p  on p.ProgramID=g.ProgramID join Vaspitač v on v.VaspitačID=g.VaspitačID where g.GrupaID={grupa.GrupaID}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                     
                    ucitanagrupa.GrupaID = reader.GetInt32(0);
                    ucitanagrupa.NazivGrupe = reader.GetString(1);
                    ucitanagrupa.Uzrast = (Uzrast)reader.GetInt32(2);
                    ucitanagrupa.Program = new Program();
                    ucitanagrupa.Program.ProgramID = reader.GetInt32(3);
                    ucitanagrupa.Program.NazivPrograma = reader.GetString(6);
                    ucitanagrupa.Program.Opis = reader.GetString(7);
                    ucitanagrupa.Vaspitač = new Vaspitač();
                    ucitanagrupa.Vaspitač.VaspitačID = reader.GetInt32(4);
                    ucitanagrupa.Vaspitač.Ime = reader.GetString(9);
                    ucitanagrupa.Vaspitač.Prezime = reader.GetString(10);
                    ucitanagrupa.Vaspitač.Pol = reader.GetString(11);
                    ucitanagrupa.Vaspitač.Kontakt = reader.GetString(12);
                  
                }
            }
            return ucitanagrupa;
        }

      
        public int VratiIdPoslednjeUneteGrupe()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = $"select max(GrupaID) from Grupa";
            int trenutnoNajveciId = (int)command.ExecuteScalar();
            return trenutnoNajveciId;
        }

        
        public void ZapamtiPohadjanje(Pohadjanje pohadjanje)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "insert into Pohadjanje values (@Učenik,@Grupa,@DatumOD,@DatumDO)";
            command.Parameters.AddWithValue("@Učenik", pohadjanje.Učenik.UčenikID);
            command.Parameters.AddWithValue("@Grupa", pohadjanje.Grupa.GrupaID);
            command.Parameters.AddWithValue("@DatumOD", pohadjanje.DatumOd);
            command.Parameters.AddWithValue("@DatumDO", pohadjanje.DatumDo);


            command.ExecuteNonQuery();
        }
        public bool Uspesno { get; set; } = true;
        public object VratiPohadjanja()
        {
            List<Pohadjanje> pohadjanja = new List<Pohadjanje>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "select * from Pohadjanje p join Učenik u on u.UčenikID=p.UčenikID join Grupa g on g.GrupaID=p.GrupaID";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Pohadjanje p = new Pohadjanje();
                    p.Učenik = new Učenik();
                    p.Učenik.UčenikID = reader.GetInt32(0);
                    p.Učenik.Ime = reader.GetString(5);
                    p.Učenik.Prezime = reader.GetString(6);
                    p.Grupa = new Grupa();
                    p.Grupa.GrupaID = reader.GetInt32(1);
                    p.Grupa.NazivGrupe = reader.GetString(11);
                    p.DatumOd = reader.GetDateTime(2);
                    p.DatumDo = reader.GetDateTime(3);
                    pohadjanja.Add(p);

                   
                }
            }
            return pohadjanja;
        }

        public void SacuvajGrupu(Grupa grupa)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "insert into Grupa values (@NazivGrupe,@Uzrast,@Program,@Vaspitač)";
            command.Parameters.AddWithValue("@NazivGrupe", grupa.NazivGrupe);
            command.Parameters.AddWithValue("@Uzrast", grupa.Uzrast);
            command.Parameters.AddWithValue("@Program",grupa.Program.ProgramID);
            command.Parameters.AddWithValue("@Vaspitač", grupa.Vaspitač.VaspitačID);
    

            command.ExecuteNonQuery();
        }

        public List<Grupa> VratiSveGrupe()
        {
            List<Grupa> grupe = new List<Grupa>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "select * from Grupa g join Program p  on p.ProgramID=g.ProgramID join Vaspitač v on v.VaspitačID=g.VaspitačID";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Grupa g = new Grupa();
                    g.GrupaID = reader.GetInt32(0);
                    g.NazivGrupe = reader.GetString(1);
                    g.Uzrast = (Uzrast)reader.GetInt32(2);
                    g.Program = new Program();
                    g.Program.ProgramID = reader.GetInt32(3);
                    g.Program.NazivPrograma = reader.GetString(6);
                    g.Program.Opis = reader.GetString(7);
                    g.Vaspitač = new Vaspitač();
                    g.Vaspitač.VaspitačID = reader.GetInt32(4);
                    g.Vaspitač.Ime = reader.GetString(9);
                    g.Vaspitač.Prezime = reader.GetString(10);
                    g.Vaspitač.Pol = reader.GetString(11);
                    g.Vaspitač.Kontakt = reader.GetString(12);
                    grupe.Add(g);
                }
            }
            return grupe;
        }
        /*
        public void obriisiUcenika(Učenik u)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"delete Učenik from Učenik u where u.Ime = '{u.Ime}' and u.Prezime = '{u.Prezime}' ";
            command.ExecuteNonQuery();
        }*/
        /*

        public void ZapamtiNovuGrupu(Grupa grupa)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"Update Grupa set NazivGrupe='{grupa.NazivGrupe}', Uzrast = '{(int)grupa.Uzrast}',ProgramID='{grupa.Program.ProgramID}' ,VaspitačID = '{grupa.Vaspitač.VaspitačID}'  where GrupaID = {grupa.GrupaID }";
            command.ExecuteNonQuery();
        }

        public List<Pohadjanje> NadjiGrupe(string kriterijum)
        {
            List<Pohadjanje> pohadjanja = new List<Pohadjanje>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select * from Pohadjanje p join Učenik u on u.UčenikID=p.UčenikID join Grupa g on g.GrupaID=p.GrupaID  {kriterijum}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Pohadjanje p = new Pohadjanje();
                    p.Učenik = new Učenik();
                    p.Učenik.UčenikID = reader.GetInt32(0);
                    p.Učenik.Ime = reader.GetString(5);
                    p.Učenik.Prezime = reader.GetString(6);
                    p.Grupa = new Grupa();
                    p.Grupa.GrupaID = reader.GetInt32(1);
                    p.Grupa.NazivGrupe = reader.GetString(11);
                    p.DatumOd = reader.GetDateTime(2);
                    p.DatumDo = reader.GetDateTime(3);
                    pohadjanja.Add(p);
                }
            }
            if (pohadjanja.Count > 0)
            {
                return pohadjanja;
            }
            else
            {
                return null;
            }
        }

        public void SacuvajUcenika(Učenik učenik)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "insert into Učenik values (@Ime,@Prezime,@DatumRodjenja,@Pol,@KontaktRoditelja)";
            command.Parameters.AddWithValue("@Ime", učenik.Ime);
            command.Parameters.AddWithValue("@Prezime", učenik.Prezime);
            command.Parameters.AddWithValue("@DatumRodjenja", učenik.DatumRodjenja);
            command.Parameters.AddWithValue("@Pol", učenik.Pol);
            command.Parameters.AddWithValue("@KontaktRoditelja", učenik.TelefonRoditelja);

            command.ExecuteNonQuery();
        }

        public List<Učenik> vratiListuUčenika()
        {
            List<Učenik> učenici = new List<Učenik>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "select * from Učenik";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Učenik u = new Učenik();
                    u.UčenikID = reader.GetInt32(0);
                    u.Ime = reader.GetString(1);
                    u.Prezime = reader.GetString(2);
                    u.DatumRodjenja = reader.GetDateTime(3);
                    u.Pol = reader.GetString(4);
                    u.TelefonRoditelja = reader.GetString(5);
                    učenici.Add(u);
                }
            }
            return učenici;
        }

        public List<Učenik> NadjiUčenike(string v)
        {
            List<Učenik> učenici = new List<Učenik>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select * from Učenik {v}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Učenik u = new Učenik();
                    u.UčenikID = reader.GetInt32(0);
                    u.Ime = reader.GetString(1);
                    u.Prezime = reader.GetString(2);
                    u.DatumRodjenja = reader.GetDateTime(3);
                    u.Pol = reader.GetString(4);
                    u.TelefonRoditelja = reader.GetString(5);
                    učenici.Add(u);
                }
            }
            if (učenici.Count > 0)
            {
                return učenici;
            }
            else
            {
                return null;
            }

        }

        public List<Vaspitač> vratiListuVaspitaca()
        {

            List<Vaspitač> vaspitaci= new List<Vaspitač>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select * from Vaspitač v join Program p on p.ProgramID=v.ProgramID ";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Vaspitač v = new Vaspitač();
                    v.VaspitačID = reader.GetInt32(0);
                    v.Ime = reader.GetString(1);
                    v.Prezime = reader.GetString(2);
                    v.Pol = reader.GetString(3);
                    v.Kontakt = reader.GetString(4);
                    v.Program = new Program();
                    v.Program.ProgramID = reader.GetInt32(5);
                    v.Program.NazivPrograma = reader.GetString(7);
                    v.Program.Opis = reader.GetString(8);
                    vaspitaci.Add(v);
                }
            }
            return vaspitaci;
        }

        public void SacuvajIzmenjenogVaspitaca(Vaspitač vaspitač)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"Update Vaspitač set Kontakt = '{vaspitač.Kontakt}', ProgramID = '{vaspitač.Program.ProgramID}'  where VaspitačID =  {vaspitač.VaspitačID }";
            command.ExecuteNonQuery();
        }

        public List<Vaspitač> VratiVaspitačePoKriterijumu(string v)
        {
            List<Vaspitač> vaspitaci = new List<Vaspitač>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select * from Vaspitač v join Program p on p.ProgramID=v.ProgramID {v}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Vaspitač v1 = new Vaspitač();
                    v1.VaspitačID = reader.GetInt32(0);
                    v1.Ime = reader.GetString(1);
                    v1.Prezime = reader.GetString(2);
                    v1.Pol = reader.GetString(3);
                    v1.Kontakt = reader.GetString(4);
                    v1.Program = new Program();
                    v1.Program.ProgramID = reader.GetInt32(5);
                    v1.Program.NazivPrograma = reader.GetString(7);
                    v1.Program.Opis = reader.GetString(8);
                    vaspitaci.Add(v1);
                }
            }
            if (vaspitaci.Count > 0)
            {
                return vaspitaci;
            }
            else
            {
                return null;
            }
            
        }

        public void SacuvajVaspitaca(Vaspitač vaspitač)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "insert into Vaspitač values (@Ime,@Prezime,@Pol,@Kontakt,@Program)";
            command.Parameters.AddWithValue("@Ime", vaspitač.Ime);
            command.Parameters.AddWithValue("@Prezime", vaspitač.Prezime);
            command.Parameters.AddWithValue("@Pol",vaspitač.Pol);
            command.Parameters.AddWithValue("@Kontakt",vaspitač.Kontakt);
            command.Parameters.AddWithValue("@Program", vaspitač.Program.ProgramID);

            command.ExecuteNonQuery();
        }

        public void SacuvajProgram(Program program)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "insert into Program values (@Naziv,@Opis)";
            command.Parameters.AddWithValue("@Naziv", program.NazivPrograma);
            command.Parameters.AddWithValue("@Opis",program.Opis);
         

            command.ExecuteNonQuery();
        }

        public List<Program>NadjiPrograme(string v)
        {
            
                List<Program> programi = new List<Program>();
                SqlCommand command = new SqlCommand("", connection);
                command.CommandText = $"select * from Program {v}";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    Program p = new Program();
                    p.ProgramID = reader.GetInt32(0);
                    p.NazivPrograma = reader.GetString(1);
                    p.Opis = reader.GetString(2);
                    programi.Add(p);
                    }
                }
            if (programi.Count > 0)
            {
                return programi;
            }
            else
            {
                return null;
            }
        }

        public List<Program> VratiListuPrograma()
        {

            List<Program> programi = new List<Program>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select * from Program ";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Program p = new Program();
                    p.ProgramID = reader.GetInt32(0);
                    p.NazivPrograma = reader.GetString(1);
                    p.Opis = reader.GetString(2);
                    programi.Add(p);
                }
            }
            return programi;
        }*/
        #endregion

    }
}
