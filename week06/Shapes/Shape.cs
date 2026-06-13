public class Shape
{
  // Shared color for every kind of shape.
  private string _color;

  // Base constructor sets up the part all shapes have in common.
  public Shape(string color)
  {
    _color = color;
  }

  // Returns the shape color.
  public string GetColor()
  {
    return _color;
  }

  // Changes the shape color later if needed.
  public void SetColor(string color)
  {
    _color = color;
  }

  // Meant to be replaced by each specific shape.
  // Base class gives a default value, but child classes provide the real formula.
  public virtual double GetArea()
  {
    return 0.0;
  }
}