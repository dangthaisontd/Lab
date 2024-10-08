internal class Program
{  //giai phuong trinh bac 2 
    private static void Main(string[] args)
    {
      Console.WriteLine("Nhap gia tri a");
      float a = float.Parse(Console.ReadLine());
      Console.WriteLine("Nhap gia tri b");
      float b = float.Parse(Console.ReadLine());
      Console.WriteLine("Nhap gia tri c");
      float c= float.Parse(Console.ReadLine());
      giaiphuongtrinh(a, b, c);
    }
    private static void giaiphuongtrinh(float a,float b,float c)
    {
      if(a==0)
      {
          if(b==0) Console.WriteLine("Phuong trinh vo nghiep");
          else
          {
                  Console.WriteLine("Phuong trinh co 1 nghiem x = {0}",-c/b);
          }
      }
      else
      {
          float delta = (b*b-4*a*c);
          float x1;
          float x2;
          if(delta>0)
          {
              x1 =(float)((-b +MathF.Sqrt(delta))/(2*a));
              x2 =(float)((-b - MathF.Sqrt(delta))/(2*a));
              Console.WriteLine("Phuong trinh co 2 nghiem{0}{1}", x1, x2);
          }
          else if(delta==0)
          {
                x1=x2=(float)(-b/(2*a));
                Console.WriteLine($"Phuong trinh co nghiem kep x ={x1}");
          }
          else
          {
               Console.WriteLine("Phuong trinh vo nghiem");
          }
      }
    }
}