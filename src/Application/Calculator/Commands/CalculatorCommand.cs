using Calculator.Application.Common.Exceptions;
using Calculator.Application.Common.Interfaces;
using Calculator.Domain.Entities;
using Calculator.Domain.Enums;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator.Application.Calculator.Commands
{
    public class CalculatorCommand : IRequest<CalculatorResult>
    {
        public float Num1 { get; set; }

        public CalculatorAction Action { get; set; }

        public float Num2 { get; set; }
    }

    public class CalculatorCommandHandler : IRequestHandler<CalculatorCommand, CalculatorResult>
    {
        private readonly IApplicationDbContext _context;

        public CalculatorCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CalculatorResult> Handle(CalculatorCommand request, CancellationToken cancellationToken)
        {
            float result = 0;

            switch (request.Action)
            {
                case CalculatorAction.Add:
                    result = request.Num1 + request.Num2;
                    break;
                case CalculatorAction.Subtract:
                    result = request.Num1 - request.Num2;
                    break;
                case CalculatorAction.Multiply:
                    result = request.Num1 * request.Num2;
                    break;
                case CalculatorAction.Divide:
                    result = request.Num1 / (request.Num2 == 0 ? throw new DivisionByZeroException("Division by zero is not allowed.") : request.Num2);
                    break;
                default:
                    throw new NotFoundException("Calculator action not found.");
            }

            var response = new CalculatorResult
            {
                Id = 1,
                Num1 = request.Num1,
                Action = request.Action,
                Num2 = request.Num2,
                Result = result,
                CreatedBy = "nashokin",
                Created = DateTime.Now
            };

            return await Task.FromResult(response);
        }
    }
}
