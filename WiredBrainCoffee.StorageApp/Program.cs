using System;
using WiredBrainCoffee.StorageApp.Data;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());
            AddEmployees(employeeRepository);
            GetEmployeeById(employeeRepository);

            var organisationRepository = new ListRepository<Organisation>();
            AddOrganisations(organisationRepository);

            Console.ReadLine();

        }

        private static void GetEmployeeById(ListRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            Console.WriteLine($"Employee with ID 2: {employee.FirstName}");
        }

        private static void AddEmployees(ListRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { FirstName = "Julia" });
            employeeRepository.Add(new Employee { FirstName = "Anna" });
            employeeRepository.Add(new Employee { FirstName = "Thomas" });
            employeeRepository.Save();
        }

        private static void AddOrganisations(ListRepository<Organisation> organisationRepository)
        {
            organisationRepository.Add(new Organisation { Name = "Pluralsight" });
            organisationRepository.Add(new Organisation { Name = "Globomantics" });
            organisationRepository.Save();
        }
    }
}