class Run : Exercise
{
    private double _distance;
    public Run(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
        Distance();
    }
    public override void Distance()
    {
        SetDistance(_distance);
        Speed();
    }
}