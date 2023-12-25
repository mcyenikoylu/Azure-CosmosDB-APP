using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using Microsoft.EntityFrameworkCore;

namespace license.cosmosdb;

public class Apps
{
    [Key]
    public string? id { get; set; }
    public string? categoryId { get; set; }
    public string? AppName { get; set; }
    public DateTime? CreateDate { get; set; }
    public Boolean? LicenseStatus { get; set; }
    public List<Licenses>? LicensesList { get; set; }
    public List<Customers>? CustomersList { get; set; }
}