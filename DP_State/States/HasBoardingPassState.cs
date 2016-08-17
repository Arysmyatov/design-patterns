using System;

namespace DP_State.State
{
    public class HasBoardingPassState : StateBase
    {

        public HasBoardingPassState(DP_State.Passenger.Passenger passenger) : base(passenger)
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
            TryPassControl();
        }

        public override void PassGate()
        {
             Console.WriteLine("You should pass control before");
        }

        public override void SubmitBaggage()
        {
            Console.WriteLine("Your baggage is already submited");
        }


        #region private methods
        
        private void TryPassControl()
        {
            TryTo("pass control");
            if(Passenger.Passport == null)
            {
                Console.WriteLine("You should show the passport");
                return;
            }
            if(Passenger.Passport.GetName() != Passenger.Name)
            {
                Console.WriteLine("Sorry. You can not pass control: the name in passport and boarding pass should match.");
                return;
            }

            Passenger.CurrentState = Passenger.ControlPassedState;
            Console.WriteLine("You have passed the control");
        }

        #endregion private methods

        // Passenger.CurrentState = Passenger.CheckInAOnlineState;
        // Console.WriteLine("You are already registered extra buggage before");
        // Console.WriteLine("You should submit your baggage and pass control before passing the gate");
    }
}