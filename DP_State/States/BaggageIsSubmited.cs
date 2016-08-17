using System;

namespace DP_State.State
{
    public class BaggageIsSubmited : StateBase
    {

        public BaggageIsSubmited(DP_State.Passenger.Passenger passenger) : base(passenger)
        {
            
        }
        
        public override void BuyTickets()
        {
            Console.WriteLine("You are alredy bought the tickets");
        }

        public override void CheckInAiroport()
        {
            Console.WriteLine("You are already checked in");
        }

        public override void CheckInOnline()
        {
             Console.WriteLine("You are already checked in");
        }

        public override void GetBoardingPass()
        {
            TryToGetBoardingPass();
        }

        public override void PassControl()
        {
            Console.WriteLine("You should get boarding pass before");
        }

        public override void PassGate()
        {
            Console.WriteLine("You should get boarding pass and pass control before");
        }

        public override void SubmitBaggage()
        {
             Console.WriteLine("You have submited the baggage already");
        }
    }
}