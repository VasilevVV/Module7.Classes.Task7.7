
namespace Module7.Classes.Task7.Model
{

    /// <summary>
    /// Доставка на дом
    /// </summary>
    public class HomeDelivery : Delivery
    {
        /// <summary>
        /// Цена доставки
        /// </summary>
        private double deliveryPrice;

        /// <summary>
        /// Цена доставки
        /// </summary>
        public override double DeliveryPrice
        {
            get => Сourier.СourierPrice;
        }

        /// <summary>
        /// Курьер для доставки на дом
        /// </summary>
        public Сourier Сourier { get; set; }

        /// <summary>
        /// Конструктор с 0 параметром
        /// </summary>
        public HomeDelivery()
        {
            this.Сourier = new Сourier();
        }
    }

}
