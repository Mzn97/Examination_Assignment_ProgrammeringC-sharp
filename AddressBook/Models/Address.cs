using System.Net;

namespace AddressBook.Models;

public class Address
{
    public string? StreetName { get; set; }
    public string? StreetNumber { get; set; }
    public string? PostalCode { get; set; }
    public string? City { get; set; }

    public string? FullAddress => $"{StreetName} {StreetNumber}, {PostalCode} {City}";
}