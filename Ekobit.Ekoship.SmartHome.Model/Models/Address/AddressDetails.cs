﻿namespace Ekobit.Ekoship.SmartHome.Model.Models.Address
{
    public class AddressDetails
    {
        public int Id { get; set; }

        public string StreetName { get; set; } = null!;

        public int Number { get; set; }

        public string City { get; set; } = null!;

        public int ZipCode { get; set; }

        public string Country { get; set; } = null!;
    }
}
