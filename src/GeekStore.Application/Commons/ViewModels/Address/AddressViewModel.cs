using GeekStore.Application.Commons.ViewModels;

namespace GeekStore.Application.ViewModels.Product
{
    public class AddressViewModel : BaseViewModel
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Avenue { get; set; }
        public string State { get; set; }
        public SupplierViewModel Supplier { get; set; }
    }
}