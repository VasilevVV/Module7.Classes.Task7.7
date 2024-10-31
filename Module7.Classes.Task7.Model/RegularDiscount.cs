
namespace Module7.Classes.Task7.Model
{

    /// <summary>
    /// Обычная абсолютная скидка (скидка сгорает после использования)
    /// </summary>
    public class RegularDiscount : Discount
    {
        /// <summary>
        /// Величина скидки
        /// </summary>
        private double discountValue;

        /// <summary>
        /// Величина скидки в рублях
        /// </summary>
        public override double DiscountValue
        {
            get
            {
                return discountValue;
            }
            set
            {
                if (value > 0)
                {
                    discountValue = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(DiscountValue),
                        $"The Regular Discount {value} must be greater than zero.");
                }
            }
        }

        /// <summary>
        /// Показать скидку в консоле
        /// </summary>
        public override void WriteDiscountToConsole()
        {
            Console.WriteLine($"Скидка составляет {DiscountValue} рублей.");
        }

        /// <summary>
        /// Перегрузка оператора сложения
        /// </summary>
        /// <param name="a">Одна скидка</param>
        /// <param name="b">Другая скидка</param>
        /// <returns>Сумма скидок</returns>
        public static RegularDiscount operator +(RegularDiscount a, RegularDiscount b)
        {
            return new RegularDiscount
            {
                discountValue = a.discountValue + b.discountValue
            };
        }
    }

}
