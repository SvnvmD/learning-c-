namespace Reverse3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInt    = 10;
            int middleint   = 20;
            int lastInt     = 30;

            Console.WriteLine("firstInt = {0}, middleint= {1} , lastInt={2}", 
                firstInt, middleint,lastInt);
            //Call by reference
            ReverseNumbers(ref firstInt, ref middleint, ref lastInt);

            Console.WriteLine("firstInt: {0}, middleint: {1}, lastInt: {2}", 
                firstInt, middleint, lastInt);

        }

        static void ReverseNumbers(ref int a, ref int b, ref int c)
        {
            int temp = a;
            a = c;
            c = temp;
        }
    }
}