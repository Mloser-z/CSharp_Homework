namespace CalculatorConsole
{
    internal class Program
    {
        public static double GetResult(double first, double second, string op)
        {
            switch (op)
            {
                case "+":
                    return first + second;
                case "-": 
                    return first - second;
                case "*":
                    return first * second;
                case "/":
                    return first / second;
                default:
                    System.Console.WriteLine("Error");
                    return 0;
            }
        }
        public static void Main(string[] args)
        {
            System.Console.WriteLine("input first number:");
            double fir = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("input an operator:");
            string opr = System.Console.ReadLine();
            System.Console.WriteLine("input second number:");
            double sec = System.Convert.ToDouble(System.Console.ReadLine());
            if (opr == "/" && sec == 0)
            {
                System.Console.WriteLine("InputError!");
                return;
            }

            double result = GetResult(fir, sec, opr);
            System.Console.WriteLine("Result:" + result);
        }
    }
}