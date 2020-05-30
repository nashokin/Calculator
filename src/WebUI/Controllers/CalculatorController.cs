using Calculator.Application.Calculator.Commands;
using Calculator.Domain.Entities;
using Calculator.WebUI.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Calc.WebUI.Controllers
{
    public class CalculatorController : ApiController
    {
        [HttpPost()]
        public async Task<ActionResult<CalculatorResult>> Calculate(CalculatorCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
