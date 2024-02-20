namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list.Sort();
            int minNumber = list[0];
            int maxNumber = list[list.Count - 1];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == minNumber || list[i] == maxNumber)
                {
                    Console.Write(list[i] + " ");
                }
            }
        }
    }
}