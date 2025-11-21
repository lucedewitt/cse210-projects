class Checklist : Goal
{
    private bool _state;
    private int _tracker = 0;
    private int _total;
    private int _bonusPoints;
    private bool _miniBonus = false;
    private int _miniBonusPoints;
    private bool _miniBonusState;
    public Checklist() : base() {}
    public Checklist(string[] parts) : base(parts) {}
    public override void Setup()
    {
        base.Setup();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _total = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
        Console.Write("Do you want a mini bonus halfway through? (yes/no) ");
        string input = Console.ReadLine().ToLower();
        if (input == "yes")
        {
            _miniBonus = true;
            Console.Write("How many points should the mini bonus be? ");
            _miniBonusPoints = int.Parse(Console.ReadLine());
        }
        _displayed =$" [ ] {_name} ({_description}) -- Currently Completed: {_tracker}/{_total}";
    }
    public override int CompleteGoal()
    {
        _tracker += 1;
        if (_tracker >= _total)
        {
            _state = true;
            _miniBonusState = false;
            return base.CompleteGoal() + _bonusPoints;
        }
        else if (_miniBonus && _tracker >= (_total/2))
        {
            _miniBonusState = true;
            return base.CompleteGoal() + _miniBonusPoints;
        }
        else
        {
            _miniBonusState = false;
            return base.CompleteGoal();
        }
    }
    public override void DisplayCompleted()
    {
        if (_tracker >= _total)
        {
            _displayed = $" [X] {_name} ({_description}) -- Currently Completed: {_tracker}/{_total}";
        }
        else
        {
            _displayed =$" [ ] {_name} ({_description}) -- Currently Completed: {_tracker}/{_total}";
        }
    }
    public bool GetMiniBonusState() { return _miniBonusState; }
    public int GetMiniBonusPoints() { return _miniBonusPoints; }
    public bool GetState() { return _state; }
    public int GetBonusPoints() { return _bonusPoints; }
    public override string Save()
    {
        return $"{base.Save()}||{_bonusPoints}||{_state}||{_tracker}||{_total}||{_miniBonus}||{_miniBonusPoints}||{_miniBonusState}";
    }
    public override void Load(string[] parts)
    {
        base.Load(parts);
        _bonusPoints = int.Parse(parts[4]);
        _state = bool.Parse(parts[5]);
        _tracker = int.Parse(parts[6]);
        _total = int.Parse(parts[7]);
        _miniBonus = bool.Parse(parts[8]);
        _miniBonusPoints = int.Parse(parts[9]);
        _miniBonusState = bool.Parse(parts[10]);
        DisplayCompleted();
    }
}