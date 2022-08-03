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

        #region inicijalizacija repozitorijuma
        /* private ProgramRepository programprepository = new ProgramRepository();
         private VaspitačRepository vaspitačRepository = new VaspitačRepository();
         private UčenikRepository ucenikRepository = new UčenikRepository();
         private GrupaRepository grupaRepository = new GrupaRepository();
         private PohadjanjeRepository pohadjanjeRepository = new PohadjanjeRepository();*/
        #endregion

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
        
        public object VratiSvaPohadjanja()
        {

            SystemOperationBase vratipohadjanja = new VratiPohadjanjaSO();
            vratipohadjanja.ExecuteTemplate();
            return ((VratiPohadjanjaSO)vratipohadjanja).Rezultat;

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
           

            SystemOperationBase login = new LoginSO(korisnik);
            login.ExecuteTemplate();
            return ((LoginSO)login).Rezultat;
        }

        public bool ZapamtiProgram(Program program)
        {
           // return programprepository.SacuvajProgram(program);

          SystemOperationBase operation = new ZapamtiProgramSO(program);
            operation.ExecuteTemplate();
            return operation.Uspesno;
        }

        public List<Program> NadjiPrograme(string kriterijum)
        {
            // return programprepository.NadjiPrograme(v);
            SystemOperationBase nadjiprograme = new NadjiProgrameSO(kriterijum);
            nadjiprograme.ExecuteTemplate();
            return ((NadjiProgrameSO)nadjiprograme).Rezultat;
        }

        public List<Program> VratiListuPrograma()
        {
            //return programprepository.VratiListuPrograma();
            SystemOperationBase vratilistuprograma = new UcitajListuProgramaSO();
            vratilistuprograma.ExecuteTemplate();
            return ((UcitajListuProgramaSO)vratilistuprograma).Rezultat;
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

        public List<Vaspitač> VratiListuVaspitaca()
        {
            //return vaspitačRepository.VratiListuVaspitaca();
            SystemOperationBase vratilistuvaspitaca = new UcitajListuVaspitačaSO();
            vratilistuvaspitaca.ExecuteTemplate();
            return ((UcitajListuVaspitačaSO)vratilistuvaspitaca).Rezultat;
        }

        public List<Vaspitač> PretraziVaspitace(string kriterijum)
        {
            //return vaspitačRepository.vratiVaspitacePoKriterijumu(v);
            SystemOperationBase nadjivaspitace = new PretraziVaspitace(kriterijum);
            nadjivaspitace.ExecuteTemplate();
            return ((PretraziVaspitace)nadjivaspitace).Rezultat;
        }

        public bool ZapamtiNovogVaspitaca(Vaspitač vaspitač)
        {
            // return vaspitačRepository.sacuvajIzmenjenogVaspitača(vaspitač);
            SystemOperationBase operation = new ZapamtiNovogVaspitaca(vaspitač);
            operation.ExecuteTemplate();
            return operation.Uspesno;
        }

        public List<Učenik> VratiListuUčenika()
        {
            // return ucenikRepository.VratiListuUčenika();
            SystemOperationBase vratilistuucenika = new UcitajListuUcenikaSO();
            vratilistuucenika.ExecuteTemplate();
            return ((UcitajListuUcenikaSO)vratilistuucenika).Rezultat;
        }

        public List<Učenik> PretraziUcenike(string kriterijum)
        {
            // return ucenikRepository.NadjiUčenike(kriterijum);
            SystemOperationBase pronadjiucenike = new PretraziUcenikeSO(kriterijum);
            pronadjiucenike.ExecuteTemplate();
            return ((PretraziUcenikeSO)pronadjiucenike).Rezultat;
        }

        public Array VratiListuUzrasta()
        {
           
                return Enum.GetValues(typeof(Uzrast));
            
        }

        public bool ZapamtiGrupu(Grupa grupa)
        {
            //return grupaRepository.ZapamtiGrupu(grupa);
            SystemOperationBase operation = new ZapamtiGrupuSO(grupa);
            operation.ExecuteTemplate();
            return operation.Uspesno;

        }

      

        public List<Pohadjanje> NadjiGrupe(string kriterijum)
        {
            //return grupaRepository.NadjiGrupe(kriterijum);
            SystemOperationBase nadjigrupe = new NadjiGrupeSO(kriterijum);
            nadjigrupe.ExecuteTemplate();
            return ((NadjiGrupeSO)nadjigrupe).Rezultat;

        }

        public bool ZapamtiNovuGrupu(Grupa grupa)
        {
            //return grupaRepository.ZapamtiNovuGrupu(objektiZaCuvanje);
            SystemOperationBase zapamtiNovuGrupu = new ZapamtiNovuGrupuSO(grupa);
            zapamtiNovuGrupu.ExecuteTemplate();
            return zapamtiNovuGrupu.Uspesno;
        }

    

       

        public Grupa UcitajGrupu(Grupa grupa)
        {
            SystemOperationBase ucitajgrupu = new UčitajGrupuSO(grupa);
            ucitajgrupu.ExecuteTemplate();

            return ((UčitajGrupuSO)ucitajgrupu).nađenagrupa;

        }

     

        public Vaspitač UcitajVaspitaca(Vaspitač vaspitač)
        {
            SystemOperationBase ucitajVaspitaca = new UcitajVaspitacaSO(vaspitač);
            ucitajVaspitaca.ExecuteTemplate();
            return ((UcitajVaspitacaSO)ucitajVaspitaca).Rezultat;

        }

        public Program UcitajProgram(Program program)
        {
            SystemOperationBase ucitajVaspitaca = new UcitajProgramSO(program);
            ucitajVaspitaca.ExecuteTemplate();
            return ((UcitajProgramSO)ucitajVaspitaca).Rezultat;
        }

        public Učenik UcitajUcenika(Učenik učenik)
        {
            SystemOperationBase ucitajUcenika = new UcitajUcenikaSO(učenik);
            ucitajUcenika.ExecuteTemplate();

            return ((UcitajUcenikaSO)ucitajUcenika).Rezultat;

        }

        public List<Vaspitač> VratiVaspitaceNaProgramu(Domain.Program program)
        {
            SystemOperationBase vrativaspitačenaprogramu = new VratiVaspitačeNaProgramuSO(program);
            vrativaspitačenaprogramu.ExecuteTemplate();

            return ((VratiVaspitačeNaProgramuSO)vrativaspitačenaprogramu).Rezultat;
        }

        public bool ObrisiVaspitaca(Vaspitač vaspitač)
        {
            SystemOperationBase obrisivaspitaca = new ObrisiVaspitaca(vaspitač);
            obrisivaspitaca.ExecuteTemplate();

            return obrisivaspitaca.Uspesno;

        }
    }
}
