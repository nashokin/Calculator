using FluentValidation;

namespace Calculator.Application.Calculator.Commands
{
    public class CalculatorCommandValidator : AbstractValidator<CalculatorCommand>
    {
        public CalculatorCommandValidator()
        {
            RuleFor(v => v.Num1)
                .InclusiveBetween(float.MinValue, float.MaxValue)
                .NotNull();

            RuleFor(v => v.Action)
                .IsInEnum();

            RuleFor(v => v.Num2)
                .InclusiveBetween(float.MinValue, float.MaxValue)
                .NotNull();
        }
    }
}
