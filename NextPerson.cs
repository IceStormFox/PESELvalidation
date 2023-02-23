namespace PESELvalidation
{
    class NextPerson
    {
        public static void Next()
        {
            try
            {
                Console.WriteLine("Imię: ");
                string? name = Console.ReadLine();
                Program.name = name;
                Console.WriteLine("Nazwisko: ");
                string? surname = Console.ReadLine();
                Program.surname = surname;
                Console.Write("PESEL: ");
                string? sPesel = "0";
                while (sPesel.Length != 11 && sPesel.All(Char.IsDigit) == false)
                {
                    Console.WriteLine("PESEL powinien zawierać 11 cyfr");
                }
                PESEL.Validation(long.Parse(sPesel));
            }
            catch (Exception)
            {
                Next();
            }
        }
    }
}
