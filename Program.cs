namespace Radius
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Radius Calculator");
            // Prompt for radius
            Console.WriteLine("Enter radius:");
            int radius = int.Parse(Console.ReadLine());
            int diameter = 2 * radius;
            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            Console.WriteLine("Diameter: " + diameter);
            Console.WriteLine("Circumference: " + Math.Round(circumference, 2));
            Console.WriteLine("Area: " + Math.Round(area, 2));
        }
    }
}
