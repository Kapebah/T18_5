using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_5
{
    class ItemsRepository
    {
        /// <summary>
        /// Collection of persons
        /// </summary>
        private List<Item> items = new List<Item>();

        /// <summary>
        /// Method of adding items
        /// </summary>
        /// <param name="product">Items</param>
        public void AddItem(Item product)
        {
            items.Add(product);
            WriteLine($"You have add the new item - {product.Name}\n");
        }

        /// <summary>
        /// Output info about all added items
        /// </summary>
        /// <param name="product">Item</param>
        public void OutputItem()
        {
            foreach (var item in items) { WriteLine(item.ToString()); WriteLine(); }
        }
    }
}