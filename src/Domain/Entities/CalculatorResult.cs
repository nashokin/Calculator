using Calculator.Domain.Common;
using Calculator.Domain.Enums;

namespace Calculator.Domain.Entities
{
    public class CalculatorResult : AuditableEntity
    {
        public int Id { get; set; }

        public float Num1 { get; set; }

        public CalculatorAction Action { get; set; }

        public float Num2 { get; set; }

        public float Result { get; set; }
    }
}
