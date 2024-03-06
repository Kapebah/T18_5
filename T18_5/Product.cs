using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_5
{
    class Product : Item
    {
        /// <summary>
        /// Date of production
        /// </summary>
        public DateTime ProductionDate { get; set; }

        /// <summary>
        /// Expiration date
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Constructors
        /// </summary>
        public Product()
        { }

        public Product(string name, double price, DateTime productionDate, DateTime expirationDate) : base(name, price)
        {
            ProductionDate = productionDate; ExpirationDate = expirationDate;
        }

        /// <summary>
        /// Identifying if a product is overdue
        /// </summary>
        /// <returns>String overdue or not</returns>
        public override string Expiry()
        { return (ExpirationDate > DateTime.Now) ? "Not expired" : $"{DateTime.Now.Day - ExpirationDate.Day} days overdue"; }

        /// <summary>
        /// Overriden method for output all info
        /// </summary>
        /// <returns>Info about product</returns>
        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price}\nDate of production: {ProductionDate.ToLongDateString()}\n" +
                $"Expiration date: {ExpirationDate.ToLongDateString()}\nCondition: {Expiry()}";
        }

        /// <summary>
        /// Input info about product
        /// </summary>
        /// <returns>Inputed info</returns>
        public static Product Input()
        {
            Write("Enter the product's name: ");
            string name = ReadLine();
            Write("Enter the product's price: ");
            double price = Convert.ToDouble(ReadLine());
            Write("Enter the date of production: ");
            DateTime productionDate = DateTime.Parse(ReadLine());
            Write("Enter the expiration date: ");
            DateTime expirationDate = DateTime.Parse(ReadLine());
            return new Product(name, price, productionDate, expirationDate);
        }
    }
}