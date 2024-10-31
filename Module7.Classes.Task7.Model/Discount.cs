
namespace Module7.Classes.Task7.Model
{

    /// <summary>
    /// Скидка (скидка сгорает после использования)
    /// </summary>
    public abstract class Discount
    {
        /// <summary>
        /// Величина скидки
        /// </summary>
        public abstract double DiscountValue { get; set; }

        /// <summary>
        /// Показать скидку в консоле
        /// </summary>
        public abstract void WriteDiscountToConsole();
    }

}
