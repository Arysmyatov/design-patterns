using System;

namespace DP_State.State
{
    public class CheckedInState: StateBase
    {

        public CheckedInState(DP_State.Passenger.Passenger passenger) : base(passenger)
        {
        }

        public override void BuyTickets()
        {
            Console.WriteLine("You have alredy bought the tickets");
        }

        public override void CheckInOnline()
        {
            Console.WriteLine("You are already checked in");
        }

        public override void CheckInAiroport()
        {
            Console.WriteLine("You are already checked in");
        }

        public override void GetBoardingPass()
        {
             TryToGetBoardingPass();
        }

        public override void PassControl()
        {
              Console.WriteLine("You should check in and submit baggage before");
        }

        public override void PassGate()
        {
            Console.WriteLine("You should check in, submit baggage and pass control before");
        }

        public override void SubmitBaggage()
        {
            TryToSubmitBaggage();
        }

        #region private methods
        
        private void TryToSubmitBaggage()
        {
            TryTo("submit the baggage");

            if(Passenger.Baggage == null)
            {
                Console.WriteLine("You should set the baggage and its weight");
                return;
            }
            Passenger.CurrentState = Passenger.BaggageIsSubmited;
            Console.WriteLine("The baggage is submited");
        }

        private void TryToCheckIn()
        {
            if(Passenger.Ticket == null)
            {
                Console.WriteLine("You should buy tickets before");
                Passenger.CurrentState = Passenger.NoTicketsState;
                return;
            }
            Passenger.CurrentState = Passenger.CheckInState;
        }


        #endregion private methods

        // Passenger.CurrentState = Passenger.CheckInAOnlineState;
        // Console.WriteLine("You are already registered extra buggage before");
        // Console.WriteLine("You should submit your baggage and pass control before passing the gate");
    }
}