
namespace Module7.Classes.Task7.Model
{

    /// <summary>
    /// Продукт
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Цена продукта
        /// </summary>
        private double price;

        /// <summary>
        /// Цена продукта
        /// </summary>
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(Price),
                        $"The price {value} must be greater than zero.");
                }
            }
        }

        /// <summary>
        /// Название продукта
        /// </summary>
        private string nameProduct;

        /// <summary>
        /// Название продукта
        /// </summary>
        public string NameProduct
        {
            get
            {
                return nameProduct;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(nameProduct),
                        "The Name of product should never be null or empty.");
                }
                else
                {
                    nameProduct = value;
                }
            }
        }

        /// <summary>
        /// Вес продукта в килограммах
        /// </summary>
        private double weight;

        /// <summary>
        /// Вес продукта в килограммах
        /// </summary>
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(Weight),
                        $"The weight {value} must be greater than zero.");
                }
            }
        }

        /// <summary>
        /// Конструктор продукта для двух обязательных параметров
        /// </summary>
        /// <param name="NameProduct">Название</param>
        /// <param name="Price">Цена</param>
        public Product(string? NameProduct, double Price)
        {
            this.NameProduct = NameProduct;
            this.Price = Price;
        }

        /// <summary>
        /// Конструктор продукта для трех параметров
        /// </summary>
        /// <param name="NameProduct">Название</param>
        /// <param name="Price">Цена</param>
        /// <param name="Weight">Вес продукта в килограммах</param>
        public Product(string? NameProduct, double Price, double Weight) : this(NameProduct, Price)
        {
            this.Weight = Weight;
        }

        /// <summary>
        /// Преобразование в строку
        /// </summary>
        /// <returns>Название продукта и его цена</returns>
        public override string ToString()
        {
            return $"Продукт \"{NameProduct}\" продается по цене {Price} рублей";
        }
    }

}
