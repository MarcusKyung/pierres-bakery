namespace PierresBakery.Models
{
  public class Bread
  {
    public int Loafs { get; set; }
    public Bread(int quantity)
    {
      Loafs = quantity;
    }

    public int CalculateBreadTotalPrice()
    {
    int price = ((Loafs-(Loafs%3))/3)*10+(Loafs%3)*5;
    return price;
    }
  }
}