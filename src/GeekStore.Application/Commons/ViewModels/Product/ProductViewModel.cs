﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GeekStore.Application.ViewModels.Product
{
    public class ProductViewModel
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
        public string ImageUpload { get; set; }
        public string Image { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        public decimal Value { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateCreated { get; set; }
        public bool Available { get; set; }

        [ScaffoldColumn(false)]
        public string SupplierName { get; set; }
    }
}
