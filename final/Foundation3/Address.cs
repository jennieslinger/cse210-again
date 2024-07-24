public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipcode;

    public Address(string street, string city, string state, string zipcode)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipcode = zipcode;
    }

    public string GetAddressString()
    {
        return $"{_street}, {_city}, {_state} {_zipcode}";
    }
}