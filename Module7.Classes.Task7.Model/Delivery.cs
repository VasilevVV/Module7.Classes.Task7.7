
namespace Module7.Classes.Task7.Model
{
    /// <summary>
    /// Доставка
    /// </summary>
    public abstract class Delivery
    {
        /// <summary>
        /// Адрес доставки
        /// </summary>
        protected string? address;

        /// <summary>
        /// Адрес доставки
        /// </summary>
        public string? Address 
        { 
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        /// <summary>
        /// Цена доставки
        /// </summary>
        public abstract double DeliveryPrice { get; }
    }

}
