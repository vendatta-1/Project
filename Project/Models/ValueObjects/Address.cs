using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models.ValueObjects
{
    public record Address
        (
string Street,
    string City,
         string State,
        string Country,
         string ZipCode)
    {
        [Column(name: "Street")]
        public string Street { get; private set; }

        [Column(name: "City")]
        public string City { get; private set; }

        [Column(name: "State")]
        public string State { get; private set; }

        [Column(name: "Country")]
        public string Country { get; private set; }

        [Column(name: "ZipCode")]
        public string ZipCode { get; private set; }

    }
}
