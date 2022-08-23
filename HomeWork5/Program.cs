internal class Program
{
    private static void Main(string[] args)
    {
        string name = "Alex";
        string surname = "Ivanov";
        string newName;
        string newSurname;

        Console.WriteLine(name + surname);
        Console.ReadKey();

        newName = surname;
        newSurname = name;

        Console.Write(newName + newSurname);
    }
}