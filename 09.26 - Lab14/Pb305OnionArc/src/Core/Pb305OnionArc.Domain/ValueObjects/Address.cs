using Microsoft.EntityFrameworkCore;

namespace Pb305OnionArc.Domain.ValueObjects;

[Owned]
public class Address
{
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string ZipCode { get; private set; }
    public Address(string street, string city, string state, string zipCode)
    {
        if (string.IsNullOrWhiteSpace(street)) throw new ArgumentException("Street cannot be empty.");
        if (string.IsNullOrWhiteSpace(city)) throw new ArgumentException("City cannot be empty.");
        if (string.IsNullOrWhiteSpace(state)) throw new ArgumentException("State cannot be empty.");
        if (string.IsNullOrWhiteSpace(zipCode)) throw new ArgumentException("ZipCode cannot be empty.");

        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
    }
    public override string ToString()
    {
        return $"{Street}, {City}, {State} {ZipCode}";
    }
}
