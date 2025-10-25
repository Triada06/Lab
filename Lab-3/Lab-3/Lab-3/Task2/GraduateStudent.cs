namespace Lab_3.Task2;

public class GraduateStudent  : Student
{
    public string ThesisTitle;

    public GraduateStudent(string name, string surname, string thesisTitle) : base(name,  surname)
    {
        ThesisTitle = thesisTitle;
    }
}