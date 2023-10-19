namespace PaintingEstimate;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Enter Length");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Width");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Estimated Price to paint the room: {0}",
            estimatePrice(x, y).ToString("C"));

    }

    private static int estimatePrice(int length, int width)
    {
        int sqFootPrice = 6;
        int ceiling = 9;
        int totalPrice = sqFootPrice * ((2 * ceiling * length) + (2 * ceiling * width));
        return totalPrice;
    }

}

