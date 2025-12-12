class Swim : Exercise
{
    private int _laps;
    public Swim(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
        Distance();
    }
    public override void Distance()
    {
        double distance = (_laps * 50.0) / 1000.0;
        SetDistance(distance);
        Speed();
    }
    public override void Summary()
    {
        base.Summary();
        Console.Write($" (Laps: {_laps})");
    }
}