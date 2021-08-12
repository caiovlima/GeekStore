using System.Collections.Generic;
using GeekStore.Application.Commons.ViewModels;

namespace GeekStore.Application.ViewModels.Product
{
    public class SupplierViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public bool Available { get; set; }
        public AddressViewModel Address { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}