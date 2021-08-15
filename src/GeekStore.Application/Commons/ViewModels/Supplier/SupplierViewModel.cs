using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GeekStore.Application.ViewModels.Address;
using GeekStore.Application.ViewModels.Product;

namespace GeekStore.Application.ViewModels.Supplier
{
    public class SupplierViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(200, ErrorMessage = "The field {0} need's between {2} and {1} characters", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(14, ErrorMessage = "The field {0} need's between {2} and {1} characters", MinimumLength = 2)]
        public string Document { get; set; }

        public bool Available { get; set; }

        public AddressViewModel Address { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}