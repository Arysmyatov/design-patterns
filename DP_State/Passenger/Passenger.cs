using DP_State.Baggage;
using DP_State.BoardingPass;
using DP_State.Passport;
using DP_State.State;
using DP_State.Ticket;

namespace DP_State.Passenger
{
    public class Passenger
    {
        public readonly string Name;

        public IPassport Passport { get; set; }

        public IBaggage Baggage { get; private set; }

        public ITicket Ticket { get; private set; }

        public IBoardingPass BoardingPass { get; set; }
        
        #region States
        
        public readonly IState NoTicketsState;
        public readonly IState NoBaggageRegisteredState;
        public readonly IState TicketsIsBoughtState;
        public readonly IState CheckInState;
        public readonly IState BaggageIsSubmited;        
        public readonly IState HasBoardingPassState;
        public readonly IState ControlPassedState;
        public readonly IState GatePassedState;

        #endregion States

        internal IState CurrentState { get; set; }


        #region Passenger states


        #endregion Passenger states

        public Passenger(string name)
        {
            Name = name;

            NoTicketsState = new NoTicketsState(this);
            TicketsIsBoughtState = new TicketsIsBoughtState(this);
            CheckInState = new CheckedInState(this);
            BaggageIsSubmited = new BaggageIsSubmited(this);
            HasBoardingPassState = new HasBoardingPassState(this);
            ControlPassedState = new ControlPassedState(this);
            GatePassedState = new GatePassedState(this);

            CurrentState = NoTicketsState;
        }

        public string GetName()
        {
            return Name;
        }

        public void BuyTickets(ITicket ticket)
        {
            Ticket = ticket;
            CurrentState.BuyTickets();
        }

        public void CheckInOnline()
        {
            CurrentState.CheckInOnline();
        }

        public void CheckInAirport()
        {
            CurrentState.CheckInAiroport();
        }

        public void SubmitBaggage(IBaggage baggege)
        {
            Baggage = baggege;
            CurrentState.SubmitBaggage();
        }

        public void GetBoardinPass()
        {
            CurrentState.GetBoardingPass();
        }

        public void PassControl(IPassport passport)
        {
            Passport = passport;
            CurrentState.PassControl();
        }

        public void PassGate()
        {
            CurrentState.PassGate();
        }
 
    }
}