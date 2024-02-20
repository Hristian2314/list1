namespace imena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dai imena: ");
            List<string> list = Console.ReadLine().Split().ToList();
            list.Reverse();
            Console.WriteLine(string.Join(", ", list));
        }
    }
}