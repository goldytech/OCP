namespace OCP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductFilter
    {
        /// <summary>
        /// Filter the products by color.
        /// </summary>
        /// <param name="products">The products.</param>
        /// <param name="productColor">Color of the product.</param>
        /// <returns></returns>
        [Obsolete]
        public IEnumerable<Product> ByColor(IList<Product> products, string productColor)
        {
            return products.Where(product => product.Color == productColor);
        }

        /// <summary>
        /// Filter the products by size.
        /// </summary>
        /// <param name="products">The products.</param>
        /// <param name="productSize">Size of the product.</param>
        /// <returns></returns>
        [Obsolete]
        public IEnumerable<Product> BySize(IList<Product> products, string productSize)
        {
            return products.Where(product => (product.Size == productSize));
        }

        /// <summary>
        /// Filter the products by size and color 
        /// </summary>
        /// <param name="products">The products.</param>
        /// <param name="productColor">Color of the product.</param>
        /// <param name="productSize">Size of the product.</param>
        /// <returns></returns>
        [Obsolete]
        public IEnumerable<Product> ByColorAndSize(IList<Product> products, string productColor, string productSize)
        {
            return products.Where(product => (product.Color == productColor) && (product.Size == productSize));
        }

        public IEnumerable<Product> By(IList<Product> products, ProductFilterSpecification filterSpecification)
        {
            return filterSpecification.Filter(products);
        }
    }
}