// This class represents a fraction, like 1/2 or 3/4.
public class Fraction
{
  // Top number (numerator)
  private int _top;
  // Bottom number (denominator)
  private int _bottom;

  // Blank fraction, like 0/0. Not usually used.
  public Fraction()
  {
    // Nothing happens here yet.
  }

  // Makes fraction from whole number, like 5 becomes 5/1.
  public Fraction(int wholeNumber)
  {
    _top = wholeNumber;
    _bottom = 1;
  }

  // Makes fraction from two numbers, like 3 and 4 becomes 3/4.
  public Fraction(int top, int bottom)
  {
    _top = top;
    _bottom = bottom;
  }

  // Get top number (numerator)
  public int getTop()
  {
    return _top;
  }

  // Set top number (numerator)
  public void setTop(int top)
  {
    _top = top;
  }

  // Get bottom number (denominator)
  public int getBottom()
  {
    return _bottom;
  }

  // Set bottom number (denominator)
  public void setBottom(int bottom)
  {
    _bottom = bottom;
  }

  // Show fraction as string, like "3/4"
  public string GetFractionString()
  {
    return $"{_top}/{_bottom}";
  }

  // Get decimal value, like 0.75 for 3/4
  public double GetDecimalValue()
  {
    return (double)_top / _bottom;
  }

}