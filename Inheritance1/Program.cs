using Inheritance1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int number = int.Parse(Console.ReadLine());
            for(int x = 1; x <= number; x++)
            {
                Console.WriteLine($"Tax payer #{x} data:");
                Console.Write("Individual or Company (i/c): ");
                char question = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(question == 'i')
                {
                    Console.Write("Health Expenditures : ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            double sum = 0.0;

            Console.WriteLine("\nTAXES PAID: ");
            foreach(TaxPayer txp in list)
            {
                Console.WriteLine(txp.Name + " - $ " + txp.TaxPaid().ToString("F2", CultureInfo.InvariantCulture));
                sum += txp.TaxPaid();
            }

            Console.WriteLine("\nTOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
