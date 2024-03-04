using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_5
{
    abstract class Item
    {
        /// <summary>
        /// Name of item
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Price of item
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Item() { }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of item</param>
        /// <param name="price">Price of item</param>
        public Item(string name, double price) {  Name = name; Price = price; }
        /// <summary>
        /// Output info
        /// </summary>
        /// <returns>Information about item</returns>
        public abstract string ToString();
        public abstract string Expiry();

    }
}
