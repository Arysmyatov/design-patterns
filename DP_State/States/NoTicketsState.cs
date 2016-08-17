using System;

namespace DP_State.State
{
    public class NoTicketsState : StateBase
    {

        public NoTicketsState(DP_State.Passenger.Passenger passenger) : base(passenger)
        {
        }

        public override void BuyTickets()
        {
            TryTo("Buy tickets");
            TryBuyTickets();
        }

        public override void CheckInAiroport()
        {
            Console.WriteLine("You should buy tickets before check in");
        }

        public override void CheckInOnline()
        {
            Console.WriteLine("You should buy tickets before check in");
        }

        public override void GetBoardingPass()
        {
             Console.WriteLine("You should buy tickets before  getting boarding pass");
        }

        public override void PassControl()
        {
            Console.WriteLine("You should buy tickets before passing control");
        }

        public override void PassGate()
        {
            Console.WriteLine("You should buy tickets before passing gate");
        }

        public override void SubmitBaggage()
        {
            Console.WriteLine("You should buy tickets before registering baggage");
        }


        private void TryBuyTickets()
        {
            if(Passenger.Ticket == null)
            {
                Console.WriteLine("You should buy tickets before");
                Passenger.CurrentState = Passenger.NoTicketsState;
            }

            Passenger.CurrentState = Passenger.TicketsIsBoughtState;
            Console.WriteLine("The thickets is bought");
        }
    }
}