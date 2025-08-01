using System.ComponentModel.Design;

namespace LeStudent;

public class Prompt
{
    public int promptAge()
    {
        int age;

        while (true)
        {
            try
            {
                Console.Write("Enter age: ");
                age = int.Parse(Console.ReadLine());
                if (age < 18)
                {
                    Console.WriteLine("You entered less than 18 years");
                    continue;
                }
                else
                {
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! Invalid input!");
                continue;
            }
        }
        return age;
    }
    
    public int promptStudentNumber()
    {
        int number;

        while (true)
        {
            try
            {
                Console.Write("Enter student number: ");
                number = int.Parse(Console.ReadLine());
                if (number < 1)
                {
                    Console.WriteLine("You entered less than 1. INVALID INPUT!");
                    continue;
                }
                else
                {
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! Invalid input!");
                continue;
            }
        }
        return number;
    }
}