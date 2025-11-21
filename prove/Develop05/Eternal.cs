class Eternal : Goal
{
    public Eternal() : base() {}
    public Eternal(string[] parts) : base(parts) {}
    public override int CompleteGoal()
    {
        return GetPoints();
    }
}