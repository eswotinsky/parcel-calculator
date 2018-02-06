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

    public void SetLength(int newLength)
    {
      _length = newLength;
    }

    public int GetWidth()
    {
      return _width;
    }

    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }

    public int GetHeight()
    {
      return _height;
    }

    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }

    public int GetWeight()
    {
      return _weight;
    }

    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }

    public int Volume()
    {
      return _width * _height * _length;
    }

    public int CostToShip()
    {
      return 
    }


  }
}
