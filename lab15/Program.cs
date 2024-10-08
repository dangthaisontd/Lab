internal class Program
{   //nhap 1 so va tim giai thua so int
    private static void Main(string[] args)
    {
        Console.WriteLine("nhap mot so");
        int num = Convert.ToInt32(Console.ReadLine());
        int f=1;
        for (var i = 1; i <= num; i++)
        {
            f*=i;
        }
        Console.WriteLine("Giai thua la{0}",f);
        Console.ReadKey();
    }
}