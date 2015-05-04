namespace OCP
{
    using System.Collections.Generic;
    using System.Linq;

    public class ColorFilterSpecification : ProductFilterSpecification
    {
        private readonly string productColor;
        /// <summary>
        /// Initializes a new instance of the <see cref="ColorFilterSpecification" /> class.
        /// </summary>
        /// <param name="productColor">Color of the product.</param>
        public ColorFilterSpecification(string productColor)
        {
            this.productColor = productColor;
        }

        /// <summary>
        /// Applies the product filter.
        /// </summary>
        /// <param name="products">The products.</param>
        /// <returns></returns>
        protected override IEnumerable<Product> ApplyFilter(IList<Product> products)
        {
            return products.Where(product => product.Color == this.productColor);
        }
    }
}