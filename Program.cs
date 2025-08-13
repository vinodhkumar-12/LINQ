using static Program;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {

        var EmployeeDepartment = Employee.GetEmployees().GroupJoin(Department.GetDepartments(), emp => emp.DepartmentId,

                    d => d.DepartmentId, (emp, dep) => new
                    {
                        emp = emp,
                        dep = dep
                    }

            ).SelectMany(z=> z.dep.DefaultIfEmpty(), (a,b) => new
            {
                employee = a.emp,
                DepartmentName = b == null ? "No Department" : b.DepartmentName
            });

        //var EmployeeDepartment = from employee in Employee.GetEmployees()
        //                         join department in Department.GetDepartments()
        //                             on employee.DepartmentId equals department.DepartmentId into empgroup
        //                         from emp in empgroup.DefaultIfEmpty() 
        //                         select new
        //                         {
        //                             employee = employee,
        //                             DepartmentName = emp == null? "No Department" :  emp.DepartmentName

        //                         };

        foreach (var emp in EmployeeDepartment)
        {
            Console.WriteLine(emp.DepartmentName + " " + emp.employee.FirstName + " " + emp.employee.LastName);
        }

    }
}

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }

    public int DepartmentId { get; set; }
    public double Salary { get; set; }

    public List<string> Skills { get; set; }

    public static List<Employee> GetEmployees()
    {
        return new List<Employee>()
        {
            new Employee(){ Id = 1, FirstName = "Vinodh", LastName = "Kumar", Age = 28, Salary = 100000, DepartmentId = 1, Gender = "Male", Skills = new List<string>(){ "C#","SQL" } },
            new Employee(){ Id = 2, FirstName = "Soumya", LastName = "Prakash", Age = 27, Salary = 120000, DepartmentId = 1, Gender = "Male", Skills = new List < string >(){ ".NET", "MVC"} },
            new Employee(){ Id = 3, FirstName = "Vijay", LastName = "Kumar", Age = 28, Salary = 100000, DepartmentId = 2, Gender = "Male" , Skills = new List < string >() {"JAVA", "Python"} },
            new Employee(){ Id = 4, FirstName = "Indumathi", LastName = "J", Age = 26, Salary = 80000, DepartmentId = 1, Gender = "Female" , Skills = new List < string >() {"ADO .NET", "Angular"} },
            new Employee(){ Id = 5, FirstName = "Santhosh", LastName = "Narayan", Age = 26, Salary = 80000, Gender = "Make" , Skills = new List < string >() {"ADO .NET", "Angular"} }
        };
    }
}

public class Department
{
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }

    public static List<Department> GetDepartments()
    {
        return new List<Department>()
        {
            new Department(){DepartmentId = 1, DepartmentName = "Scheduling"},
            new Department(){DepartmentId = 2, DepartmentName = "Billing"},
            new Department(){DepartmentId = 3, DepartmentName = "HR"}
        };
    }
}