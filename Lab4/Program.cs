internal class Program
{
    private static void Main(string[] args)
    {
        const int Scale = 23000;
        Console.WriteLine("Nhap vao so tien do ma ban co");
        int usd = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("So tien viet ma ban co la{0}",Scale*usd);
    }
}