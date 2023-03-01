using System.Linq.Expressions;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            if((town == "sofia"||town == "plovdiv"|| town == "varna")&& sales >= 0)
            if (sales >= 0 && sales <= 500)
            {
                switch (town)
                {
                    case "sofia":
                        sales -= 0.05 * sales;
                            Console.WriteLine(sales); break;
                    case "varna":
                        sales -= 0.04 * sales;
                        Console.WriteLine(sales); break;
                    case "plovdiv":
                        sales -= 0.055 * sales;
                        Console.WriteLine(sales); break;

                }
            }
            else if (sales > 500 && sales <= 1000)
            {
                switch (town)
                {
                    case "sofia":
                        sales -= 0.07 * sales;
                        Console.WriteLine(sales); break;
                    case "varna":
                         sales -= 0.075 * sales;
                        Console.WriteLine(sales); ; break;
                    case "plovdiv":
                        sales -= 0.08 * sales;
                        Console.WriteLine(sales); break;
                }
            }
            else if (sales > 1000 && sales <= 10000)
            {
                switch (town)
                {
                    case "sofia":
                        sales -= 0.08 * sales;
                        Console.WriteLine(sales); break;
                    case "varna":
                        sales -= 0.010 * sales;
                        Console.WriteLine(sales); ; break;
                    case "plovdiv":
                        sales -= 0.12 * sales;
                        Console.WriteLine(sales); break;
                }
            }

            else if (sales > 10000 )
            {
                switch (town)
                {
                    case "sofia":
                        sales = 0.12 * sales;
                        Console.WriteLine(sales); break;
                    case "varna":
                        sales -= 0.13 * sales;
                        Console.WriteLine(sales); ; break;
                    case "plovdiv":
                        sales -= 0.145 * sales;
                        Console.WriteLine(sales); break;
                }
            }
        }
    }
}