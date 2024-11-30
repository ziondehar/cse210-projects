using System;

public class Address
{
    private string _StreetAddress;
    private string _City;
    private string _Country;
    private string _State;

    public Address(string streetAddress, string city, string country, string state)
    {
         _StreetAddress = streetAddress;
    _City = city;
    _Country = country;
    _State = state;
    }
}