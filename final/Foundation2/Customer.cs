public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public Address GetCustomerAddress()
    {
        return _address;
    }
}