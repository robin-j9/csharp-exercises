using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem food1 = new MenuItem("food1", 5.25, "description of first item", CategoryType.Appetizer);
            MenuItem food2 = new MenuItem("food2", 7.50, "description of second item", CategoryType.MainCourse);
            MenuItem food3 = new MenuItem("food3", 10, "description of third item", CategoryType.Dessert);

            Console.WriteLine("Print one menu item:");
            food1.PrintItem();

            Menu menu = new Menu();
            menu.AddItem(food1);
            menu.AddItem(food2);
            menu.AddItem(food3);

            Console.WriteLine("Print full menu:");
            menu.PrintMenu();

            Console.WriteLine("\nfood1 added on : " + food1.AddedOn);
            Console.WriteLine("food1 is new: " + food1.IsNew);
            Console.WriteLine("menu last updated: " + menu.LastUpdated.ToString());
            Console.WriteLine("new items available: " + menu.NewItemsAvailable + "\n");

            menu.RemoveItem(food1);
            menu.PrintMenu();
        }
    }
}
