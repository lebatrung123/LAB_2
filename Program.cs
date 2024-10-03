internal class Program
{

    private static void Main(string[] args)
    {
        // DateTime datetime = DateTime.Now;
        //Console.WriteLine($"{datetime.Hour}{datetime.Minute}{datetime.Second}");
        Console.WriteLine("Nhâp chieu rong hinh chu nhat");
        float w = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhâp chieu dai hinh chu nhat");
        float d = float.Parse(Console.ReadLine());

        Console.WriteLine("Chu vi hcn la: {0}", (w + d) * 2);

        Console.WriteLine($"Dien tich hcn la: {w * d}");


    }
}