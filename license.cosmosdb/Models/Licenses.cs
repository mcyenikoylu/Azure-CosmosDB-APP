using System.ComponentModel.DataAnnotations;

namespace license.cosmosdb;

public class Licenses
{
    [Key]
    public string? LicenseId { get; set; }
    public string? LicenseKey { get; set; }
    public DateTime? CreateDate { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string? EmpleyeeId { get; set; }
    //public string? CustomerId { get; set; }
}