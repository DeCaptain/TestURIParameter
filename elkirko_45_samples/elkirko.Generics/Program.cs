using System;
using elkirko.Generics.Repositories;
using elkirko.Generics.Entities;
using elkirko.Generics.Data;


namespace elkirko.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //createDB();

            var empRep = new SQLRepository<Employee>(new StorageAppDBContext());            
            
            //var empRep = new ListRepository<Employee>();

            AddEmployees(empRep);
            GetEmployeeById(empRep);

            var orgRep = new SQLRepository<Organization>(new StorageAppDBContext());
            AddOrganizations(orgRep);
            GetOrganizationById(orgRep);

            Console.Read();
        }

        private static void createDB()
        {
            using (var storageDBContext = new StorageAppDBContext())
            {
                var employee = new Employee()
                {
                    Id = 1,
                    FirstName = "Bob"
                };

                storageDBContext.Employees.Add(employee);

                var employee1 = new Employee()
                {
                    Id = 2,
                    FirstName = "Ted"
                };

                storageDBContext.Employees.Add(employee1);

                var org = new Organization 
                {
                    Id = 9,
                    Name = "Kirk Co"
                };

                storageDBContext.Organizations.Add(org);

                var org1 = new Organization
                {
                    Id = 10,
                    Name = "BIG Co"
                };

                storageDBContext.Organizations.Add(org1);

            }
        }

        private static void GetOrganizationById(IRepository<Organization> orgRep)
        {
            var org = orgRep.GetById(9);
            Console.WriteLine("org with Id 9: " + org.Name);
        
        }

        private static void GetEmployeeById(IRepository<Employee> empRep)
        {
           var employee =empRep.GetById(2);
           Console.WriteLine("Employee with Id 2: " + employee.FirstName);
        }

        private static void AddEmployees(IRepository<Employee> employeeRepository)
        {

            employeeRepository.Add(new Employee { FirstName = "Julia" });
            employeeRepository.Add(new Employee { FirstName = "Vic" });
            employeeRepository.Add(new Employee { FirstName = "Joe" });
            employeeRepository.Save();
        }

        private static void AddOrganizations(IRepository<Organization> orgRep)
        {
            orgRep.Add(new Organization { Name = "kirkCo" });
            orgRep.Add(new Organization { Name = "Co World" });
            orgRep.Add(new Organization { Name = "Co Joe" });
            orgRep.Save();

        }
    }
}
