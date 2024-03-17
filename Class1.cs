
namespace Dzien_6_employee_
{ 
    internal class Employee
  { 
    public List<int> Scores = new List<int>();

    public Employee(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }

    public string Name { get; private set; }
    public string Surname { get; private set; }
    public int Age { get; private set; }

    public int Score
    {
        get
        {
            return this.Scores.Sum();
        }
    }
    public void AddScore(int score)
    {
        this.Scores.Add(score);
    }
   }
}