namespace IMS2025_2FI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int a = 2;
            int b = 3;
            int summe = MyMath.Addieren(a, b);
            Console.WriteLine($"Summe von {a} und {b} = {summe}"); 
        }
    }
}
