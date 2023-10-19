namespace FineForOverdueBooks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of books borrowed");
        int numberOfBooks = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number of days overdue");
        int numberOfDays = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Total Fines in cents: {0}", calculateFines(numberOfBooks, numberOfDays));
    }

    static double calculateFines(int books, int days)
    {
        double totalFines;

        if (days <= 7)
        {
            totalFines = 10 * days * books;
        }
        else {
            int more = days - 7;
            totalFines = (10 * days * books) + (20*more*books);
        }
        return totalFines;
    }
}

