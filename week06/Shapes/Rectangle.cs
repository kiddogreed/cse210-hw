public class Rectangle : Shape
{
  // Rectangle needs a width and a height.
  private double _width;
  private double _height;

  // Base constructor stores the shared color, and this constructor stores rectangle-only data.
  public Rectangle(string color, double width, double height) : base(color)
  {
    _width = width;
    _height = height;
  }

  // Rectangle area is width times height.
  public override double GetArea()
  {
    return _width * _height;
  }
}