
namespace DP_State.State
{
    public interface IState
    {
        void BuyTickets();
        void CheckInOnline();
        void CheckInAiroport();
        void GetBoardingPass();
        void SubmitBaggage();
        void PassControl();
        void PassGate();
    }
}