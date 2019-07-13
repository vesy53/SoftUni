namespace p03._01.Ferrari
{
    public interface IFerrari
    {
        string Model { get; }

        string Driver { get; }

        string Brakes();

        string PushTheGasPedal();
    }
}
