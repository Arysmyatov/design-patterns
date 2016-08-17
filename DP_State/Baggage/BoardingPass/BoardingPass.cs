namespace DP_State.BoardingPass
{
    public class BoardingPass: IBoardingPass
    {
        public readonly string Terminal;
        public readonly string Gate;
        public readonly string Flight;
        public readonly string PersonName;
        
        public BoardingPass(string terminal, 
                            string gate, 
                            string flight, 
                            string personName)
        {
            Terminal   = terminal;
            Gate       = gate;
            Flight     = flight;
            PersonName = personName;
        }
    }
}