using System.ComponentModel.DataAnnotations;

namespace license.cosmosdb;

public class Customers
{
    [Key]
    public string? CustomerId { get; set; }
    public string? CompanyName { get; set; }
    public string? CompanyAddress { get; set; }
    public string? CompanyPhoneNo { get; set; }
    public string? ContactPersonName { get; set; }
    public string? ContactPersonEmail { get; set; }
    public string? CustomerCountryName { get; set; }
}