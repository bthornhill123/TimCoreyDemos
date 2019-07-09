namespace Generics
{
    public partial class Utilities
    {
        public class DiscountCalculator<TProduct> where TProduct : Product
        {
            public float CalculateDiscount(TProduct product)
            {
                return product.Price;
            }
        }
    }
}
