using _08_inheritance;

namespace _c_sharp_
{
        class Program
        {
            public static void Main(string[] args)
            {
                Triangle triangle = new Triangle(10);
                Square square = new Square(10);
                Romb romb= new Romb(10);
                Rectangle rectangle = new Rectangle(10,2,2,2);
                Trapezoid trapezoid = new Trapezoid();
                Circle circle = new Circle(22);
                Ellipse ellipse = new Ellipse(12);
                CompositFigure figure = new CompositFigure(triangle, square, romb, rectangle, trapezoid, circle, ellipse);

            
            }
    }
}