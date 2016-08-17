namespace DP_State.Ticket
{
    public interface ITicket
    {
        string GetPersonName();
        void  CheckInOnline();
        bool IsChckedInOnline();
    }
}