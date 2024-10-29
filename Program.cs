namespace Set1Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul numar: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("introduceti al doilea numar: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Valorile initiale sunt a:{a}, b:{b}");
            double temp;

            temp = a;
            a = b; 
            b = temp;
            Console.WriteLine($"Valorile dupa swap sunt a:{a}, b:{b}");

        }
    }
}
