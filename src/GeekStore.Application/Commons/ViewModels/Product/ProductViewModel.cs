using System;
using GeekStore.Application.Commons.ViewModels;

namespace GeekStore.Application.ViewModels.Product
{
    public class ProductViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Value { get; set; }
        public bool Available { get; set; }
        public SupplierViewModel Supplier { get; set; }
    }
}
