namespace InputMethodDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first, second;
            InputMethod(out first, out second);

            Console.WriteLine("After InputMethod first is {0},", first);
            Console.WriteLine("and second is {0}", second);
        }

        private static void InputMethod(out int one, out int two)
        {
            one = DataEntry("first");
            two = DataEntry("second");
        }

        private static int DataEntry(string str)
        {
            return Convert.ToInt32(Console.ReadLine());

        }
    }
}