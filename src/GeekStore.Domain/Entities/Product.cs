using System;
using GeekStore.Domain.Common;

namespace GeekStore.Domain.Entities
{
    public class Product : Entity
    {
        public Product(Guid supplierID, string name, string description, string image, decimal value, bool available, Supplier supplier)
        {
            SupplierID = supplierID;
            Name = name;
            Description = description;
            Image = image;
            Value = value;
            Available = available;
            Supplier = supplier;
        }

        public Guid SupplierID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public decimal Value { get; private set; }
        public bool Available { get; private set; }
        public Supplier Supplier { get; private set; }
    }
}
