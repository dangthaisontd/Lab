using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ban hay nhap vao 1 so");
        int so = Convert.ToInt32(Console.ReadLine());
        if(0<=so&&so<5)
        {
         switch (so)
         {
            case 1:
                Console.WriteLine("*");
                Console.WriteLine("**");
                Console.WriteLine("***");
                Console.WriteLine("****");
                Console.WriteLine("*****");
                Console.WriteLine("*******");
                break;
            case 2:
                Console.WriteLine("*******");
                Console.WriteLine("*******");
                Console.WriteLine("*******");
                Console.WriteLine("*******");
                Console.WriteLine("*******");
                Console.WriteLine("*******");
                break;
            case 3:
                Console.WriteLine("*******");
                Console.WriteLine("*******");
                Console.WriteLine("*******");
                break;
            case 4:
                Console.WriteLine("*******");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine("*******");
                break;
             case 0:
                Environment.Exit(0);
                 break;
            default:
                Console.WriteLine(" ");   
                break;
         }
         
        }
        else
        {
            Console.WriteLine("Nhap sai khoang roi");
        }
    }
}