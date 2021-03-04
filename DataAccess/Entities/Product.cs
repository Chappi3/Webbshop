﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DataAccess.Entities
{
    public class Product
    {
        public Guid ID { get; set; }

        [Required]
        [JsonIgnore]
        public Category Category { get; set; }
        public List<Order> Orders { get; set; }
        public string ProductName { get; set; }

        public string URLImg { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public double PriceWithDiscount { get; set; }

        public int StockBalance { get; set; }

        public double Discount { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public int Sales { get; set; }

        public Product()
        {
            ID = Guid.NewGuid();
            PriceWithDiscount = Price;
        }
    }
}
