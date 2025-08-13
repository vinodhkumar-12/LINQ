using static Program;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {

        var employeeGroupByGender = from employee in Employee.GetEmployees()
                                    group employee by employee.Gender into gender
                                    select new
                                    {
                                        Gender = gender.Key,
                                        GenderCount = gender.Count()
                                    };

       //var employeeGroupByGender = Employee.GetEmployees().GroupBy(x => x.Gender).Select(x => new
       // {
       //     Gender = x.Key,
       //     GenderCount = x.Count()
       // });
         
        foreach(var employeeGroup in employeeGroupByGender)
        {
            Console.WriteLine(employeeGroup.Gender + " " + employeeGroup.GenderCount);
        }

    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string DepartmentName { get; set; }
        public double Salary { get; set; }

        public List<string> Skills { get; set; }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee(){ Id = 1, FirstName = "Vinodh", LastName = "Kumar", Age = 28, Salary = 100000, DepartmentName = "Client", Gender = "Male", Skills = new List<string>(){ "C#","SQL" } },
                new Employee(){ Id = 2, FirstName = "Soumya", LastName = "Prakash", Age = 27, Salary = 120000, DepartmentName = "Scheduling", Gender = "Male", Skills = new List < string >(){ ".NET", "MVC"} },
                new Employee(){ Id = 3, FirstName = "Vijay", LastName = "Kumar", Age = 28, Salary = 100000, DepartmentName = "Billing", Gender = "Male" , Skills = new List < string >() {"JAVA", "Python"} },
                new Employee(){ Id = 4, FirstName = "Indumathi", LastName = "J", Age = 26, Salary = 80000, DepartmentName = "Clinician", Gender = "Female" , Skills = new List < string >() {"ADO .NET", "Angular"} }
            };
        }
    }
}