using Mini_Projects.Exercises.Part1;

namespace Mini_Projects.Exercises.Part2;

public class Student: Person
{
    private int credits;
    public Student(string name, string address) : base(name, address)
    {
    }

    public void Study()
    {
        credits++;
    }

    public int Credits()
    {
        return credits;
    }
}