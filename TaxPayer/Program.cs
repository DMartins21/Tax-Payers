using System.Globalization;
using System.Collections.Generic;
using TaxPayer.Entities;

namespace TaxPayer
{
    internal class Program
    {
      static void Main(string[] args)
        {
            List<Payers> list = new();

            Console.Write("Enter the number of Tax Payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax Payer number {i} data:");
                Console.Write("Individual or Company(c/i)? ");
                char type = Char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = System.Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'c')
                {
                    Console.Write("Number of Employees: ");
                    int employees = int.Parse(System.Console.ReadLine());
                    list.Add(new Company(name, annualIncome, employees));
                }
                else
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, annualIncome, healthExpenditures));
                }
            }

            double total = 0.0;
            Console.WriteLine("\n Taxes Paid:");
            foreach (Payers tp in list)
            {
                Console.WriteLine(tp.Name + ": U$" + tp.Tax().ToString("F2", CultureInfo.InvariantCulture));
                total += tp.Tax();
            }
            Console.WriteLine("\nTotal Tazes: " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}