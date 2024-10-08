
//bai tap tinh tong cac so chan trong khoang

internal class Program
{
    private static void Main(string[] args)
    { 
    int n,sum=0;
    Console.WriteLine("Nhap so bat ky");
    n = Convert.ToInt32(Console.ReadLine());
     for (var i = 0; i <= n; i++)
     {
        if(i%2 == 0)
        {
           sum += i; 
        }
     }
     Console.WriteLine("Tong So chan{0}",sum);
    }
}