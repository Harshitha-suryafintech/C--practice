namespace Temperature_Convertion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the temperature");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the scale type (if it is celcius press C if Fahrenheit press F)");
            char type = char.ToUpper(Console.ReadLine()[0]);
            if (type == 'C')
            {
                double fahrenheit = (temp * 9 / 5) + 32;
                Console.WriteLine($"Converted temperature : {fahrenheit} F");
            }
            else if (type == 'F')
            {
                double Celcius = (temp - 32) * 5 / 9;
                Console.WriteLine($"Converted temperature : {Celcius} C");
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
