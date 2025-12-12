class Bike : Exercise
{
    private double _speed;
    public Bike(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
        Speed();
    }
    public override void Speed()
    {
        SetSpeed(_speed);
        Distance();
        Pace();
    }
}