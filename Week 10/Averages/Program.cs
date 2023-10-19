namespace Averages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate average: ");
            int[] arr = { 10, 20, 30 };
            CalcAverage(arr);
        }

        static void CalcAverage(params int[] args)
        {
            int sum = 0;

            /*for (int i = 0;i < args.Length; i++)
            {
                sum+= args[i];
            }*/

            foreach (int arg in args)
            {
                sum += arg;
            }

            Console.WriteLine(sum);
        } 
    }
}