using DP_State.Baggage;
using DP_State.State;
using DP_State.Ticket;

namespace DP_State.Passenger
{
    public interface IPassenger
    {
        void BuyTickets(ITicket ticket);
        ITicket GetTickets();
        
        void BuyBaggage(IBaggage baggege);

        IBaggage GetBaggage();

        void RegisterBaggege();
        void CheckInOnline();
        void CheckInBaggge();
        void GetBoardingPass();
        void PassControll();
        void GetInThePlane();

        void SetCurrentState(IState stete);
        
        string GetName();

        void SetBaggage(IBaggage baggege);
    }
}