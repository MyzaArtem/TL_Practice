namespace TL1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var CentralPoint = new Point
            {
                X = 25,
                Y = 25
            };
            int semiMinorAxis = 10;
            int semiMajorAxis = 20;

            try
            {
                var ellipse = new Ellipse(CentralPoint, semiMinorAxis, semiMajorAxis);
                Console.WriteLine($"Half of the main axis: {ellipse.SemiMajorAxis};\n" + $"Half of the minor axis: {ellipse.SemiMinorAxis};\n" +
                                  $"The area of this ellipse: {ellipse.GetSquare()};\n" + $"Perimeter this Ellipse: {ellipse.GetPerimeter()}.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}