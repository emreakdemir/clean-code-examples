using CleanCode;

namespace BadPractice
{
    public class AreaCalculator
    {
        public double Calculate(object shape)
        {
            if (shape is Circle circle)
            {
                return Math.PI * Math.Pow(circle.Radius, 2);
            }
            if (shape is Rectangle rectangle)
            {
                return rectangle.Width * rectangle.Height;
            }

            // Yeni bir şekil eklemek zor ve risklidir.
            return 0;
        }
    }
}

namespace CleanCode
{
    public interface IShape
    {
        double Area();
    }

    public class AreaCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.Area();
        }
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return Width * Height;
        }
    }
}