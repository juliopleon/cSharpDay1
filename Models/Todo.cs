
namespace cSharpDay1.Models;

public class Todo

{
    public Todo(int id, string name, int date, bool completed)
    {
        Id = id;
        Name = name;
        Date = date;
        Complete = completed;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Date { get; set; }
    public bool Completed { get; set; }
}