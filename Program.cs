
using Dzien_6_employee_;

Employee employee1 = new Employee("Jan", "Hansen", 25);
Employee employee2 = new Employee("Jenny", "Abelgreen", 28);
Employee employee3 = new Employee("Ib", "Svenson", 30);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

employee1.AddScore(3);
employee1.AddScore(2);
employee1.AddScore(1);
employee1.AddScore(9);
employee1.AddScore(5);

employee2.AddScore(4);
employee2.AddScore(4);
employee2.AddScore(4);
employee2.AddScore(3);
employee2.AddScore(7);

employee3.AddScore(2);
employee3.AddScore(2);
employee3.AddScore(1);
employee3.AddScore(5);
employee3.AddScore(8);

// employe with highest score

Employee employeeWithMaxScore = null;
int maxScore = -1;
foreach (var employee in employees)
{
    if (employee.Score > maxScore)
    {
        maxScore = employee.Score;
        employeeWithMaxScore = employee;
    }
}
//Display employee info with highest score
Console.WriteLine($"Employee with highest score");
Console.WriteLine($"{employeeWithMaxScore.Name} {employeeWithMaxScore.Surname} {employeeWithMaxScore.Age}years  score {maxScore} points");