﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace DataAccess.Entities
{
    public class Address
    {

        public Guid ID { get; set; }

        public User User { get; set; }

        [MaxLength(50)]
        public string Street { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(50)]
        public string State { get; set; }

        [MaxLength(50)]
        public string PostalCode { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        public Address()
        {
            ID = Guid.NewGuid();
        }

    }
}
