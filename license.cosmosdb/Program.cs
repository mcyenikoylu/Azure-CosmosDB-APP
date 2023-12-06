using license.cosmosdb;
using Microsoft.EntityFrameworkCore;

using (var licenseContext = new DBContext())
{
    // // // var employee1 = new Employees()
    // // // {
    // // //     EmployeeId = Guid.NewGuid().ToString(),
    // // //     EmployeeFullName = "Sayhat Sirinoglu",
    // // //     EmployeeEmail = "sayhat.sirinoglu@spailor.com",
    // // //     EmployeeCountryName = "Mexico",
    // // //     AgencyName = null,
    // // //     LoginPassword = Password.Generate(32, 12).ToString()
    // // // };

    // // // var employee2 = new Employees()
    // // // {
    // // //     EmployeeId = Guid.NewGuid().ToString(),
    // // //     EmployeeFullName = "Cenk Yenikoylu",
    // // //     EmployeeEmail = "cenk.yenikoylu@spailor.com",
    // // //     EmployeeCountryName = "United States",
    // // //     AgencyName = "Spailor LLC",
    // // //     LoginPassword = Password.Generate(32, 12)
    // // // };

    // // // licenseContext.EmployeesDbSet?.Add(employee1);
    // // // licenseContext.EmployeesDbSet?.Add(employee2);

    // // var customer1 = new Customers()
    // // {
    // //     CustomerId = Guid.NewGuid().ToString(),
    // //     CompanyName = "Tura Jewelry",
    // //     CompanyAddress = "Avenida Paseo Tulum MZ19A LT1 LC, P. Xaman - Ha 1-2, Playacar, 77717 Q.R., Playa del Carmen, Mexico",
    // //     CompanyPhoneNo = "+52 984 211 8749",
    // //     ContactPersonName = "Sayhat Sirinoglu",
    // //     ContactPersonEmail = "info@turajewelry.com.mx",
    // //     CustomerCountryName = "Mexico"
    // // };

    // // licenseContext.CustomersDbSet?.Add(customer1);

    // var app1 = new Apps()
    // {
    //     AppId = Guid.NewGuid().ToString(),
    //     AppName = "Jewelry CRM",
    //     CreateDate = new DateTime(2022, 12, 05),
    //     LicenseStatus = true,
    //     LicensesList = new List<Licenses>(){
    //         new Licenses(){
    //             LicenseId = Guid.NewGuid().ToString(),
    //             LicenseKey = LicenseKeyGenerator.LicenseGenerate().ToString(),
    //             CreateDate = new DateTime(2023,12,5),
    //             ExpiryDate = new DateTime(2024,12,5),
    //             EmpleyeeId = "5ce3fb2b-7acc-4164-b15d-64fe90758acc",
    //             CustomerId = "fc3550ff-a090-45da-97f1-578675ba73b6"
    //         }
    //     }
    // };

    // var app2 = new Apps()
    // {
    //     AppId = Guid.NewGuid().ToString(),
    //     AppName = "Barduck CRM",
    //     CreateDate = new DateTime(2018, 12, 5),
    //     LicenseStatus = false,
    //     LicensesList = null
    // };

    // var app3 = new Apps()
    // {
    //     AppId = Guid.NewGuid().ToString(),
    //     AppName = "Farm CRM",
    //     CreateDate = new DateTime(2021, 12, 5),
    //     LicenseStatus = false,
    //     LicensesList = null
    // };

    // var app4 = new Apps()
    // {
    //     AppId = Guid.NewGuid().ToString(),
    //     AppName = "Telecommunication CRM",
    //     CreateDate = new DateTime(2019, 12, 5),
    //     LicenseStatus = false,
    //     LicensesList = null
    // };

    // var app5 = new Apps()
    // {
    //     AppId = Guid.NewGuid().ToString(),
    //     AppName = "Real Estate CRM",
    //     CreateDate = new DateTime(2014, 12, 5),
    //     LicenseStatus = false,
    //     LicensesList = null
    // };

    // licenseContext.AppsDbSet?.Add(app1);
    //await licenseContext.SaveChangesAsync();

    if (licenseContext.AppsDbSet != null)
    {
        //var apps = await licenseContext.AppsDbSet.ToListAsync();
        // Console.WriteLine("");
        // foreach (var app in apps)
        // {
        //     Console.WriteLine("Name: " + app.AppName);
        //     Console.WriteLine("Create Date: " + app.CreateDate);
        //     Console.WriteLine("---------------------------------");
        // }

        var apps = await licenseContext.AppsDbSet.Where(m => m.AppName == "Jewelry CRM")
        .FirstOrDefaultAsync();
        Console.WriteLine("");
        Console.WriteLine("Name: " + apps?.AppName);
        Console.WriteLine("Create Date: " + apps?.CreateDate);
        Console.WriteLine("Create Date: " + apps?.LicenseStatus);
        Console.WriteLine("---------------------------------");
    }


}