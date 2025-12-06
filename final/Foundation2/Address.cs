class Address
{
    private string _city;
    private string _state;
    private string _country;
    private string _street;
    public Address(string city, string state, string country, string street)
    {
        _city = city;
        _state = state;
        _country = country;
        _street = street;
    }
    public bool LiveInUS()
    {
        if (_country == "United States" || _country == "US")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string ReturnInfo()
    {
        return $"{_street} {_city} {_state}, {_country}";
    }
}