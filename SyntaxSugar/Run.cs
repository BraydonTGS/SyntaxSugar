using System;
using static System.Console;
namespace SyntaxSugar
{
    public class Run
    {
        public static void Withdrawl(double num1)
        {
            double balance = 500.00;
            var results = (balance - num1 < 0) ? $"You don't have enough funds. Total Funds: {balance}" : $"Withdrawl Complete, Balance Remaining: {balance - num1}";
            WriteLine(results);
            ReadKey();
        }
    }
}
