public class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double CalculateSubtotal()
    {
        return _price * _quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public string GetQuantity()
    {
        return _quantity.ToString();
    }

    public string GetProductPrice()
    {
        return _price.ToString();
    }
}