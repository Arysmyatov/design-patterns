namespace DP_State.Baggage
{
    public interface IBaggage
    {
        void RegisterOnline();
        void CheckIn();

        void RegisterOnCheckIn();

        bool IsRegistered();
    }
}