
namespace DP_State
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var passanger = new Passenger.Passenger("Joe Doe");
            passanger.BuyTickets(new Ticket.Ticket("Joe Doe"));
            passanger.CheckInOnline();
            passanger.SubmitBaggage(new Baggage.Baggage(18.5F));
            passanger.GetBoardinPass();
            // Mistake - the passpro with wrong name
            passanger.PassControl(new Passport.Passport("Joe Doe_"));
            // No mistake - the passpro with correct name
            passanger.PassControl(new Passport.Passport("Joe Doe"));
            passanger.PassGate();
        }
    }
}
