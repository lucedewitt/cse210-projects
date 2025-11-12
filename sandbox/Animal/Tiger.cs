class Tiger : Mammal
{
    public Tiger(string name) : base(name)
    {
        _sound = "growl";
    }
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} says {_sound}");
    }
}