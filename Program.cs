internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("the value of x:");
        int x = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("the value of y:");
        int y = Convert.ToInt32(Console.ReadLine());

        int C = x * y;
        Console.WriteLine(C);

        if (C > 50)
        {
            Console.WriteLine("pass");
        }
        else {
            Console.WriteLine("fail");
        }
    }
}