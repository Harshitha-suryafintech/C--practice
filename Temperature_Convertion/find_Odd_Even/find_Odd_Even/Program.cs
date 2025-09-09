namespace find_Odd_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = (Console.Read());

            if(num%2==0)
            {
                Console.WriteLine("the given number is even");
            }
            else
            {
                Console.WriteLine("its odd number");
            }
        }
    }
}
