
namespace Module7.Classes.Task7.Model
{
    /// <summary>
    /// Заказы
    /// </summary>
    /// <typeparam name="TDelivery">Доставка</typeparam>
    /// <typeparam name="TStruct">Структура</typeparam>
    public class Order<TDelivery, TStruct>
        where TDelivery : Delivery
        where TStruct : struct
    {
        /// <summary>
        /// Доставка
        /// </summary>
        public TDelivery Delivery;

        /// <summary>
        /// Структура непонятная
        /// </summary>
        public TStruct Struct;

        /// <summary>
        /// Клиент заказа
        /// </summary>
        public Client Client;

        /// <summary>
        /// Описание заказа дополнительное
        /// </summary>
        public string Description;

        /// <summary>
        /// Продукты для заказа
        /// </summary>
        public Product[] Products;

        /// <summary>
        /// Продукт из заказа
        /// </summary>
        /// <param name="index">Индекс продукта в заказе</param>
        /// <returns>Продукт по индексу</returns>
        public Product this[int index]
        {
            get => Products[index];
            set => Products[index] = value;
        }

        /// <summary>
        /// Конструктор с 0 параметром
        /// </summary>
        /// <param name="Delivery">Доставка заказа</param>
        public Order() { }

        /// <summary>
        /// Конструктор с 1 параметром
        /// </summary>
        /// <param name="Delivery">Доставка заказа</param>
        public Order(TDelivery Delivery) : this()
        {
            this.Delivery = Delivery;
        }

        /// <summary>
        /// Конструктор с 2 параметрами
        /// </summary>
        /// <param name="Delivery">Доставка заказа</param>
        /// <param name="Client">Клиент заказа</param>
        public Order(TDelivery Delivery, Client Client) : this(Delivery)
        {
            this.Client = Client;
        }

        /// <summary>
        /// Конструктор с 3 параметрами
        /// </summary>
        /// <param name="Delivery">Доставка заказа</param>
        /// <param name="Client">Клиент заказа</param>
        /// <param name="Description">Описание заказа</param>
        public Order(TDelivery Delivery, Client Client, string Description) : this(Delivery, Client)
        {
            this.Description = Description;
        }

        /// <summary>
        /// Конструктор с 4 параметрами
        /// </summary>
        /// <param name="Delivery">Доставка заказа</param>
        /// <param name="Client">Клиент заказа</param>
        /// <param name="Description">Описание заказа</param>
        /// <param name="Products">Продукты для заказа</param>
        public Order(TDelivery Delivery, Client Client, string Description, Product[] Products) : this(Delivery, Client, Description)
        {
            this.Products = Products;
        }


        /// <summary>
        /// Вывести адрес в консоль
        /// </summary>
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        /// <summary>
        /// Раccчитать цену заказа
        /// </summary>
        /// <returns>Цена заказа</returns>
        public double CalculateOrderPrice()
        {
            double orderPrice = ProductPriceCalculator.CalculateFullPrice(this.Products)
                                + this.Delivery.DeliveryPrice;

            return orderPrice;
        }

        /// <summary>
        /// Расcчитать цену заказа со скидкой
        /// </summary>
        /// <returns>Цена заказа со скидкой</returns>
        public double CalculateDiscountedOrderPrice(Discount Discount)
        {
            double orderPrice = ProductPriceCalculator.CalculateDiscountedPrice(this.Products, Discount)
                                + this.Delivery.DeliveryPrice;

            return orderPrice;
        }

        /// <summary>
        /// Составление описания заказа
        /// </summary>
        public void WriteDescription()
        {
            string ProductsDescription = "";
            foreach (Product product in this.Products)
            {
                String.Concat(ProductsDescription, product.ToString(), "\n");
            }
            this.Description = ProductsDescription;
        }

        /// <summary>
        /// Заменить продукт в заказе
        /// </summary>
        /// <typeparam name="Product">Продукт</typeparam>
        /// <param name="newProduct">Новый продукт</param>
        public virtual void ChangeProductInOrder<Product>(Product newProduct)
        {

        }


        /// <summary>
        /// Изменить способ доставки
        /// </summary>
        /// <typeparam name="Delivery">Доставка</typeparam>
        /// <param name="newDelivery">Другой способ доставки</param>
        public virtual void ChangeDelivery<Delivery>(Delivery newDelivery)
        {

        }
    }

}
