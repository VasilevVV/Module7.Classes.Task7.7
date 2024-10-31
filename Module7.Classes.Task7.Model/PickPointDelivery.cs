
namespace Module7.Classes.Task7.Model
{

    /// <summary>
    /// Доставка в пункт выдачи
    /// </summary>
    public class PickPointDelivery : Delivery
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
            get
            {
                if (this.pickPoint != null && this.daysOfKeeping > 0)
                {
                    return this.pickPoint.PickPointPrice + (this.daysOfKeeping * this.pickPoint.PickPointPriceForDay);
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Пункт выдачи
        /// </summary>
        private PickPoint pickPoint;

        /// <summary>
        /// Пункт выдачи
        /// </summary>
        public PickPoint PickPoint { get; set; }


        /// <summary>
        /// Дней хранения в пункте выдачи
        /// </summary>
        private int daysOfKeeping;

        /// <summary>
        /// Дней хранения в пункте выдачи
        /// </summary>
        public int DaysOfKeeping
        {
            get
            {
                return daysOfKeeping;
            }
            set
            {
                if (value > 0)
                {
                    daysOfKeeping = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(DaysOfKeeping),
                        $"The Days Of Keeping {value} must be greater than zero.");
                }
            }
        }

        /// <summary>
        /// Конструктор для доставки в пункт выдачи 
        /// </summary>
        /// <param name="pickPoint">Пункт выдачи</param>
        /// <param name="daysOfKeeping">Дней хранения в пункте выдачи</param>
        public PickPointDelivery(PickPoint pickPoint, int daysOfKeeping)
        {
            this.daysOfKeeping = daysOfKeeping;
            this.pickPoint = pickPoint;
        }
    }

}
