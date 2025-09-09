namespace Simple_interest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Rate of interest (%): ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Time (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());

            double simpleInterest = (principal * rate * time) / 100;
            Console.WriteLine($"the simple interest:{ simpleInterest}");
        }
    }
}
