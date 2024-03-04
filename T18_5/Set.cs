using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_5
{
    class Set : Item
    {
        /// <summary>
        /// List of products
        /// </summary>
        public List<string> ListOfProducts {  get; set; }
        /// <summary>
        /// Constructors
        /// </summary>
        public Set() { }
        public Set(string name, double price, List<string> listOfProducts) : base(name, price) => ListOfProducts = listOfProducts;
        /// <summary>
        /// Overriden method Expiry
        /// </summary>
        /// <returns>nothing</returns>
        /// <exception cref="NotImplementedException"></exception>
        public override string Expiry()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Overriden method for output all info
        /// </summary>
        /// <returns>Information about set</returns>
        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price}\nList of products: {string.Join(", ", ListOfProducts)}";
        }
        /// <summary>
        /// Input info about set
        /// </summary>
        /// <returns>Inputed info</returns>
        public static Set Input()
        {
            Write("Enter the set's name: ");
            string name = ReadLine();
            Write("Enter the price of set: ");
            double price = Convert.ToDouble(ReadLine());
            Write("Enter the list of products with a space: ");
            string list = ReadLine();
            string[] products = list.Split(' ');
            List<string> listOfProducts = products.Select(prod => prod.Trim()).ToList();

            return new Set(name, price, listOfProducts);
        }

    }
}
