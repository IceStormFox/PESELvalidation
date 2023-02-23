namespace PESELvalidation
{
    public class PESEL
    {
        public static void Validation(long pesel)
        {
            long[] index = new long[11];
            long[] constNumers = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            long s = 0;
            int j = 0;
            while (j < index.Length)
            {
                index[j] = pesel % 10;
                pesel %= 10;
                j++;
            }

            j = 0;
            while (j < 10)
            {
                s += index[j] * constNumers[j];
            }

            long m = s % 10;

            if ((m == 0 && m == index[10]) || (m != 0 && 10 - m == index[10]))
            {
                FileWriter.Table(pesel);
            }
            else 
            {
                Console.WriteLine("Numer PESEL jest niepoprawny!");
                Console.WriteLine("Proszę wprowadzić poprawne dane!");
                NextPerson.Next();
            }
        }
    }
}
