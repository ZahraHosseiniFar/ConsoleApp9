using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter two number : ");
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int num1 = Convert.ToInt32(a);
        int num2 = Convert.ToInt32(b);
        Console.WriteLine("BMM : " + BMM(num1, num2));
        Console.WriteLine("KMM : " + KMM(num1, num2));
        Console.ReadKey();
    }
    private static int BMM(int num1, int num2)
    {
        int f;
        while (num2 != 0)
        {
            f = num1 % num2;
            num1 = num2;
            num2 = f;
        }
        return num1;
    }
    private static int KMM(int num1, int num2)
    {
        int z1 = num1;
        int z2 = num2;
        int f;
        while (num2 != 0)
        {
            f = num1 % num2;
            num1 = num2;
            num2 = f;
        }
        return (z1 * z2) / num1;
    }
}//برنامه ای بنویسید ک دو عدد بگیرد و بمم و کمم را نشان دهد

