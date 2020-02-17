using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
        }
    }

    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public DateTime LastUpdated { get; set; }

    }

    public enum Category { Appetizer, MainCourse, Desert }
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Category ItemCategory { get; set; }
        public bool IsNew { get; }

        public MenuItem(double price, string description, Category category, bool isNew)
        {
            Price = price;
            Description = description;
            ItemCategory = category;
            IsNew = isNew;
        }   
    }
}
