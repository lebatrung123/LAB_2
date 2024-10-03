internal class Program
{

    private static void Main(string[] args)
    {
        DateTime datetime = DateTime.Now;
        Console.WriteLine($"{datetime.Hour}{datetime.Minute}{datetime.Second}");
    }
}