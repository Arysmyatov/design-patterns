using System;

namespace DP_State.State
{
    public class TicketsIsBoughtState: StateBase
    {
        public TicketsIsBoughtState(DP_State.Passenger.Passenger passenger) : base(passenger)
        {
        }

        public override void BuyTickets()
        {
            Console.WriteLine("You are alredy bought the tickets");
        }

        public override void CheckInAiroport()
        {
            TryToCheckIn();
        }

        public override void CheckInOnline()
        {
            TryToCheckIn();
        }

        public override void GetBoardingPass()
        {
            Console.WriteLine("You should check in and submit the baggage");
        }

        public override void PassControl()
        {
             Console.WriteLine("You should check in and submit the baggage");
        }

        public override void PassGate()
        {
            Console.WriteLine("You should check in and submit the baggage");
        }

        public override void SubmitBaggage()
        {     
            Passenger.CurrentState = Passenger.BaggageIsSubmited;
        }

        private void TryToCheckIn()
        {
            TryTo("Check in");
            Passenger.CurrentState = Passenger.CheckInState;
            Console.WriteLine("You are checked in.");
        }
    }
    
}