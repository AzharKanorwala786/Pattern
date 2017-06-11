namespace Dto
{
    using System.Collections.Generic;
    public class Category : Base
    {
        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}