namespace PESELvalidation
{
    class FileWriter
    {
        public static void Table(long pesel)
        {
            int j;
            for (j = Program.i; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    if (Program.table[k, 2] == Convert.ToString(pesel))
                    {
                        Console.WriteLine("k = {0}", k);
                        Console.WriteLine("PESEL został powtórzony! Nadpisywanie danych...");
                        if (!String.IsNullOrEmpty(Program.name)) { Program.table[k, 0] = Program.name; }
                        else { Program.table[k, 0] = "Brak"; }
                        if (!String.IsNullOrEmpty(Program.surname)) { Program.table[k, 0] = Program.surname; }
                        else { Program.table[k, 1] = "Brak"; }
                        Choice.ChoiceOption(pesel);
                    }
                    if (Program.table[k, 2] != Convert.ToString(pesel))
                    {
                        if (!String.IsNullOrEmpty(Program.name)) { Program.table[k, 0] = Program.name; }
                        else { Program.table[j, 0] = "Brak"; }
                        if (!String.IsNullOrEmpty(Program.surname)) { Program.table[k, 0] = Program.surname; }
                        else { Program.table[j, 1] = "Brak"; }
                        Program.table[j, 2] = Convert.ToString(pesel);
                        Choice.ChoiceOption(pesel);
                    }
                }
            }
        }
    }
}
