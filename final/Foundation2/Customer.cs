class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }
    public bool LiveInUS()
    {
        bool US = _address.LiveInUS();
        return US;
    }
    public string GetName()
    {
        return _name;
    }
    public string ReturnAddress()
    {
        return _address.ReturnInfo();
    }
}