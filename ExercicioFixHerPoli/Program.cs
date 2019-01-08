using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioFixHerPoli.Entities;

namespace ExercicioFixHerPoli
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> Payers = new List<Payer>();

            int qtdPayers;
            double sum = 0;

            Console.Write("Enter the number of tax payers: ");
            qtdPayers = int.Parse(Console.ReadLine());

            for (int i =0; i<qtdPayers; i++)
            {
                char typePayer;
                string name;
                double anualIncame;

                Console.WriteLine("Tax payer #" + (i + 1) + " data:");
                Console.Write("Individual or company (i/c)?");
                typePayer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Anual income: ");
                anualIncame = double.Parse(Console.ReadLine());

                if (typePayer == 'i')
                {
                    double healthExp;

                    Console.Write("Health expenditures: ");
                    healthExp = double.Parse(Console.ReadLine());

                    Payers.Add(new Individual(name, anualIncame, healthExp));

                    Console.WriteLine();
                }
                else
                {
                    int nEmployees;

                    Console.Write("Number of employees: ");
                    nEmployees = int.Parse(Console.ReadLine());

                    Payers.Add(new Company(name, anualIncame, nEmployees));

                    Console.WriteLine();
                }
            }

            Console.WriteLine("TAXES PAID:");

            foreach(Payer payer in Payers)
            {
                Console.WriteLine(payer.Name + ": $" + payer.Taxes().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine();            

            foreach(Payer payer in Payers)
            {
                sum += payer.Taxes();
            }

            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
