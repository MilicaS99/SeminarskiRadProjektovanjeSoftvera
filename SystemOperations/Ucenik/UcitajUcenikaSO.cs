using Domain;

namespace SystemOperations
{
    public class UcitajUcenikaSO : SystemOperationBase
    {
        private Učenik učenik;

        public Učenik Rezultat { get; set; }
        public UcitajUcenikaSO(Učenik učenik)
        {
            this.učenik = učenik;
        }

        protected override void Execute()
        {
             Rezultat = (Učenik)repository.VratiSamoJedan(učenik);
        }
    }
}