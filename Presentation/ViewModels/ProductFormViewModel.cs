namespace Presentation.ViewModels
{
    using System.Web;

    public class ProductFormViewModel
    {
        public HttpPostedFileBase File { get; set; }
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductCategory { get; set; }
    }
}