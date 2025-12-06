class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    private string _packingLabel;
    private string _shippingLabel;
    private float _cost;
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public float TotalCost()
    {
        foreach (Product product in _products)
        {
            _cost += product.TotalCost();
        }
        if (_customer.LiveInUS() == true)
        {
            _cost += 5;
        }
        else
        {
            _cost += 35;
        }
        return _cost;
    }
    public string ReturnSLabel()
    {
        return $"--Shipping Label--\nName: {_customer.GetName()}\nAddress: {_customer.ReturnAddress()}";
    }
    public string ReturnPLabel()
    {
        foreach (Product product in _products)
        {
            _packingLabel = _packingLabel + $"{product.GetName()}: ";
            _packingLabel = _packingLabel + $"#{product.GetID()}\n";
        }
        return $"--Packing Label--\nProducts:\n{_packingLabel}";
    }
}