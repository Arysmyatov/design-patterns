using System;

namespace DP_State.Baggage
{
    public class Baggage : IBaggage
    {
        public readonly float Weight; 

        private bool registered;

        public bool IsCheckIn { get; private set; }

        public Baggage(float weight)
        {
            Weight = weight;
        }

        void IBaggage.RegisterOnline()
        {
            registered = true;
        }

        void IBaggage.RegisterOnCheckIn()
        {
            registered = true;
        }

        bool IBaggage.IsRegistered()
        {
            return registered;
        }

        void IBaggage.CheckIn()
        {
            throw new NotImplementedException();
        }
    }
}