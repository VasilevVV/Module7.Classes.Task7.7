

namespace Module7.Classes.Task7.Model
{
    /// <summary>
    /// Расчет цены для продуктов
    /// </summary>
    internal static class ProductPriceCalculator
    {
        /// <summary>
        /// Расчет полной цены продуктов
        /// </summary>
        /// <param name="Products">Продукты</param>
        /// <returns>Полная цена продуктов</returns>
        internal static double CalculateFullPrice(Product[] Products)
        {
            double fullPrice = 0;
            foreach (Product product in Products)
            {
                fullPrice += product.Price;
            }
            return fullPrice;
        }

        /// <summary>
        /// Расчет цены продуктов с учетом скидки
        /// </summary>
        /// <param name="Products">Продукты</param>
        /// <param name="Discount">Скидка</param>
        /// <returns>Цена продуктов с учетом скидки</returns>
        internal static double CalculateDiscountedPrice(Product[] Products, Discount Discount)
        {
            if (Discount is PercentDiscount percentDiscount)
            {
                return (CalculateFullPrice(Products) * (percentDiscount.DiscountValue / 100.00));
            }
            else if (Discount is RegularDiscount regularDiscount)
            {
                var tempPrice = CalculateFullPrice(Products) - regularDiscount.DiscountValue;
                if (tempPrice > 0)
                {
                    return tempPrice;
                }
                else
                {
                    return 0;
                }

            }
            else
            {
                return CalculateFullPrice(Products);
            }
        }

    }

}
