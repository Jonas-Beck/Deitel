namespace Ex_0706
{
    internal class Program_0706
    {
        static void Main(string[] args)
        {
            Console.Write("Write the radius of sphere: ");
            double answer = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Volume of the sphere: {SphereVolume(answer)}");
        }

        static double SphereVolume(double radius) => (4.0 / 0.3) * Math.PI * Math.Pow(radius, 3);
    }
}