using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo.Classes
{
    public class Cuboid : Polygon, I2DShape, I3DShape
    {
        public Cuboid(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return 2 * (Width * Height) + Height * Length + Height * Width;
        }

        public double Perimeter()
        {
            return 4 * (Length + Width + Height);
        }

        public double Volume()
        {
            return Length * Width * Height;
        }
    }
}
