namespace DemoJobs;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Wash ", 3.5, 45);
        Job job2 = new Job("Wash ", 3.5, 19);
        job1.Display();
        job2.ChangePayRate(19);
        job2.Display();
    }
}

class Job
{
    private string descriptor;
    private double hours;
    private double rate;
    private double total;


    public Job(string des, double hrs, double rte)
    {
        descriptor = des;
        hours = hrs;
        rate = rte;
    }

    public string Descriptor {
        get { return descriptor; }
        set { descriptor = value; }
    }

    public double Hours {
        get { return hours; }
        set { hours = value; }
    }

    public double PerHourRate {
        get { return rate; }
        set { rate = value; }
    }

    // private double TotalFee;

    public void Display()
    {
        CalculateTotal();
        Console.WriteLine("{0}, Hours {1}, Rate {2}, Total Fee {3}", descriptor, hours, rate, total);
    }


    public void CalculateTotal() {
        total = hours * rate;
    }


    public void ChangePayRate(double newRate)
    {
        if (rate < 20)
        {
            rate = newRate;
        }
    }
}

