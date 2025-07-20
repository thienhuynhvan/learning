namespace Shop;

public class Price
{
    public double ItemPrice { get; set; }
    public Currency Currency { get; set; }
    public override string ToString()
    {
        return $"{ItemPrice} {Currency}";
    }

    public Price(double price = 0.0, Currency currency=Currency.Dollar)
    {
        ItemPrice = price;
        Currency = currency;
    }

    
}