using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Restaurant
{
    public class Menu
    {   
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public DateTime LastUpdated { get; set; }
        public bool NewItemsAvailable
        {
            get
            {
                return MenuItems.Any(x => x.IsNew);
            }
        }

        public void AddItem(MenuItem item)
        {
            item.AddedOn = DateTime.Now.Date;
            LastUpdated = DateTime.Now.Date;
            MenuItems.Add(item);
        }

        public void RemoveItem(MenuItem item)
        {
            //foreach(MenuItem item in MenuItems)
            //{
            //    if(item.Name == name)
            //    {
            //        MenuItems.Remove(item);
            //    }
            //}
            
            MenuItems.RemoveAll(x => x.Equals(item));
        }

        public void PrintMenu()
        {
            foreach(MenuItem item in MenuItems)
            {
                item.PrintItem();
            }
        }
    }
}
