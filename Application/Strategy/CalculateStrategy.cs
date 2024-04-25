using Payroll.Application.Interfaces;

namespace Payroll.Application.Strategy
{
    public class SalariedCalculateStrategy : ICalculateStrategy
    {
        public string CalculatePaymentRate(decimal payment)
        {
            return $"{payment} $ / month";
        }

        public string CalculateEffort(decimal effortTime)
        {
            return $"{effortTime} months";
        }
    }

    public class HourlyCalculateStrategy : ICalculateStrategy
    {
        public string CalculatePaymentRate(decimal payment)
        {
            return $"{payment} $ / hour";
        }

        public string CalculateEffort(decimal effortTime)
        {
            return $"{effortTime} hours";
        }
    }
}