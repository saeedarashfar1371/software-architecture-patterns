namespace OnlineStore.Application.Services;

public interface ITaxCalculator
{
    decimal Calculate(decimal price);
}

public class TaxCalculator: ITaxCalculator
{
    public decimal Calculate(decimal price)
    {
        return price * 0.09m;
    }
}
