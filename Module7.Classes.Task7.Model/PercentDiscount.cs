
namespace Module7.Classes.Task7.Model
{
    /// <summary>
    /// Скидка в процентах (скидка сгорает после использования)
    /// </summary>
    public class PercentDiscount : Discount
    {
        /// <summary>
        /// Величина скидки
        /// </summary>
        private double discountValue;

        /// <summary>
        /// Величина скидки в процентах
        /// </summary>
        public override double DiscountValue
        {
            get
            {
                return discountValue;
            }
            set
            {
                if (value > 0 && value <= 100.00)
                {
                    discountValue = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(DiscountValue),
                        $"The Percent Discount {value} must be greater than 0.00 percent and less than 100.00 percent.");
                }
            }
        }

        /// <summary>
        /// Показать скидку в консоле
        /// </summary>
        public override void WriteDiscountToConsole()
        {
            Console.WriteLine($"Скидка составляет {DiscountValue} процентов.");
        }
    }

}
