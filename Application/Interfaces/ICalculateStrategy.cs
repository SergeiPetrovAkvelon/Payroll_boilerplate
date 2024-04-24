namespace Payroll.Application.Interfaces{
    public interface ICalculateStrategy{
        /// <summary>
        /// Calculate the payment rate.
        /// </summary>
        /// <returns></returns>
        string CalculatePaymentRate(decimal payment);

        /// <summary>
        /// Calculate the effort.
        /// </summary>
        /// <returns></returns>
        string CalculateEffort(decimal effortTime);
    } 

}