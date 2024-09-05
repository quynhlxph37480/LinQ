using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace LinqExamples_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments();


            //Equality Opertor
            //SequenceEqual(so sanh)
            //var integerList1 = new List<int> { 1,2,3,4,5,6};
            //var integerList2 = new List<int> { 1, 2, 3, 4, 5, 7 };
            //var boolSequenceEqual = integerList1.SequenceEqual(integerList2);
            //Console.WriteLine(boolSequenceEqual);

            //var employeeListCompare = Data.GetEmployees();
            //bool boolSE = employeeList.SequenceEqual(employeeListCompare, new EmployeeComparer());
            //Console.WriteLine($"Result: {boolSE}");

            //// concat (ket hop)
            //var integerList1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            //var integerList2 = new List<int> { 7,8,9,10};
            //IEnumerable<int> concat = integerList1.Concat(integerList2);
            //foreach (var item in concat )
            //    Console.WriteLine(item);
            // List<Employee> employeesList2 = new List<Employee> { new Employee {Id = 5, FirstName= "cut", LastName =" trau" }, new Employee {Id = 6, FirstName= "cut", LastName= "cho" } };
            //IEnumerable<Employee> results = employeeList.Concat(employeesList2);
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,10}");

            ////Aggregate (tong)
            //decimal totaAnnuaSalary = employeeList.Aggregate<Employee, decimal>(0, (totaAnnuaSalary, e) =>
            //{
            //    var bonus = (e.IsManager) ? 0.04m : 0.02m;
            //    totaAnnuaSalary = (e.AnnualSalary + (e.AnnualSalary * bonus)) + totaAnnuaSalary;

            //    return totaAnnuaSalary;
            //});
            //Console.WriteLine($"Ton luong hang nam (tien thuong): {totaAnnuaSalary}");

            //string data = employeeList.Aggregate<Employee, string, string>("toongr tieenf luong nhaan vien (car thuowngr):",
            //    (s, e) =>
            //    {
            //        var bonus = (e.IsManager) ? 0.04m : 0.02m;
            //        s += $"{e.FirstName}   {e.LastName} - {e.AnnualSalary + (e.AnnualSalary * bonus)},";
            //        return s;
            //    },  s => s.Substring(0,s.Length -2)


            //);
            //Console.WriteLine( data );

            //// average (Tb)
            //decimal average = employeeList.Where(e => e.DepartmentId == 3).Average(e => e.AnnualSalary);
            //Console.WriteLine($"muwcs luowng trung binh (departmenId =3 ): {average}");

            //// Count 
            //int countEmp = employeeList.Count(e => e.DepartmentId == 3);
            //Console.WriteLine($"so luong nhaan vien(departmenId==3): {countEmp}");

            ////sum 
            //decimal sumEmp = employeeList.Sum(e => e.AnnualSalary);
            //Console.WriteLine($"tong : {sumEmp}");

            ////max
            // decimal maxEmp = employeeList.Max(e => e.AnnualSalary);
            //Console.WriteLine($"luowng cao nhat : {maxEmp}");


            //////DefaultIfEmpty ()
            ////List<int> intList = new List<int>();
            ////var newList = intList.DefaultIfEmpty();
            ////Console.WriteLine(newList.ElementAt(0));

            //List<Employee> empList = new List<Employee>();
            //var newList = empList.DefaultIfEmpty(new Employee { Id = 0 });
            //var result = newList.ElementAt(0);
            //if (result.Id == 0)
            //{
            //    Console.WriteLine($" trongs");
            //};


            ////empty
            //List<Employee> emptyList = Enumerable.Empty<Employee>().ToList();
            //emptyList.Add(new Employee {Id= 7, FirstName= "cut", LastName="nguoi" });
            //foreach(var item in emptyList)
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");


            //////Range
            //var intCollection = Enumerable.Range(19,25);
            //foreach (var item in intCollection) 
            //Console.WriteLine(item);


            ////// repeat
            //var str = Enumerable.Repeat<string>("cut", 30);
            //foreach (var item in str) 
            //Console.WriteLine(item);

            //////Distinct
            //List<int> ints = new List<int>{1, 2, 2, 2, 4, 5, 6, 8, 6, 6, 6, 4,};
            //var results = ints.Distinct();
            //foreach (var result in results) 
            //    Console.WriteLine(result);

            //////Except (có ở abs1 k có ở abs2)
            //IEnumerable<int> abs1 = new List<int> {1,2,3,4,5,6,7 };
            //IEnumerable<int> abs2 = new List<int> {  2, 3, 4, 5, 6, 7 };
            //var result = abs1.Except(abs2);
            //foreach (int i in result) 

            //    Console.WriteLine(i);


            ////
            // List<Employee> employeesList2 = new List<Employee>();
            //employeesList2.Add(new Employee
            //{
            //    Id = 1,
            //    FirstName = "Bob",
            //    LastName = "Jones",
            //    AnnualSalary = 60000.3m,
            //    IsManager = true,
            //    DepartmentId = 3
            //});
            // employeesList2.Add(new Employee
            //{
            //    Id = 3,
            //    FirstName = "Douglas",
            //    LastName = "Roberts",
            //    AnnualSalary = 40000.2m,
            //    IsManager = false,
            //    DepartmentId = 2
            //});
            // employeesList2.Add(new Employee
            // {
            //     Id = 6,
            //     FirstName = "an",
            //     LastName = "cut",
            //     AnnualSalary = 40044.2m,
            //     IsManager = false,
            //     DepartmentId = 2
            // });
            // employeesList2.Add(new Employee
            // {
            //     Id = 9,
            //     FirstName = "an",
            //     LastName = "shit",
            //     AnnualSalary = 800000,
            //     IsManager = true,
            //     DepartmentId = 2
            // });
            // //var result = employeeList.Except(employeesList2, new EmployeeComparer());
            // //foreach (var item in result)
            // //    Console.WriteLine($"{item.Id, -5} {item.FirstName,-10} {item.LastName, -10}");


            // ////Intersect (có ở abs1 có ở abs2)
            // //var result = employeeList.Intersect(employeesList2, new EmployeeComparer());
            // //foreach (var item in result)
            // //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            ////Union (gọp cả 2)
            // var result = employeeList.Union(employeesList2, new EmployeeComparer());
            // foreach (var item in result)
            //     Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            ////Skip( 3,4 )
            //var results = employeeList.Skip(2);
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");


            //SkipWhile
            //employeeList.Add(new Employee { Id = 5, FirstName = "an", LastName = "cut", AnnualSalary = 1000000 });
            //var results = employeeList.SkipWhile(e => e.AnnualSalary > 50000);
            //foreach (var item in results) 
            //    Console.WriteLine($"{item.Id, -5}{item.FirstName, -10}{item.LastName,-10} {item.AnnualSalary,-10}");

            ////take( 1,2 )
            //var results = employeeList.Take(2);
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            ////TakeWhile
            //employeeList.Add(new Employee { Id = 5, FirstName = "an", LastName = "cut", AnnualSalary = 1000000 });
            //var results = employeeList.TakeWhile(e => e.AnnualSalary > 50000);
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5}{item.FirstName,-10}{item.LastName,-10} {item.AnnualSalary,-10}");

            ////// ToList
            //List<Employee> results = (from emp in employeeList
            //                          where emp.AnnualSalary > 50000
            //                          select emp).ToList();
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5}{item.FirstName,-10}{item.LastName,-10} {item.AnnualSalary,-10}");

            ////// ToDictionary
            //Dictionary<int, Employee> dictionary = (from emp in employeeList
            //                                        where emp.AnnualSalary > 50000
            //                                        select emp).ToDictionary<Employee, int > (e => e.Id);   
            //foreach (var key  in dictionary.Keys) 
            // Console.WriteLine($"Key: {key}, Value:  {dictionary[key].FirstName}  {dictionary[key].LastName}");


            //// ToList
            //Employee[] results = (from emp in employeeList
            //                      where emp.AnnualSalary > 50000
            //                      select emp).ToArray();
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5}{item.FirstName,-10}{item.LastName,-10} {item.AnnualSalary,-10}");

            //// let
            //var results = from emp in employeeList
            //              let Initials = emp.FirstName.Substring(0, 1).ToUpper() + emp.LastName.Substring(0, 1).ToUpper()
            //              let AnnualSalaryPlusBonus = (emp.IsManager) ? emp.AnnualSalary + (emp.AnnualSalary * 0.04m) : emp.AnnualSalary + (emp.AnnualSalary * 0.02m)
            //              where Initials == "JS" || Initials == "SJ" && AnnualSalaryPlusBonus > 50000
            //              select new
            //              {
            //                  Initials = Initials,
            //                  FullName = emp.FirstName + " " + emp.LastName,
            //                  AnnualSalaryPlusBonus = AnnualSalaryPlusBonus
            //              };

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Initials,-5}{item.FullName,-20}{item.AnnualSalaryPlusBonus,-10} ");


            ////into
            // var results = from emp in employeeList
            //               where emp.AnnualSalary >50000
            //               select emp
            //               into HighEarners
            //               where HighEarners.IsManager == true
            //               select HighEarners;
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5}{item.FirstName,-10}{item.LastName,-10} {item.AnnualSalary,-10}");




            Console.ReadKey();
        }

    }
    public class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            if (x.Id == y.Id && x.FirstName.ToLower() == y.FirstName.ToLower() && x.LastName.ToLower() == y.LastName.ToLower())
            {
                return true;

            }
            return false;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id.GetHashCode();
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
                DepartmentId = 3
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 2,
                FirstName = "Sarah",
                LastName = "Jameson",
                AnnualSalary = 80000.1m,
                IsManager = true,
                DepartmentId = 1
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