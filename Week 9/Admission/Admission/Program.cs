namespace Admission;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Grade: ");
        double gradePoint = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Test Score: ");
        double testScore = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(AcceptOrReject(gradePoint, testScore));
    }

    static string AcceptOrReject(double gradePoint, double testScore)
    {
        const double MINGPA = 3.0;
        const double TEST1 = 60, TEST2 = 80;

        if (gradePoint >= MINGPA && testScore >= TEST1)
            return "Accept";
        else if (gradePoint <= MINGPA && testScore >= TEST2)
            return "Accept";
        else
            return "Reject";
    }
}

