using AutoMapper;
using GeekStore.Application.ViewModels.Product;
using GeekStore.Domain.Entities;

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
            var productMappingConfig = new MapperConfiguration(cfg => {
                cfg.CreateMap<Domain.Entities.Product, ProductViewModel>()
                   .ReverseMap();
            });

            var supplierMappingConfig = new MapperConfiguration(cfg => {
                cfg.CreateMap<Supplier, SupplierViewModel>()
                   .ReverseMap();
            });

            var addressMappingConfig = new MapperConfiguration(cfg => {
                cfg.CreateMap<Supplier, SupplierViewModel>()
                   .ReverseMap();
            });
        }
    }
}
