class Fox : Mammal
{
    public Fox(string name) : base(name)
    {
        _sound = "Ringa-ding-ding-ding-ringadingading";
    }
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} sings {_sound}");
    }
}