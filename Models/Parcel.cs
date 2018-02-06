namespace ShippingCalculator.Models
{
  public class Parcel
  {
    private int _length;
    private int _width;
    private int _height;
    private int _weight;

    public int GetLength()
    {

      return _length;
    }

    public void SetLength(string newLength)
    {
      _length = int.Parse(newLength);
    }

    public int GetWidth()
    {
      return _width;
    }

    public void SetWidth(string newWidth)
    {
      _width = int.Parse(newWidth);
    }

    public int GetHeight()
    {
      return _height;
    }

    public void SetHeight(string newHeight)
    {
      _height = int.Parse(newHeight);
    }

    public int GetWeight()
    {
      return _weight;
    }

    public void SetWeight(string newWeight)
    {
      _weight = int.Parse(newWeight);
    }

    public int Volume()
    {
      return _width * _height * _length;
    }

    public double GetPrice()
    {
      return (_weight * 0.2) + (Volume() * 0.05);
    }

  }
}
