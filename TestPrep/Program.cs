namespace TestPrep;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string[] names = new string[] { "Sonam", "Dargay" };
        ChangeArray(names);
        Console.WriteLine("{0}, {1}", names[0], names[1]);

        ChangeParams(3);

        int x = 1;
        int y = 2;
        Console.WriteLine("Before: X: {0} and Y: {1}", x, y);
        SwapNumbers(ref x, ref y);
        Console.WriteLine("After: X: {0} and Y: {1}", x, y);

        double a, b;
        Console.WriteLine(Area(out a, out b));

    }

    private static void ChangeArray(params string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = "Sonam ";
        }
    }

    private static void ChangeParams(int x, int y = 0)
    {
        Console.WriteLine(x*y);
    }

    private static void SwapNumbers(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    private static double Area(out double x, out double y)
    {
        x = Convert.ToDouble(Console.ReadLine());
        y = Convert.ToDouble(Console.ReadLine());
        return x * y;
    }

}

