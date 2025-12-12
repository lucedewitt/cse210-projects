class Outdoor : CurrentEvent
{
    private string _weather;
    private string _weatherMsg;
    public Outdoor(string title, string description, string date, string time, Address address, string weather) :base(title, description, date, time, address)
    {
        _weather = weather;
    }
    public override string Return()
    {
        _weatherMsg += $"The weather that day will be {_weather}";
        if (_weather == "rainy")
        {
            return _weatherMsg + $"\nPlease bring an umbrella.";
        }
        else if (_weather == "snowy")
        {
            return _weatherMsg + $"\nPlease bring an coat.";
        }
        else if (_weather == "cloudy")
        {
            return _weatherMsg + $"\nJackets are advised.";
        }
        else if (_weather == "Hot and smoky")
        {
            return _weatherMsg + $"Bring sunscreen and a respirating mask.";
        }
        else
        {
            return _weatherMsg;
        }
    }
}