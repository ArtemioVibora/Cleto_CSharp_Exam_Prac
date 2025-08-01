namespace LeStudent;

public class Student
{
    private string name;
    private int age;
    private int studentNumber;

    public Student()
    {
        
    }
    public Student(string name, int age, int studentNumber)
    {
        this.name = name;
        this.age = age;
        this.studentNumber = studentNumber;
    }

    public string getName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    public int GetStudentNumber()
    {
        return studentNumber;
    }

    public override string ToString()
    {
        return name + " " + age + " " + studentNumber;
    }
}