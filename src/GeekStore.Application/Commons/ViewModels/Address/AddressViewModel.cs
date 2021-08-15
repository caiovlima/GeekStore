using System;
using System.ComponentModel.DataAnnotations;

namespace GeekStore.Application.ViewModels.Product
{
    public class AddressViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(200, ErrorMessage = "The field {0} need's between {2} and {1} characters", MinimumLength = 2)]
        public string Street { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(50, ErrorMessage = "The field {0} need's between {2} and {1} characters", MinimumLength = 2)]
        public string Number { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(100, ErrorMessage = "The field {0} need's between {2} and {1} characters", MinimumLength = 2)]
        public string Country { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(8, ErrorMessage = "The field {0} need's between {2} and {1} characters", MinimumLength = 2)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(200, ErrorMessage = "The field {0} need's between {2} and {1} characters", MinimumLength = 2)]
        public string Avenue { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(200, ErrorMessage = "The field {0} need's between {2} and {1} characters", MinimumLength = 2)]
        public string State { get; set; }
        public Guid SupplierID { get; set; }
    }
}