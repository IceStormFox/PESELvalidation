namespace PESELvalidation
{
    public class CloseConsole
    {
        public static void End()
        {
            Console.WriteLine("Naciśnij dowolny przycisk, aby wyjść z programu");
            Console.ReadKey();
            Environment.Exit(1);
        }
    }
}
