﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap mot so tu ban phim");
        int so = int.Parse(Console.ReadLine());
       switch (so)
       {
        case 2:
            Console.WriteLine("Thu 2");
            break;
        case 3:
            Console.WriteLine("Thu 3");
            break;
        case 4:
            Console.WriteLine("Thu 4");
            break;
        case 5:
            Console.WriteLine("Thu 5");
            break;
        case 6:
            Console.WriteLine("Thu 6");
            break;
        case 7:
            Console.WriteLine("Thu 7");
            break; 
        case 8:
            Console.WriteLine("CN");
            break;  
        default:
            Console.WriteLine("So vua nhap khong phai nam trong khoang can nhap");
            break;
       }         
    }
}