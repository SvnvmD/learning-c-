namespace Question5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 5 solution");
            // With only one input
            TwoParamMethod("Star Wars");

            // with two params
            TwoParamMethod("Titanic", 160);
        }

        static void TwoParamMethod(string name, int time = 90)
        {
            Console.WriteLine("Name: {0}, Time: {1}", name, time);
        }
    }
}