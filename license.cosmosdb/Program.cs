using license.cosmosdb;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Scripts;
using Microsoft.EntityFrameworkCore;

using (var licenseContext = new DBContext())
{
    // var employee1 = new Employees()
    // {
    //     id = Guid.NewGuid().ToString(),
    //     categoryId = "agency salesman",
    //     EmployeeFullName = "Sayhat Sirinoglu",
    //     EmployeeEmail = "sayhat.sirinoglu@spailor.com",
    //     EmployeeCountryName = "Mexico",
    //     AgencyName = "sayhat.sirinoglu",
    //     LoginPassword = Password.Generate(32, 12).ToString(),
    //     Role = "sales"
    // };

    // var employee2 = new Employees()
    // {
    //     id = Guid.NewGuid().ToString(),
    //     categoryId = "user",
    //     EmployeeFullName = "Cenk Yenikoylu",
    //     EmployeeEmail = "cenk.yenikoylu@spailor.com",
    //     EmployeeCountryName = "United States",
    //     AgencyName = "Spailor LLC",
    //     LoginPassword = Password.Generate(32, 12),
    //     Role = "administrator"
    // };

    // var employee3 = new Employees()
    // {
    //     id = Guid.NewGuid().ToString(),
    //     categoryId = "assistant",
    //     EmployeeFullName = "Merve Devrim",
    //     EmployeeEmail = "merve.devrim@spailor.com",
    //     EmployeeCountryName = "Turkey",
    //     AgencyName = "Spailor LLC",
    //     LoginPassword = Password.Generate(32, 12),
    //     Role = "user"
    // };

    // var employee4 = new Employees()
    // {
    //     id = Guid.NewGuid().ToString(),
    //     categoryId = "developer",
    //     EmployeeFullName = "Ecem Doga Kilinc",
    //     EmployeeEmail = "doga.kilinc@spailor.com",
    //     EmployeeCountryName = "Macedonia",
    //     AgencyName = "Spailor LLC",
    //     LoginPassword = Password.Generate(32, 12),
    //     Role = "user"
    // };

    // var employee5 = new Employees()
    // {
    //     id = Guid.NewGuid().ToString(),
    //     categoryId = "secretary",
    //     EmployeeFullName = "Seda Kurt",
    //     EmployeeEmail = "seda.kurt@spailor.com",
    //     EmployeeCountryName = "Turkey",
    //     AgencyName = "Spailor LLC",
    //     LoginPassword = Password.Generate(32, 12),
    //     Role = "user"
    // };

    // licenseContext.EmployeesDbSet?.Add(employee1);
    // licenseContext.EmployeesDbSet?.Add(employee2);
    // licenseContext.EmployeesDbSet?.Add(employee3);
    // licenseContext.EmployeesDbSet?.Add(employee4);
    // licenseContext.EmployeesDbSet?.Add(employee5);
    // await licenseContext.SaveChangesAsync();

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
    //     CreateDate = DateTime.Now.Date,
    //     LicenseStatus = true,
    //     LicensesList = new List<Licenses>(){
    //         new Licenses(){
    //             LicenseId = Guid.NewGuid().ToString(),
    //             LicenseKey = LicenseKeyGenerator.LicenseGenerate().ToString(),
    //             CreateDate = DateTime.Now.Date,
    //             ExpiryDate = DateTime.Now.Date.AddYears(1),
    //             EmpleyeeId = "5ce3fb2b-7acc-4164-b15d-64fe90758acc"
    //             //CustomerId = "fc3550ff-a090-45da-97f1-578675ba73b6"
    //         }
    //     },
    //     CustomersList = new List<Customers>(){
    //         new Customers(){
    //             CustomerId = Guid.NewGuid().ToString(),

    //             CompanyAddress= "Avenida Paseo Tulum MZ19A LT1 LC, P. Xaman - Ha 1-2, Playacar, 77717 Q.R., Playa del Carmen, Mexico",
    // CompanyName= "Tura Jewelry",
    // CompanyPhoneNo= "+52 984 211 8749",
    // ContactPersonEmail= "info@turajewelry.com.mx",
    // ContactPersonName= "Sayhat Sirinoglu",
    // CustomerCountryName= "Mexico"
    //         }
    //     }
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
    // await licenseContext.SaveChangesAsync();

    //
    //
    // select

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

        var apps = await licenseContext.EmployeesDbSet.Where(m => m.AgencyName == "Spailor LLC")
        .FirstOrDefaultAsync();
        Console.WriteLine("");
        Console.WriteLine("Name: " + apps?.EmployeeEmail);
        Console.WriteLine("Create Date: " + apps?.LoginPassword);
        // Console.WriteLine("LicenseKey: " + apps?.LicensesList?.First().LicenseKey);
        // Console.WriteLine("LicenseKey: " + apps?.CustomerList?.First().CompanyName);
        Console.WriteLine("---------------------------------");
    }


    ///
    ///
    /// update


    // if (licenseContext.EmployeesDbSet != null)
    // {
    //     var employee = await licenseContext.EmployeesDbSet
    //     .Where(m => m.EmployeeFullName == "Cenk Yenikoylu")
    //     .FirstOrDefaultAsync();
    //     if (employee != null)
    //     {
    //         employee.EmployeeFullName = "Cenk Yenikoylu2";
    //         await licenseContext.SaveChangesAsync();
    //     }
    // }


    // ///
    // /// remove

    // if (licenseContext.AppsDbSet != null)
    // {
    //     var app1 = await licenseContext.AppsDbSet
    //     .Where(m => m.id == "8852493f-8a8c-49b4-b2aa-2b1a03f5994a")
    //     .FirstOrDefaultAsync();
    //     if (app1 != null)
    //     {
    //         licenseContext.AppsDbSet.Remove(app1);
    //         await licenseContext.SaveChangesAsync();
    //     }
    // }



}


// {
//     "CustomerId": "fc3550ff-a090-45da-97f1-578675ba73b6",
//     "CompanyAddress": "Avenida Paseo Tulum MZ19A LT1 LC, P. Xaman - Ha 1-2, Playacar, 77717 Q.R., Playa del Carmen, Mexico",
//     "CompanyName": "Tura Jewelry",
//     "CompanyPhoneNo": "+52 984 211 8749",
//     "ContactPersonEmail": "info@turajewelry.com.mx",
//     "ContactPersonName": "Sayhat Sirinoglu",
//     "CustomerCountryName": "Mexico",
//     "Discriminator": "Customers",
//     "id": "Customers|fc3550ff-a090-45da-97f1-578675ba73b6",
//     "_rid": "DjYEAOwXJcUBAAAAAAAAAA==",
//     "_self": "dbs/DjYEAA==/colls/DjYEAOwXJcU=/docs/DjYEAOwXJcUBAAAAAAAAAA==/",
//     "_etag": "\"eb000fe6-0000-0700-0000-656f6c6c0000\"",
//     "_attachments": "attachments/",
//     "_ts": 1701801068
// }


