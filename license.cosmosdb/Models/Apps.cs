using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace license.cosmosdb;

public class Apps
{
    [Key]
    public string? AppId { get; set; }
    public string? AppName { get; set; }
    public DateTime? CreateDate { get; set; }
    public Boolean? LicenseStatus { get; set; }
    public List<Licenses>? LicensesList { get; set; }
}