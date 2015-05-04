namespace OCP
{
    using System.Collections.Generic;
    using System.Linq;

    public class ProductFilter
    {
        public IEnumerable<Product> ByColor(IList<Product> products, string productColor)
        {
            return products.Where(product => product.Color == productColor);
        }
    }
}