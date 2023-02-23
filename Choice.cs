namespace PESELvalidation
{
    class Choice
    {
        public static void ChoiceOption(long pesel)
        {
            Console.WriteLine("Czy chcesz wprowadzić następnego mieszkańca? y/n");
            string? wybor;
            wybor = Console.ReadLine();

            if (wybor == "y")
            {
                Program.i++;
                NextPerson.Next();
            }
            else
            {
                for (int l = 0; l < 10; l++)
                {
                    Program.sw.WriteLine(Program.table[l, 0]);
                    Program.sw.WriteLine(Program.table[l, 1]);
                    Program.sw.WriteLine(Program.table[l, 2]);
                }
                Program.sw.Close();
                CloseConsole.End();

            }
        }
    }
}
