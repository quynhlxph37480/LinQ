using System;
using System.Collections.Generic;

namespace LinqExamples_1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments();
            //// Select and Where Operators - Method Syntax (toán  tửu Select và where)
            //var results = employeeList.Select(e => new
            //{
            //    FullName = e.FirstName + " " + e.LastName,
            //    AnnualSalary = e.AnnualSalary

            //}).Where(e => e.AnnualSalary > 50000);
            //foreach (var item in results) 
            //{
            //    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary, 10}");

            //}
            //Console.ReadKey();


            //// Select and Where Operators - query Syntax 
            //var results = from emp in employeeList
            //              where emp.AnnualSalary >= 50000
            //              select new
            //              {
            //                  FullName = emp.LastName + " " + emp.FirstName,
            //                  AnnualSalary = emp.AnnualSalary
            //              };
            //// thêm 
            ////employeeList.Add(new Employee
            ////{
            ////    Id = 5,
            ////    LastName = "Quang",
            ////    FirstName = "Le",
            ////    AnnualSalary = 1000000,
            ////    IsManager = true,
            ////    DepartmentId = 2
            ////});
            //foreach(var item in results )
            //{
            //    Console.WriteLine($"{item.FullName, -20} {item.AnnualSalary,10}");
            //}
            //Console.ReadKey();


            //// Immediate Execution Exemple (vd thực hiện ngay lập tức )
            //var results =( from emp in employeeList.GetHighSalariedEmployees()
            //              select new
            //              {
            //                  FullName = emp.FirstName + " " + emp.LastName,
            //                  AnnualSalary = emp.AnnualSalary
            //              }).ToList(); // Khi thêm tolist  thì sẽ thực hiện ngay lập tức, k nhận thêm thông tin bên dưới 
            //employeeList.Add(new Employee
            //{
            //    Id = 5,
            //    LastName = "Quang",
            //    FirstName = "Le",
            //    AnnualSalary = 1000000,
            //    IsManager = true,
            //    DepartmentId = 2
            //});
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10}");
            //}

            //Console.ReadKey();

            ////join Operation Example - Method Syntax (join hai bảng với nhau)
            //var results = departmentList.Join(employeeList,
            //    department => department.Id,
            //    employee => employee.DepartmentId,
            //    (department, employee) => new
            //    {
            //        FullName = employee.FirstName + " " + employee.LastName,
            //        AnnualSalary = employee.AnnualSalary,
            //        DepartmentName = department.LongName
            //    }
            //    );
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10} \t {item.DepartmentName}");

            //}
            //Console.ReadKey();


            ////join Operation Example - Query Syntax
            //var resulte = from dept in departmentList
            //              join emp in employeeList
            //              on dept.Id equals emp.DepartmentId
            //              select new
            //              {
            //                  FullName = emp.FirstName + " " + emp.LastName,
            //                  AnnualSalary = emp.AnnualSalary,
            //                  DepartmentName = dept.LongName
            //              };
            //foreach(var item in resulte)
            //{
            //    Console.WriteLine($"{item.FullName, -20} {item.AnnualSalary,10} \t {item.DepartmentName}");
            //}
            //Console.ReadKey();

            //// GroupJoin  Operater Example - Method Syntax
            //var results = departmentList.GroupJoin(employeeList,
            //    dept => dept.Id,
            //    emp => emp.DepartmentId,
            //    (dept, employeeGroup) => new
            //    {
            //        Employees = employeeGroup,
            //        DepartmentName = dept.LongName

            //    }
            //    );
            //foreach(var item in results)
            //{
            //    Console.WriteLine($"Departmenr Name: {item.DepartmentName}");
            //    foreach (var emp in item.Employees)
            //        Console.WriteLine($"\t {emp.FirstName} {emp.LastName}");
            //}
            //Console.ReadKey();


            var results = from dept in departmentList
                          join emp in employeeList
                          on dept.Id equals emp.DepartmentId
                          into employeeGroup
                          select new
                          {
                              Employees = employeeGroup,
                              DepartmentName = dept.LongName
                          };
            foreach (var item in results)
            {
                Console.WriteLine($"Departmenr Name: {item.DepartmentName}");
                foreach (var emp in item.Employees)
                    Console.WriteLine($"\t {emp.FirstName} {emp.LastName}");
            }
            Console.ReadKey();

        }

    }
    public static class EnumerableCollectionExtensionMethods
    {
        public static IEnumerable<Employee> GetHighSalariedEmployees(this IEnumerable<Employee> employees)
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine($" Accessing emplloyee: {emp.FirstName + " " + emp.LastName}");
                if (emp.AnnualSalary >= 50000)
                    yield return emp;

            }
        }
    }

    ///
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AnnualSalary { get; set; }
        public bool IsManager { get; set; }
        public int DepartmentId { get; set; }
    }

    ///
    public class Department
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
    }

    ///
    public static class Data
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Jones",
                AnnualSalary = 60000.3m,
                IsManager = true,
                DepartmentId = 1
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 2,
                FirstName = "Sarah",
                LastName = "Jameson",
                AnnualSalary = 80000.1m,
                IsManager = true,
                DepartmentId = 2
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 3,
                FirstName = "Douglas",
                LastName = "Roberts",
                AnnualSalary = 40000.2m,
                IsManager = false,
                DepartmentId = 2
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 4,
                FirstName = "Jane",
                LastName = "Stevens",
                AnnualSalary = 30000.2m,
                IsManager = false,
                DepartmentId = 3
            };
            employees.Add(employee);

            return employees;
        }

        public static List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();

            Department department = new Department
            {
                Id = 1,
                ShortName = "HR",
                LongName = "Human Resources"
            };
            departments.Add(department);
            department = new Department
            {
                Id = 2,
                ShortName = "FN",
                LongName = "Finance"
            };
            departments.Add(department);
            department = new Department
            {
                Id = 3,
                ShortName = "TE",
                LongName = "Technology"
            };
            departments.Add(department);

            return departments;
        }

    }


}