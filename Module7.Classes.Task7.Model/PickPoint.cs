
namespace Module7.Classes.Task7.Model
{

    /// <summary>
    /// Пункт выдачи
    /// </summary>
    public class PickPoint
    {
        /// <summary>
        /// Название пункта выдачи
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Контакты пункта выдачи
        /// </summary>
        public string? Сontacts { get; set; }

        /// <summary>
        /// Цена доставки до пункта выдачи
        /// </summary>
        public double PickPointPrice { get; set; }

        /// <summary>
        /// Цена хранения в пункте выдачи за 1 день
        /// </summary>
        public double PickPointPriceForDay { get; set; }

        /// <summary>
        /// Пункт выдачи 
        /// </summary>
        /// <param name="name">Название пункта выдачи</param>
        /// <param name="сontacts">Контакты пункта выдачи</param>
        /// <param name="pickPointPrice">Цена доставки до пункта выдачи</param>
        /// <param name="pickPointPriceForDay">Цена хранения в пункте выдачи за 1 день</param>
        public PickPoint(string? name, string? сontacts, double pickPointPrice, double pickPointPriceForDay)
        {
            Name = name;
            Сontacts = сontacts;
            PickPointPrice = pickPointPrice;
            PickPointPriceForDay = pickPointPriceForDay;
        }

    }

}
