namespace ConvertMilesToKilometers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter miles: ");
        double miles = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("{0} miles equals {1} kilometers.", miles, milesInKilometers(miles));
    }

    static double milesInKilometers(double miles)
    {
        const double MILES_TO_KM = 1.60934;
        return miles * MILES_TO_KM;
    }
}

