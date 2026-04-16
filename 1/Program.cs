internal class Program
{
    private static void Main(string[] args)
    {
        int age = Convert.ToInt32(Console.ReadLine());
        if (age > 20)
        {
            Console.WriteLine("You are an adult.");

        }
        else
        {
            Console.WriteLine("You are a minor.");
        }
    }
}