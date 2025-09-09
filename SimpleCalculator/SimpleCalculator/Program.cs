namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the input1");
            double input1 = Convert.ToDouble((Console.ReadLine()));
            Console.WriteLine("enter the input2");
            double input2 = Convert.ToDouble((Console.ReadLine()));
            Console.WriteLine("enter the operator(+,-,*,/)");
            char op = Console.ReadLine()[0];

            double result;

            switch(op)
            {
                case '+':
                    result = input1 + input2;
                    Console.WriteLine($"the sum is: {result}");
                    break;
                case '-':
                    result=input1 - input2;
                    Console.WriteLine($"the difference is: {result}");
                    break;
                case '*':
                    result = input1 * input2;
                    Console.WriteLine($"the product is: {result}");
                    break;
                case '/':
                    if (input2 == 0)
                    {
                        Console.WriteLine("invalid input input2 should not be 0");
                    }
                    else
                    {
                        result = input1 / input2;
                        Console.WriteLine($"the difference is: {result}");
                        
                    }
                    break;

                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }
    }
}
