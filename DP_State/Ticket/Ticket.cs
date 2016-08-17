namespace DP_State.Ticket
{
    public class Ticket : ITicket
    {
        private string _personName;
        private bool _checkedInOnline;

        public Ticket(string personName )
        {
            _personName = personName;
        }

        string ITicket.GetPersonName()
        {
           return _personName;
        }

        void ITicket.CheckInOnline()
        {
            _checkedInOnline = true;
        }

        bool ITicket.IsChckedInOnline()
        {
            return _checkedInOnline;
        }
    }
}