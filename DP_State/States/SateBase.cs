using System;
using  System.Threading;

namespace DP_State.State
{
    public abstract class StateBase : IState
    {
        readonly internal DP_State.Passenger.Passenger Passenger;

        public StateBase(DP_State.Passenger.Passenger passenger)
        {
            Passenger = passenger;
        }
         
        internal void TryToGetBoardingPass()
        {
            TryTo("get boarding pass");

            if(Passenger.Ticket == null)
            {
                Console.WriteLine("You should buy tickets before");
                Passenger.CurrentState = Passenger.NoTicketsState;
                return;
            }
            
            if(Passenger.Baggage == null)
            {
                Console.WriteLine("You should set the baggage before");
                return;
            }

           if(Passenger.Baggage == null &&
              !Passenger.Baggage.IsRegistered())
            {
                Console.WriteLine("You should register the baggage");
                return;
            }

            Passenger.CurrentState = Passenger.HasBoardingPassState;
            Console.WriteLine("Tou have got the boarding pass.");
        }

        internal void TryTo(string stateName)
        {
            Console.WriteLine(string.Format("trying to: {0}", stateName));
            for(var i = 1; i < 10; i++)
            {
                Console.Write(". ");
                Thread.Sleep(300);
            }
            Console.WriteLine();
        }

        public abstract void BuyTickets();
        public abstract void CheckInAiroport();
        public abstract void CheckInOnline();
        public abstract void GetBoardingPass();
        public abstract void PassControl();
        public abstract void PassGate();
        public abstract void SubmitBaggage();


    }
}