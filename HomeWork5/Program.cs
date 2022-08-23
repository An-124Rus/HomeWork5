internal class Program
{
    private static void Main(string[] args)
    {
        string name = "Елисей";
        string surname = "Новичков";
        string newSurname;

        Console.WriteLine(name + " " + surname);
        Console.ReadKey();
        
        newSurname = name;
        name = surname;
        surname = newSurname;

        Console.WriteLine(name + " " + surname);
    }
}