namespace Parcels.Objects {
  public class ParcelVariables
  {
    private int _height;
    private int _width;
    private int _depth;
    private int _weight;
    private int _cost;


    public int GetHeight()
    {
      return _height;
    }
    public void SetHeight(int height)
    {
      _height = height;
    }
    public int GetWidth()
    {
      return _width;
    }
    public void SetWidth(int width)
    {
      _width = width;
    }
    public int GetDepth()
    {
      return _depth;
    }
    public void SetDepth(int depth)
    {
      _depth = depth;
    }
    public int GetWeight()
    {
      return _weight;
    }
    public void SetWeight(int weight)
    {
      _weight = weight;
    }
    public int GetCost()
    {
      return _cost;
    }
    public void SetCost(int cost)
    {
      _cost = cost;
    }

    public int Volume(int height, int width, int depth)
    {
      return height * width * depth;
    }

    public int CalculateCost(int weight, int dimension)
    {
      return dimension * weight;
    }
  }
}
