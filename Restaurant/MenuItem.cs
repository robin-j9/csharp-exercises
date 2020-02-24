using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public enum CategoryType { Appetizer, MainCourse, Dessert }

    public class MenuItem
    {
        private static int idCounter = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public CategoryType Category { get; set; }
        public DateTime AddedOn { get; set; }
        public bool IsNew
        {
            get
            {
                return AddedOn.Date >= DateTime.Now.Date.AddMonths(-3);
            }
        }

        public MenuItem(string name, double price, string description, CategoryType category)
        {
            Id = idCounter;
            idCounter++;
            Name = name;
            Price = price;
            Description = description;
            Category = category;
        }

        public void PrintItem()
        {
                Console.WriteLine("Category: " + Category + "\n" +
                                  "Name: " + Name + "\n" + 
                                  "Description: " + Description + "\n");
        }

        public override bool Equals(object obj)
        {   
            if(obj == this)
            {
                return true;
            }

            if(obj.GetType() != GetType() || obj == null)
            {
                return false;
            }

            MenuItem itemObj = obj as MenuItem;
            return itemObj.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
