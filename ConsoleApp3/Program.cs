namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете списък от цели числа, разделени с интервали:");
            string input = Console.ReadLine();

            string[] numbersAsString = input.Split(' ');
            List<int> numbers = new List<int>();

            foreach (string num in numbersAsString)
            {
                numbers.Add(int.Parse(num));
            }

            int currentCount = 1;
            int maxCount = 1;
            int maxNumber = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        maxNumber = numbers[i];
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }

            Console.WriteLine($"Най-дългата поредица е от {maxCount} елемента и се състои от числото {maxNumber}.");
        }
    }
}