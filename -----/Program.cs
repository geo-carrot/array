namespace _____
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[25];

            Random rnd = new Random();

            for (int y = 0; y < array.Length; y++)
            {
               array[y] = rnd.Next(150);
                Console.WriteLine(array[y]);
            }
            int sum = array.Sum();
            Console.WriteLine("Сумма = " + sum);
            


        }
    }
}