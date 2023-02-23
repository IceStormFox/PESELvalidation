using PESELvalidation;

public class Program
{
    public static string? name, surname;
    public static string[,] table = new string[10, 3];
    public static int i;
    public static StreamWriter? sw;
    public static string path = @"ZbiorMieszkancow.txt";
    static void Main(string[] args)
    {
        i = 0;

        Console.WriteLine("Witaj w programie tworzącym listę mieszkańców!");

        sw = File.CreateText(path);
        Console.WriteLine("Plik został utworzony!");

        Console.WriteLine("Wprowadź dane.");

        NextPerson.Next();
    }
}