class Product
{
    private string _name;
    private string _productID;
    private float _price;
    private int _quantity;
    public Product(string name, string productID, float price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public float TotalCost()
    {
        return _price * _quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetID()
    {
        return _productID;
    }
}