namespace Lab_3.Task2;

public class Student
{
    public string Name;
    public int Age;
    public string Surname;
    public int Gpa;

    public Student(string name, string surname)
    {
        Surname = surname;
        Name = name;
    }

    public void Details() =>
        Console.WriteLine($"Student Name: {Name}, Age: {Age}, Surname: {Surname},  Gpa: {Gpa}");

    public void UpdateGpa(int gpa) =>
        Gpa = gpa;
    
}