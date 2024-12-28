namespace ConsoleApp.ClassesDemo.Classes
{
    public class Square : Polygon
    {
        public Square(double width)
        {
            Width = width;
        }
        public override double Area()
        {
            return Width * Width;
        }
    }
}
