internal class Program
{   //nhap 2 so tu ban phim va tim so lon nhat
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so thu nhat");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so thu hai");
        float b = float.Parse(Console.ReadLine());
        float c = MathF.Max(a, b);
        Console.WriteLine("Gia tri lon nhat la {0}",c);
    }
}