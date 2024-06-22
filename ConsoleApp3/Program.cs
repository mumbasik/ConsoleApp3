namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] perimetr = new int[6];
            int summa = 0;
            for(int i = 1; i < perimetr.Length; i++)
            {
                Console.WriteLine($"Enter the  side - {i}");
                perimetr[i] = Convert.ToInt32(Console.ReadLine());
                summa += perimetr[i];
            }
            Console.WriteLine($"Result - {summa}");
            Console.WriteLine($"Result - {perimetr.Sum()}");


            int[] months = new int[13];
            int min = int.MaxValue;
            int minmonth = 0;
            int max = 0;
            int maxmonth = 0;
            for(int i = 1; i < months.Length ; i++)
            {
                Console.WriteLine($"Enter the  sallary of month - {i}");
                months[i] = Convert.ToInt32(Console.ReadLine());
                if (months[i] < min)
                {
                    minmonth = i;
                    min = months[i];
                }
                else if (months[i] > max)
                {
                    maxmonth = i;
                    max = months[i];
                }
                
            }
            Console.WriteLine($"The lowest month is  - {minmonth} = {min}");
            Console.WriteLine($"The maximum month is  - {maxmonth} = {max}");
            int[] ran = new int[10];
            Random random = new Random();
            for(int i = 0; i < ran.Length; i++)
            {
                ran[i] = random.Next(-9, 10);
            }
            int summ = 0;
            for(int i = 0; i < ran.Length; i++)
            {
                if (ran[i] % 2 != 0) {
                    summ += ran[i];
                }
            }
            int summindex = 0;
            for(int i = 0; i < ran.Length; i++)
            {
                summindex += ran[i];
            }
            Console.WriteLine($"Array: [{string.Join(", ", ran)}]");
            Console.WriteLine($"Summa elements - {summ}");
            Console.WriteLine($"Summa indexes - {summindex}");
        }
    }
}
