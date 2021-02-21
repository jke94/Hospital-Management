#  Hospital-Management


A hospital database made with Entity Framework Core. 
Using [Entity Framework Core Tools](https://docs.microsoft.com/en-us/ef/core/cli/powershell), with Package Manager Console with Visual Studio Community 2019 to create and build the database.

The goald of this project it´s build a database to apply the [Entity Framework Core Data Seeding](https://docs.microsoft.com/es-es/ef/core/modeling/data-seeding). A powerfull technology to have a snapchots of the model of the database and inyect data in the database with an easy way
- 😃 See in 'DataSeeding' the classes used to generate randomly data and 'HospitalDataContext.cs' file to see how with the overried 'OnModelCreating' function you can inject the data.
```
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>().HasData(DoctorDataSeeded.GenerateRandomDoctors());

        modelBuilder.Entity<Patient>().HasData(PatientDataSeeded.GenerateRandomPatients());

        modelBuilder.Entity<MedicalTreatment>().HasData(MedicalTreatmentDataSeeded.GenerateMedicalTreatment());
    }
```
## Description

This project is composed by two projects:

 - 'HospitalConsole' project: A simple console command line to play with the database.
 - 'DataModel' project: It containts the database context, the models and migration of the database.

## Getting Started

### Dependencies or tool necesaries

* Visual Studio Community 2019
* .NET 5.0
* Sql Server Express Localdb

### Installing

* Clone project.
* Open Hospital.sln


### UpdateDatabase and apply the migration 'MigrationV0'.

1. Select DataModel project and 'Set as Startup Project'
2. Open "Package Manager Console" view in Visual Studio.
3. Select as 'Default Project', 'DataModel', into the "Package Manager Console" view.
4. The solution have instaled several NuGet Packages, one of them, [Microsoft.EntityFrameworkCore.Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools). Use 'Update-Database' command to apply the migration 'MigrationV0'. By default, 'Update-Database' command apply the last migration into 'Migrations' folder.
5. Play your way, in the 'HospitalConsole' project to access to the data. There is a example in the code.

## Help

Any advise for common problems or issues.


## Authors

Javier Carracedo 

Twitter Profile: [@JaviKarra94](https://twitter.com/JaviKarra94)

## Version History


## License

This project is licensed under the [NAME HERE] License - see the LICENSE.md file for details.
