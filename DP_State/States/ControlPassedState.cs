using System;

namespace DP_State.State
{
    public class ControlPassedState : StateBase
    {
        public ControlPassedState(DP_State.Passenger.Passenger passenger) : base(passenger)
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
            Console.WriteLine("You already have the boarding pass");
        }

        public override void PassControl()
        {
             Console.WriteLine("You already have passed the control");
        }

        public override void PassGate()
        {
            TryTo("pass the gate");
            Passenger.CurrentState = Passenger.GatePassedState;
            Console.WriteLine("You have passed the gate");
        }

        public override void SubmitBaggage()
        {
             Console.WriteLine("Your baggage is already submited");
        }
    }
}