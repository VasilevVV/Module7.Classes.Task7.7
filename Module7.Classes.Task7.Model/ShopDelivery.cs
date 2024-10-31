
namespace Module7.Classes.Task7.Model
{

    /// <summary>
    /// Доставка в розничный магазин
    /// </summary>
    public class ShopDelivery : Delivery
    {
        /// <summary>
        /// Цена доставки
        /// </summary>
        private double deliveryPrice = 0;

        /// <summary>
        /// Цена доставки
        /// </summary>
        public override double DeliveryPrice
        {
            get { return deliveryPrice; }
        }
    }

}
