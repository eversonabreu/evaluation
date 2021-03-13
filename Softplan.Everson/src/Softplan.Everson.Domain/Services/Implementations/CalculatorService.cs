using Microsoft.Extensions.Logging;
using Softplan.Everson.Domain.Services.Interfaces;
using System;

namespace Softplan.Everson.Domain.Services.Implementations
{
    public sealed class CalculatorService : ICalculatorService
    {
        private readonly ILogger<CalculatorService> logger;

        public CalculatorService(ILogger<CalculatorService> logger)
        {
            this.logger = logger;
        }

        public decimal GetInterestRate()
        {
            const decimal interestRate = 0.01m;
            return interestRate;
        }

        public decimal CalculateInterest(decimal startValue, int months)
        {
            try
            {
                if (months < 1)
                {
                    throw new ArgumentException($"Invalid count months. Parameter: '{nameof(months)}'");
                }

                double interestRate = (double)GetInterestRate();
                double startValueDouble = (double)startValue;
                double endValueDouble = startValueDouble * Math.Pow(1d + interestRate, months);
                decimal endValue = (decimal)endValueDouble;
                endValue = Math.Truncate(100 * endValue) / 100;
                return endValue;
            }
            catch (Exception exc)
            {
                logger?.LogError(exc, exc.Message);
                throw;
            }
        }
    }
}
