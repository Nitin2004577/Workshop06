namespace Task02;

public delegate double DiscountStrategy(double price);

public class Discount
{
    public double FestivalDiscount(double price) =>  price - (price * 0.2);

    public double SeasonalDiscount(double price) => price - (price * 0.1);

    public double NoDiscount(double price) => price;

    public double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy) => strategy(originalPrice);

}