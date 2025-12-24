using System;
struct StockPrice
{
    public StockPrice()
    {}
  public required string symbol;
  public  double price;
  
}

// class Trade
// {
//   public int trade_id;
//    public required  string symbol;
//   public  int quantity;
// }

class Portfolio
{
    public string Name;
    //Equals(object)
    public override bool Equals(object obj)
    {
        Portfolio p = obj as Portfolio;
        return p!=null && p.Name == Name;
    }
     public override int GetHashCode()
    {
        // same as equals it give true false and hashcode gives integer value
        return Name.GetHashCode();
    }
}
class Trade { }

class EquityTrade : Trade { }

