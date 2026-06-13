public class Square : Shape
{
  // Square only needs one side length because all sides are equal.
  private double _sideLength;

  // Sends color to the Shape constructor, then saves the square side length here.
  public Square(string color, double sideLength) : base(color)
  {
    _sideLength = sideLength;
  }


  // Override means "use the square version of GetArea instead of the base version."
  public override double GetArea()
  {
    return _sideLength * _sideLength;
  }

  // Updates the side length after the object is created.
  public void SetSideLength(double sideLength)
  {
    _sideLength = sideLength;
  }

}