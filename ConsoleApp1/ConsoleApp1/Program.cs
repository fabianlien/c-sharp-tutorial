internal class Program
{
    private static void Main(string[] args)
    {
        /*Beep test,
         *just for fun!*/
        Console.Beep();
        Console.WriteLine("beep successful");

        //Escape Sequences
        Console.WriteLine("\tTab");
        Console.WriteLine("\bBackspace");
        Console.WriteLine("New\nLine");

        int x; //declaratoion
        x = 123; //initialization
        int y = 321; //declaration + initilization
        int z = x + y;
        Console.WriteLine(x + "+" + y + "=" + z);

        //Datatypes
        bool a = false;
        int b = 123;
        float c = 123.123f;
        double d = 123.123123123123123123123;
        char e = 'e';
        String f = "This is a string.";

        //Immutable data
        const double pi = 3.14159;

        //Type casting
        double g = pi;
        int h = Convert.ToInt32(g);
        Console.WriteLine(h);
        Console.WriteLine(g.GetType() + " " + h.GetType());
        string i = Convert.ToString(g);
        Console.WriteLine(i + " is type " + i.GetType());

        String FullName = "Fabian Lien";
        char FirstInitial = Convert.ToChar(FullName.Substring(0, 1));
        char LastInitial = Convert.ToChar(FullName.Substring(FullName.IndexOf(" ", StringComparison.Ordinal) + 1, 1));
        Console.WriteLine("Hello " + FullName + ". Your initials are " + FirstInitial + LastInitial);
        Console.WriteLine("\n");

        //User input
        Console.WriteLine("What is your name?");
        String userName = Console.ReadLine();
        Console.WriteLine("Hello " + userName + " , how old are you?");
        int userAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your name is " + userName + ", and you are " +  userAge + " years old.");

        //Arithmetic operators


        //Hide console debug statement using ReadKey
        Console.ReadKey();

    }
}