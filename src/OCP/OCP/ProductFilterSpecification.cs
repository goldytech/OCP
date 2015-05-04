namespace OCP
{
    using System.Collections.Generic;

    public abstract class ProductFilterSpecification
    {
        public IEnumerable<Product> Filter(IList<Product> products)
        {
            return ApplyFilter(products);
        }
        protected abstract IEnumerable<Product> ApplyFilter(IList<Product> products); 
    }
}