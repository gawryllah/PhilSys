namespace fil_sys.Models
{
    class MiejsceSiedzace
    {
        int sektor;
        int rzad;
        int nrMiejsca;

        public MiejsceSiedzace(int sektor, int rzad, int nrMiejsca)
        {
            this.sektor = sektor;
            this.rzad = rzad;
            this.nrMiejsca = nrMiejsca;
        }

        public string getCompared()
        {
            return $"{sektor} {rzad} {nrMiejsca}";
        }
    }
}
