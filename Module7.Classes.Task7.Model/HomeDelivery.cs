
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
        public override double DeliveryPrice
        {
            get => Courier.CourierPrice;
        }

        /// <summary>
        /// Курьер для доставки на дом
        /// </summary>
        public Courier Courier { get; set; }

        /// <summary>
        /// Конструктор с 0 параметром
        /// </summary>
        public HomeDelivery()
        {
            this.Courier = new Courier();            
        }
    }

}
