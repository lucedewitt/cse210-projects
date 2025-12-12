abstract class CurrentEvent
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    public CurrentEvent(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public void SDetails()
    {
        Console.WriteLine($"--{_title}--");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{_address.ReturnInfo()}");
        Console.WriteLine($"{_date} at {_time}");
    }
    public void FDetials()
    {
        SDetails();
        Console.WriteLine($"{this.GetType()}");
        Return();
    }
    public void Description()
    {
        Console.WriteLine($"{this.GetType()}");
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_date}");
    }
    public abstract string Return();
}