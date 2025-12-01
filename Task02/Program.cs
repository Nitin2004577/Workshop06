using Task02;


public class Program
{
    public static void Main()
    {
        // Calculate calc;
        //
        // Arithmetic arth = new Arithmetic();
        //
        // calc = arth.Add;
        // Console.WriteLine(calc(1, 2));
        //
        // calc = arth.Subtract;
        // Console.WriteLine(calc(1, 2));

        Discount discount = new Discount();
        Console.WriteLine($"Festival Discount: {discount.CalculateFinalPrice(2500, discount.FestivalDiscount)}");

      
      //for Seasonal Discount
      Console.WriteLine($"Seasonal Discount: {discount.CalculateFinalPrice(2500, discount.SeasonalDiscount)}");

      
      //No discount
      Console.WriteLine($"No Discount: {discount.CalculateFinalPrice(2500, discount.NoDiscount)}");
      
        //2.3 
        Console.WriteLine($"30% Discount: {discount.CalculateFinalPrice(2500, price => price * 0.3 )}");
    }
}