public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private const double ShippingUSA = 5;
    private const double ShippingIntl = 35;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotal()
    {
        double totalCost = 0;

        foreach (var product in _products)
        {
            totalCost += product.CalculateSubtotal();
        }

        //add shipping
        if (_customer.GetCustomerAddress().IsInUSA())
        {
            totalCost += ShippingUSA;
        }
        else
        {
            totalCost += ShippingIntl;
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packLabel = "Packing Label: ";
        foreach (var product in _products)
        {
            packLabel += $"\n{product.GetProductName()} -- Product ID: {product.GetProductId()} -- Price: {product.GetProductPrice()} -- Quantity: {product.GetQuantity()}\n";
        }
        return packLabel;
    }

    public string GetShippingLabel()
    {
        string shipLabel = "Shipping Label: ";
        shipLabel += $"\n{_customer.GetCustomerName()}";
        shipLabel += $"\n{_customer.GetCustomerAddress().GetAddressString()}";
        return shipLabel;
    }
}