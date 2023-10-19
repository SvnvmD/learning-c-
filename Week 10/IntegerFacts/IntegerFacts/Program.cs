namespace IntegerFacts;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] num = new int[10];

        int nums = 5;

        Position(ref nums);
        Console.WriteLine("This is nums {0}", nums);

        // tax
        CalculateTax(2, 01);

        int x, y;
        TryingOut(out x, out y);
        Console.WriteLine("This is trying out x: {0}", x);
        Console.WriteLine("This is trying out y: {0}", y);

        //trying params
        string[] names = {"Sonam", "Dargay"};
        TryingPrams(names);

        //automatic params
        Console.WriteLine(AutoParams(10));

        PassingWholeArray(names);
        foreach (var name in names)
        {
            Console.Write(name);
        }
    }

    public static int Position(ref int nums)
    {
        nums = 6;
        Console.WriteLine("Testing method");
        return nums;
    }

    public static void CalculateTax(double amt, double rate)
    {
        double tax = amt * rate;
        Console.WriteLine("The tax amount is :{0}", tax);
    }

    private static void TryingOut(out int x, out int y)
    {
        x = Convert.ToInt32( Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
    }

    private static void TryingPrams(params string[] names)
    {
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
    }

    //automatic params
    private static double AutoParams(double x, double y = 1.5)
    {
        return x * y;
    }

    private static void PassingWholeArray(string[] names)
    {
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        for (int i = 0; i < names.Length; i++)
        {
            names[i] = "Sonam" + i;
        }
    }
}

