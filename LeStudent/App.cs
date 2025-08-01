using System.Runtime.InteropServices.JavaScript;

namespace LeStudent;

public class App
{
    static Student student = new Student();
    static Stack<Student> students = new Stack<Student>();
    static Prompt prompt = new Prompt();
    public void AddStudent(Stack<Student> students, Student student)
    {
        students.Push(student);
    }

    public void runProgram()
    {
        bool flag = true;
        int choice;

        while (flag)
        {
            
        }
    }
    
}