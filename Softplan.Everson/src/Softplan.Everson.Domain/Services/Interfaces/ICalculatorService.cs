namespace Softplan.Everson.Domain.Services.Interfaces
{
    public interface ICalculatorService
    {
        decimal GetInterestRate();

        decimal CalculateInterest(decimal startValue, int months);
    }
}
