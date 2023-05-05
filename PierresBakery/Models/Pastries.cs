namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Pastries { get; set; }
    public Pastry(int count)
    {
      Pastries = count;
    }

    public int CalculatePastryTotalPrice()
    {
    int pastryOrderPrice = ((Pastries-(Pastries%4))/4)*6+(Pastries%4)*2;
    return pastryOrderPrice;
    }
  }
}