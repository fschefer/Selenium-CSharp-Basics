namespace HelloWorld;

class FirstProgram
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World, I am studying C#");
        string FirstName;
        string age;
        Console.WriteLine("What's your first name?");
        FirstName = Console.ReadLine();
        Console.WriteLine("What's your age?");
        age = Console.ReadLine();
        //Console.WriteLine("The user name is " + FirstName + " " + LastName);}
        string interpolatedResponse = $"The user's name is {FirstName} and he's {age} years old";
        Console.WriteLine(interpolatedResponse);
    }
}