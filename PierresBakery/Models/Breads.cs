namespace PierresBakery.Models
{
  public class Bread
  {
    public int Loafs { get; set; }
    public Bread(int quantity)
    {
      Loafs = quantity;
    }
  }
}