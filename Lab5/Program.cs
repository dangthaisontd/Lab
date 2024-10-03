internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap diem trung binh cua sinh vien");
        float score = float.Parse(Console.ReadLine());
        if( 0<=score&&score<5)   Console.WriteLine("Yeu");
        else if( 5<=score&&score<7) Console.WriteLine("TB");
        else if(7<=score&&score<8)  Console.WriteLine("Kha");
        else if (8<=score && score<=10) Console.WriteLine("Gioi");
        else Console.WriteLine("Nhap sai gia tri diem so");
    }
}