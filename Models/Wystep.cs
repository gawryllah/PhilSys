namespace fil_sys.Models
{
    class Wystep
    {
        public string nazwa;
        public string typ;
        StateHandler.EventState status;

        public Wystep(string nazwa, string typ, StateHandler.EventState status)
        {
            this.nazwa = nazwa;
            this.typ = typ;
            this.status = status;
        }

        public void changeStatus(StateHandler.EventState status)
        {
            this.status = status;
        }
    }
}

