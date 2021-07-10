using System;

namespace Operators
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // *Complete the 'solve' function below.
            // *
            // *The function accepts following parameters:
            // *1.DOUBLE meal_cost
            //* 2.INTEGER tip_percent
            //* 3.INTEGER tax_percent

            double mealCost = Convert.ToDouble(Console.ReadLine().Trim());

            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());


            Console.WriteLine(Solve(mealCost, tip_percent, tax_percent));
        }
        public static int Solve(double meal_cost, int tip_percent, int tax_percent)
        {
            //meal_cost = 12;
            //tip_percent = 20;
            //tax_percent = 8;

            double tip = meal_cost * tip_percent/100;

            double tax = meal_cost * tax_percent/100;

            double totalCost = meal_cost + tip + tax;

            return ((int)Math.Round(totalCost));

        }

    }
}
