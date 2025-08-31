using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zum Taschenrechner!");
            Console.Write("Bitte erste Zahl eingeben: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitte zweite Zahl eingeben: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wähle eine Operation:");
            Console.WriteLine("1 = Addition");
            Console.WriteLine("2 = Subtraktion");
            Console.WriteLine("3 = Multiplikation");
            Console.WriteLine("4 = Division");
            Console.Write("Deine Wahl: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            switch (choice)
            {
                case 1:
                    result = MyMath.calc_addition(a, b);
                    break;
                case 2:
                    result = MyMath.calc_subtraktion(a, b);
                    break;
                case 3:
                    result = MyMath.calc_multiplikation(a, b);
                    break;
                case 4:
                    result = MyMath.calc_division(a, b);
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe!");
                    return;
            }

            Console.WriteLine($"Das Ergebnis ist: {result}");
        }
    }
}
