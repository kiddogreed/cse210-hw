public class Circle : Shape
{
  // Circle needs a radius to calculate its area.
  private double _radius;

  // Color is handled by the parent Shape class, and the radius is stored here.
  public Circle(string color, double radius) : base(color)
  {
    _radius = radius;
  }

  // Circle area uses pi times radius squared.
  public override double GetArea()
  {
    return System.Math.PI * _radius * _radius;
  }
}