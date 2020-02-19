using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Menu
    {
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public DateTime LastUpdated { get; set; }
    }
}
