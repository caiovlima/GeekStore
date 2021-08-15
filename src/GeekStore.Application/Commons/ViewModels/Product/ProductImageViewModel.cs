using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;


namespace GeekStore.Application.Commons.ViewModels.Product
{
    public class ProductImageViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        public Guid SupplierID { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(200, ErrorMessage = "The field {0} need's between {2} and {1} characters", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(1000, ErrorMessage = "The field {0} need's between {2} and {1} characters", MinimumLength = 2)]
        public string Description { get; set; }

        public IFormFile ImageUpload { get; set; }

        public string Image { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        public decimal Valor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateCreated { get; set; }

        public bool Available { get; set; }

        [ScaffoldColumn(false)]
        public string SupplierName { get; set; }
    }
}
