class Simple : Goal
{
    private bool _state;
    public Simple() : base() {}
    public Simple(string[] parts) : base(parts) {}
    public override void Display()
    {
        base.Display();
    }
    public override int CompleteGoal()
    {
        _state = true;
        return base.CompleteGoal();
    }
    public override string Save()
    {
        return $"{base.Save()}||{_state}";
    }
    public override void Load(string[] parts)
    {
        base.Load(parts);
        _state = bool.Parse(parts[4]);
        if (_state)
        {
            DisplayCompleted();
        }
    }
}