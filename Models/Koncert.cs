namespace fil_sys.Models
{
    class Koncert
    {

        public string nazwa;
        StateHandler.EventState status;


        public Koncert(string nazwa, StateHandler.EventState status)
        {
            this.nazwa = nazwa;
            this.status = status;
        }

        public void changeStatus(StateHandler.EventState status)
        {
            this.status = status;
        }


    }
}
