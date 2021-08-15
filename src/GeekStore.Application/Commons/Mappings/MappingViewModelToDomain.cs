using AutoMapper;
using GeekStore.Domain.Entities;
using GeekStore.Application.ViewModels.Address;
using GeekStore.Application.ViewModels.Product;
using GeekStore.Application.ViewModels.Supplier;

namespace GeekStore.Application.Commons.Mappings
{
    public class MappingViewModelToDomain : Profile
    {
        public MappingViewModelToDomain()
        {
            ApplyMappings();
        }

        private void ApplyMappings()
        {
            CreateMap<Supplier, SupplierViewModel>().ReverseMap();
            CreateMap<Domain.Entities.Product, ProductViewModel>().ReverseMap();
            CreateMap<Address, AddressViewModel>().ReverseMap();
        }
    }
}
