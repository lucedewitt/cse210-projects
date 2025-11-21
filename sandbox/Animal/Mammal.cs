class Mammal
{
    protected string _name;
    protected string _sound;
    public Mammal(string name)
    {
        _name = name;
    }
    public virtual void MakeNoise()
    {
        Console.WriteLine($"{_name} makes no sound");
    }
    public override string ToString()
    {
        // return base.ToString();
        return $"{this.GetType()} named {_name}";
    }
}