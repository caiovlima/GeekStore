using System;
using GeekStore.Domain.Common;

namespace GeekStore.Domain.Entities
{
    public class Address : Entity
    {
        public Address(Guid supplierID, string street, string number, string country, string zipCode, string avenue, string state, Supplier supplier)
        {
            SupplierID = supplierID;
            Street = street;
            Number = number;
            Country = country;
            ZipCode = zipCode;
            Avenue = avenue;
            State = state;
            Supplier = supplier;
        }

        public Guid SupplierID { get; private set; }
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public string Avenue { get; private set; }
        public string State { get; private set; }
        public Supplier Supplier { get; private set; }
    }
}
