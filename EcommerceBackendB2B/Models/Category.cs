﻿namespace EcommerceBackendB2B.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation property
        public List<Product> Products { get; set; }
    }
}
