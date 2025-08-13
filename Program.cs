using static Program;

public class Program
{
    public static void Main(string[] args)
    {
        //var employees = from employee in Employee.GetEmployees()
        //                select new
        //                {
        //                    Id = employee.Id,
        //                    Skills = employee.Skills,
        //                    FirstName = employee.FirstName + " " + employee.LastName   
        //                };


        var employees = Employee.GetEmployees().Select(employee => new
        {
            Id = employee.Id,
            Skills = employee.Skills,
            FirstName = employee.FirstName + " " + employee.LastName

        });

        foreach (var employee in employees)
        {
            Console.WriteLine("Employee Name is {0}", employee.FirstName);

            foreach (var skill in employee.Skills)
            {
                Console.WriteLine("* {0}", skill);
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
        public string DepartmentName { get; set; }
        public double Salary { get; set; }

        public List<string> Skills { get; set; }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee(){ Id = 1, FirstName = "Vinodh", LastName = "Kumar", Age = 28, Salary = 100000, DepartmentName = "Client", Gender = "Male", Skills = new List<string>(){ "C#","SQL" } },
                new Employee(){ Id = 2, FirstName = "Soumya", LastName = "Prakash", Age = 27, Salary = 120000, DepartmentName = "Scheduling", Gender = "Male", Skills = new List < string >(){ ".NET", "MVC"} },
                new Employee(){ Id = 3, FirstName = "Vijay", LastName = "Kumar", Age = 28, Salary = 100000, DepartmentName = "Billing", Gender = "Male" , Skills = new List < string >() {"JAVA", "Python"} }
            };
        }
    }
}