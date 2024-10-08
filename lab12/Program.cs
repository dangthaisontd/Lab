//ban hay in ra mot day dao nguoc
internal class Program
{
    private static void Main(string[] args)
    {
        string str, str1="";
        int l;
        Console.WriteLine("nhap mot chuoi tu ban phim");
        str = Console.ReadLine();
        l = str.Length-1;
        for (var i = l; i>0; i--)
        {
            str1 +=str[i];
        }
        Console.WriteLine(str1);
    }
}