using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public enum Category { Appetizer, MainCourse, Desert }
    class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Category ItemCategory { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(double price, string description, Category category, bool isNew)
        {
            Price = price;
            Description = description;
            ItemCategory = category;
            IsNew = isNew;
        }
    }
}
