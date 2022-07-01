using DataBaseBroker;
using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;

namespace ApplicationLogic
{
    public class Controller
    {
        private static Controller instance;
        private ProgramRepository programprepository = new ProgramRepository();
        private VaspitačRepository vaspitačRepository = new VaspitačRepository();
        private UčenikRepository ucenikRepository = new UčenikRepository();
        private GrupaRepository grupaRepository = new GrupaRepository();
        private PohadjanjeRepository pohadjanjeRepository = new PohadjanjeRepository();

        private Controller()
        {
            Init();
        }

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        public object VratiPohadjanja()
        {
            return pohadjanjeRepository.VratiPohadjanja();
        }

        public List<Korisnik> ListaKorisnika { get; set; }
        private void Init()
        {
            ListaKorisnika = new List<Korisnik>();
            ListaKorisnika.Add(new Korisnik
            {
                Ime = "Milica",
                Prezime = "Suknović",
                KorisnickoIme = "milica",
                Lozinka = "milica123"
            });
        }

        public object LogIN(Korisnik korisnik)
        {
            foreach(Korisnik k in ListaKorisnika)
            {
                if(k.KorisnickoIme==korisnik.KorisnickoIme && k.Lozinka == korisnik.Lozinka){



                    return k;
                }
            }
            return null;
        }

        public bool ZapamtiProgram(Program program)
        {
           // return programprepository.SacuvajProgram(program);

          SystemOperationBase operation = new ZapamtiProgramSO(program);
            operation.ExecuteTemplate();
            return operation.Uspesno;
        }

        public object NadjiPrograme(string kriterijum)
        {
            // return programprepository.NadjiPrograme(v);
            SystemOperationBase nadjiprograme = new NadjiProgrameSO(kriterijum);
            nadjiprograme.ExecuteTemplate();
            return ((NadjiProgrameSO)nadjiprograme).Rezultat;
        }

        public object VratiListuPrograma()
        {
            //return programprepository.VratiListuPrograma();
            SystemOperationBase vratilistuprograma = new VratiListuProgramaSO();
            vratilistuprograma.ExecuteTemplate();
            return ((VratiListuProgramaSO)vratilistuprograma).Rezultat;
        }

        public bool ZapamtiVaspitaca(Vaspitač vaspitač)
        {
            // return vaspitačRepository.ZapamtiVaspitaca(vaspitač);
            SystemOperationBase operation = new ZapamtiVaspitačaSO(vaspitač);
            operation.ExecuteTemplate();
            return operation.Uspesno;
        }
      
       
        public bool ZapamtiUčenika(Učenik učenik)
        {
            //return ucenikRepository.ZapamtiUčenika(učenik);
            SystemOperationBase operation = new ZapamtiUčenikaSO(učenik);
            operation.ExecuteTemplate();
            return operation.Uspesno;
        }

        public object VratiListuVaspitaca()
        {
            //return vaspitačRepository.VratiListuVaspitaca();
            SystemOperationBase vratilistuvaspitaca = new VratiListuVaspitačaSO();
            vratilistuvaspitaca.ExecuteTemplate();
            return ((VratiListuVaspitačaSO)vratilistuvaspitaca).Rezultat;
        }

        public object VratiVaspitacePoKriterijumu(string kriterijum)
        {
            //return vaspitačRepository.vratiVaspitacePoKriterijumu(v);
            SystemOperationBase nadjivaspitace = new NadjiVaspitačeSO(kriterijum);
            nadjivaspitace.ExecuteTemplate();
            return ((NadjiVaspitačeSO)nadjivaspitace).Rezultat;
        }

        public bool ZapamtiIzmenjenogVaspitača(Vaspitač vaspitač)
        {
            // return vaspitačRepository.sacuvajIzmenjenogVaspitača(vaspitač);
            SystemOperationBase operation = new ZapamtiIzmenjenogVaspitačaSO(vaspitač);
            operation.ExecuteTemplate();
            return operation.Uspesno;
        }

        public object VratiListuUčenika()
        {
            // return ucenikRepository.VratiListuUčenika();
            SystemOperationBase vratilistuucenika = new VratiListuUčenikaSO();
            vratilistuucenika.ExecuteTemplate();
            return ((VratiListuUčenikaSO)vratilistuucenika).Rezultat;
        }

        public object NadjiUčenike(string kriterijum)
        {
            // return ucenikRepository.NadjiUčenike(kriterijum);
            SystemOperationBase pronadjiucenike = new NadjiUčenikeSO(kriterijum);
            pronadjiucenike.ExecuteTemplate();
            return ((NadjiUčenikeSO)pronadjiucenike).Rezultat;
        }

        public Array VratiListuUzrasta()
        {
           
                return Enum.GetValues(typeof(Uzrast));
            
        }

        public bool ZapamtiGrupu(List<object> objekti)
        {
            //return grupaRepository.ZapamtiGrupu(grupa);
            SystemOperationBase operation = new ZapamtiGrupuSO(objekti);
            operation.ExecuteTemplate();
            return operation.Uspesno;

        }

        public object VratiSveGrupe()
        {
            // return grupaRepository.VratiSveGrupe();
            SystemOperationBase vratigrupe =new VratiListuGrupaSO();
            vratigrupe.ExecuteTemplate();
            return ((VratiListuGrupaSO)vratigrupe).Rezultat;
        }

        public object NadjiGrupe(string kriterijum)
        {
            //return grupaRepository.NadjiGrupe(kriterijum);
            SystemOperationBase nadjigrupe = new NadjiGrupeSO(kriterijum);
            nadjigrupe.ExecuteTemplate();
            return ((NadjiGrupeSO)nadjigrupe).Rezultat;

        }

        public bool ZapamtiNovuGrupu(Grupa grupa)
        {
            return grupaRepository.ZapamtiNovuGrupu(grupa);
        }

        public bool ZapamtiPohadjanje(Pohadjanje pohadjanje)
        {
            //return pohadjanjeRepository.ZapamtiPohadjanje(pohadjanje);
            SystemOperationBase zapamtipohadjanje = new ZapamtiPohadjanjeSO(pohadjanje);
            zapamtipohadjanje.ExecuteTemplate();
            return zapamtipohadjanje.Uspesno;
        }
    }
}
