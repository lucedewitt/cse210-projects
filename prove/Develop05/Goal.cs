using System.Runtime.Remoting;

class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected string _displayed;
    public Goal()
    {
        Setup();
    }
    public Goal(string[] parts)
    {
        Load(parts);
    }
    public virtual void Setup()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
        _displayed =$" [ ] {_name} ({_description})";
    }
    public virtual void Display()
    {
        Console.WriteLine(_displayed);
    }
    public virtual void DisplayCompleted()
    {
        _displayed = $" [X] {_name} ({_description})";
    }
    public virtual int CompleteGoal()
    {
        DisplayCompleted();
        return GetPoints();
    }
    public int GetPoints() { return _points; }
    public string GetName() { return _name; }
    public virtual string Save()
    {
        return $"{this.GetType()}||{_name}||{_description}||{_points}";
    }
    public virtual void Load(string[] parts)
    {
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _displayed =$" [ ] {_name} ({_description})";
    }
}