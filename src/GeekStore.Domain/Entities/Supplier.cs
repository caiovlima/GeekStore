using System.Collections.Generic;
using GeekStore.Domain.Common;

namespace GeekStore.Domain.Entities
{
    public class Supplier : Entity
    {
        public Supplier(string name, string document, bool available, Address address, IEnumerable<Product> products)
        {
            Name = name;
            Document = document;
            Available = available;
            Address = address;
            Products = products;
        }

        public string Name { get; private set; }
        public string Document { get; private set; }
        public bool Available { get; private set; }
        public Address Address { get; private set; }
        public IEnumerable<Product> Products { get; private set; }
    }
}
