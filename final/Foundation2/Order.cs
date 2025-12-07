class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetTotal()
    {
        double total = 0;
        foreach(Product product in _products)
        {
            total+=product.GetTotalPrice();
        }
        if (_customer.isInUSA())
        {
            total+=5;
        } else
        {
            total+=35;
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string label = $"{_customer.GetName()}";
        foreach(Product product in _products)
        {
            label += $"\nProduct Name: {product.GetName()}  Product ID: {product.GetProductID()}";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddressString()}";
    }
}