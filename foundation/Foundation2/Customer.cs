using System;

public class Customer
{
    private string _name;
    private Address address;

    public Customer(string)
    
    public bool IsInUSA()
    {
        return _Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }
    public string GetFullCustomer()
    {
        return $"{_StreetAddress}\n{_City}\n{_State}\n{_Country}";
    }
}

