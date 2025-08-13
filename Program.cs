using static Program;

public class Program
{
    public static void Main(string[] args)
    {
        //var skills = from employee in Employee.GetEmployees()
        //             from skill in employee.Skills
        //             select new
        //             {
        //                 FirstName = employee.FirstName,
        //                 LastName = employee.LastName,
        //                 skill = skill
        //             };

        var skills = Employee.GetEmployees().SelectMany(emp => emp.Skills, (employee, skill) => new
        {
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            skill = skill
        });


        foreach (var skill in skills)
        {

            Console.WriteLine("{0} {1} {2}", skill.FirstName, skill.LastName, skill.skill);
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