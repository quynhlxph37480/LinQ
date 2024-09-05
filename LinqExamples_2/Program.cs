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


            //// SORTING OPERATIONS OrderBy,OrderByDescending,ThenBy,ThenByDescending
            //// Method  syntax
            //var results = employeeList.Join(departmentList, e => e.DepartmentId, d => d.Id,
            //    (emp, dept) => new
            //    {
            //        Id = emp.Id,
            //        FirstName = emp.FirstName,
            //        LastName = emp.LastName,
            //        AnnualSalary = emp.AnnualSalary,
            //        DepartmentId = emp.DepartmentId,
            //        DepartmentName = dept.LongName

            //    }).OrderByDescending(o => o.DepartmentId).ThenByDescending(o => o.AnnualSalary); // OrderBy, ThenBy(số) xếp từ trên xuống , OrderByDescending, ThenByDescending(số ) xếp từ dưới lên
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"First Name: {item.FirstName, -10} Last Name: {item.LastName, -10}  Annual Salary: {item.AnnualSalary, 10} \t Department Name: {item.DepartmentName} ");

            //}

            //// query Syntax
            //var results = from emp in employeeList
            //              join dept in departmentList
            //              on emp.DepartmentId equals dept.Id
            //              orderby emp.DepartmentId, emp.AnnualSalary
            //              select new
            //              {
            //                  Id = emp.Id,
            //                  FirstName = emp.FirstName,
            //                  LastName = emp.LastName,
            //                  AnnualSalary = emp.AnnualSalary,
            //                  DepartmentId = emp.DepartmentId,
            //                  DepartmentName = dept.LongName
            //              };
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"First Name: {item.FirstName,-10} Last Name: {item.LastName,-10}  Annual Salary: {item.AnnualSalary,10} \t Department Name: {item.DepartmentName} ");

            //}

            //grouping operations 
            //// GroupBy 
            //var groupResults = from emp in employeeList
            //                   orderby emp.DepartmentId // có thể kết hợp thêm orderby
            //                   group emp by emp.DepartmentId;  // nhóm cùng DepartmentId
            //foreach (var empGroup in groupResults)
            //{
            //    Console.WriteLine($" Department Id: {empGroup.Key}");
            //    foreach (Employee emp in empGroup)
            //    {
            //        Console.WriteLine($"\t Employee FullName: {emp.FirstName} {emp.LastName}");
            //    }
            //   }

            ////tolookup(để nhóm tất cả theo khóa cụ thể )
            //var groupResults = employeeList. ToLookup(e => e.DepartmentId);
            //// kết hợp   (var groupResults = employeeList.OrderBy(o => o.DepartmentId). ToLookup(e => e.DepartmentId);)
            //foreach (var empGroup in groupResults)
            //{
            //    Console.WriteLine($" Department Id: {empGroup.Key}");
            //    foreach (Employee emp in empGroup)
            //    {
            //        Console.WriteLine($"\t Employee FullName: {emp.FirstName} {emp.LastName}");
            //    }
            //}

            //// all , Any , Contains quantifier operators
            //// All(kiểm tra tất cả có phù hợp với điều kiện k) and Any(có ít nhất 1 phần tử có phù họp với điêu kiện hay k ) Operators
            //var annualSalaryCompare = 100000;
            //bool isTrueAll = employeeList.All(e => e.AnnualSalary > annualSalaryCompare);
            //if (isTrueAll)
            //{
            //    Console.WriteLine($"Tất cả mức lương của nhân viên đều cao hơn {annualSalaryCompare}");
            //}
            //else
            //{
            //    Console.WriteLine($"Không phải tất cả mức lương của nhân viên đều cao hơn {annualSalaryCompare}");
            //}
            //bool isTrueAny = employeeList.Any(e => e.AnnualSalary > annualSalaryCompare);
            //if (isTrueAny)
            //{
            //    Console.WriteLine($"Ít nhất có một nhân viến có lương trên  {annualSalaryCompare}");
            //}
            //else
            //{
            //    Console.WriteLine($"Không có nhân viên nào có mức lương cao hơn {annualSalaryCompare}");
            //}


            //// Contains Operators(kiểm tra xem có tồn tại không )
            //var searchEmployee = new Employee
            //{
            //    Id = 3,
            //    FirstName = "Douglas",
            //    LastName = "Roberts",
            //    AnnualSalary = 40000.2m,
            //    IsManager = false,
            //    DepartmentId = 2
            //};
            //bool containsEmployee = employeeList.Contains(searchEmployee, new EmployeeComparer());
            //if (containsEmployee)
            //{
            //    Console.WriteLine($"An employee record for {searchEmployee.FirstName} {searchEmployee.LastName} was found");
            //}
            //else
            //{
            //    Console.WriteLine($"An employee record for {searchEmployee.FirstName} {searchEmployee.LastName} was not found");

            //}



            // OfType filter Operators (lọc )
            ArrayList mixedCollection = Data.GetHeterogeneousDataCollection();
            //var stringResults = from s in mixedCollection.OfType<String>()
            //                    select s;
            //var stringResults = from s in mixedCollection.OfType<int>()
            //                    select s;
            //foreach (var item in stringResults)
            //{
            //    Console.WriteLine(item);
            //}
            //var employeeSerults = from e in mixedCollection.OfType<Employee>()
            //                      select e;
            //foreach (var emp in employeeList)
            //{
            //    Console.WriteLine($"{emp.Id,-5} {emp.FirstName,-10} {emp.LastName,-15} {emp.AnnualSalary}");

            //}
            //var departmebtSerults = from e in mixedCollection.OfType<Department>()
            //                        select e;
            //foreach (var dept in departmentList)
            //{
            //    Console.WriteLine($"{dept.Id,-5} {dept.ShortName,-20} {dept.LongName,-10}");
            //}


            ////ElementAtOrDefault, ElementAt (phần tử chỉ định)
            //var emp = employeeList.ElementAtOrDefault(3);
            //if (emp != null)
            //{
            //    Console.WriteLine($"{emp.Id,-5} {emp.FirstName,-10} {emp.LastName,-15} {emp.AnnualSalary}");

            //}
            //else
            //{
            //    Console.WriteLine("co cai cocak");
            //}


            // // First,FirstOrDefault(phần tử đầu),LastOrDefault,Last(phần tử cuối)
            //List<int> intergerList = new List<int> { 3, 39, 21, 19, 41 };
            //int result = intergerList.First(i => i % 2 == 0);
            //// //int result = intergerList.FirstOrDefault(i => i % 2 == 0);
            //// int result = intergerList.LastOrDefault(i => i % 2 == 0);

            //if (result != 0)
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("..........?");
            //}



            // SingleOrDefault, Single  (truy xuất 1 phần tử từ tập hợp)
            // var emp = employeeList.SingleOrDefault(x => x.Id == 2);
            //if (emp != null)
            // {
            //     Console.WriteLine($"{emp.Id,-5} {emp.FirstName,-10} {emp.LastName,-15} ");

            // }
            // else
            // {
            //     Console.WriteLine("co cai cocak");
            // }




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


        public static ArrayList GetHeterogeneousDataCollection()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(100);
            arrayList.Add("Bob Jones");
            arrayList.Add(2000);
            arrayList.Add(3000);
            arrayList.Add("Bill Henderson");
            arrayList.Add(new Employee { Id = 6, FirstName = "concak", LastName = "shit", AnnualSalary = 90000, IsManager = true, DepartmentId = 1 });
            arrayList.Add(new Employee { Id = 7, FirstName = "cuc", LastName = "cut", AnnualSalary = 60000, IsManager = false, DepartmentId = 2 });
            arrayList.Add(new Department { Id = 4, ShortName = "MKT", LongName = "Marketting" });
            arrayList.Add(new Department { Id = 5, ShortName = "HR", LongName = "khonbiet" });
            arrayList.Add(new Department { Id = 6, ShortName = "QC", LongName = "chuabiet" });

            return arrayList;
        }

    }





}