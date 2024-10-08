internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Nhap mot so nguyen");
        int so = int.Parse(Console.ReadLine());
        if(0<=so&&so<999)
        {
           if(0<=so&&so<10)
           {
            WriteNumber(so);
           }
           else if(10<=so&&so<99)
           {
             int chuc = so/10;
             int donvi = so%10;
             WriteNumber(chuc);
             WriteNumber(donvi);
           }
           else
           {
             int tram = so/100;
             int temp = so%100;
             int chuc = temp / 10;
             int donvi = temp%10;
             //
             WriteNumber(tram);
             WriteNumber(chuc);
             WriteNumber(donvi);
           }
        }
        else
        {
            Console.WriteLine("Nhap sai gia tri chay lai chuong trinh");
        }
    }
    private static void WriteNumber(int so)
    {
            if(so==0) Console.WriteLine("Khong");
             else if (so==1) Console.WriteLine("mot");
             else if (so==2) Console.WriteLine("hai");
             else if (so==3) Console.WriteLine("ba");
             else if (so==4) Console.WriteLine("bon");
             else if (so==5) Console.WriteLine("nam");
             else if (so==6) Console.WriteLine("sau");
             else if (so==7) Console.WriteLine("bay");
             else if (so==8) Console.WriteLine("tam");
             else  Console.WriteLine("chin");
    }
}