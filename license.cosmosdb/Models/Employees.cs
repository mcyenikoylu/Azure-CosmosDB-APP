using System.ComponentModel.DataAnnotations;

namespace license.cosmosdb;

public class Employees
{
    [Key]
    public string? EmployeeId { get; set; }
    public string? EmployeeFullName { get; set; }
    public string? EmployeeEmail { get; set; }
    public string? AgencyName { get; set; }
    public string? EmployeeCountryName { get; set; }
    public string? LoginPassword { get; set; }
}