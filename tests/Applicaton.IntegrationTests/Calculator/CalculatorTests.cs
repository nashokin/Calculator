using Calculator.Application.Calculator.Commands;
using Calculator.Application.Common.Exceptions;
using Calculator.Domain.Entities;
using Calculator.Domain.Enums;
using FluentAssertions;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Calculator.Application.IntegrationTests.Calculator
{
    using static Testing;

    public class CalculatorTests : TestBase
    {
        [Test]
        public async Task ShouldReturnValue()
        {
            var command = new CalculatorCommand()
            {
                Num1 = 10.0F,
                Action = CalculatorAction.Add,
                Num2 = 30.0F
            };

            var response = await SendAsync(command);

            response.Should().NotBeNull();
            response.Should().BeOfType(typeof(CalculatorResult));
            response.Result.Should().Be(40);
        }

        [Test]
        public void ShouldThrowValidationException()
        {
            var command = new CalculatorCommand()
            {
                Num1 = 10.0F,
                Action = (CalculatorAction)10,
                Num2 = 30.0F
            };

            FluentActions.Invoking(() =>
                SendAsync(command)).Should().Throw<ValidationException>();
        }

        [Test]
        public void ShouldThrowDivisionByZeroException()
        {
            var command = new CalculatorCommand()
            {
                Num1 = 10.0F,
                Action = CalculatorAction.Divide,
                Num2 = 0F
            };

            FluentActions.Invoking(() =>
                SendAsync(command)).Should().Throw<DivisionByZeroException>();
        }
    }
}
