namespace Presentation.ViewModels
{
    using System.Collections.Generic;
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
}