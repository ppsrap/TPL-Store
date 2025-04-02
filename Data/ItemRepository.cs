using System.Collections.Generic;
using TPL_Store.Models;

namespace TPL_Store.Data
{
    public  class ItemRepository
    {
        public List<Items> GetAllItems()
        {
            return new List<Items>
            {
                new() { ItemID = 50211, ItemName = "Splash Jacket", Cost = 2.99m },
                new() { ItemID = 50212, ItemName = "Toilet Roll", Cost = 1.49m },
                new() { ItemID = 50213, ItemName = "Pen 6 Pack", Cost = 3.59m },
                new() { ItemID = 50214, ItemName = "Multi Fit Gloves", Cost = 4.25m },
                new() { ItemID = 50215, ItemName = "Cutting Knife", Cost = 2.89m },
                new() { ItemID = 50216, ItemName = "Spa Towel", Cost = 8.99m },
                new() { ItemID = 50217, ItemName = "Cleaning Spray (Glass)", Cost = 3.19m },
                new() { ItemID = 50218, ItemName = "Cleaning Spray (Multipurpose)", Cost = 3.99m },
                new() { ItemID = 50219, ItemName = "Micro-Fiber Towel", Cost = 1.29m },
                new() { ItemID = 50210, ItemName = "Coffee Bag (2KG)", Cost = 5.75m }
            };
        }
    }
}
