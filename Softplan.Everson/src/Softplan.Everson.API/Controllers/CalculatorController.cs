using Microsoft.AspNetCore.Mvc;
using Softplan.Everson.Domain.Services.Interfaces;

namespace Softplan.Everson.API.Controllers
{
    [Route("calculadora")]
    public sealed class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            this.calculatorService = calculatorService;
        }

        [HttpGet]
        [Route("taxajuros")]
        public decimal GetInterestRate()
        {
            return calculatorService.GetInterestRate();
        }

        [HttpGet]
        [Route("calculajuros")]
        public decimal CalculateInterest(decimal valorInicial, int meses)
        {
            return calculatorService.CalculateInterest(valorInicial, meses);
        }
    }
}
