using Calculator.Application.Common.Interfaces;
using System;

namespace Calculator.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
