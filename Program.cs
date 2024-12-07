namespace ConsoleApp106
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Temprerature In Celsuis");
            double celsuis=Convert.ToDouble(Console.ReadLine());
            Double fahrenheit = (celsuis * 9 / 5) + 32;
            Console.WriteLine("celsuis " + celsuis);
            Console.WriteLine("fahrenheit " + fahrenheit);

        }
    }
}