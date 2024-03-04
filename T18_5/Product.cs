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
        public DateTime ExpirationDate {  get; set; }
        /// <summary>
        /// Constructors
        /// </summary>
        public Product() { }
        public Product(string name, double price, DateTime productionDate, DateTime expirationDate) : base(name, price)
        {
            ProductionDate = productionDate; ExpirationDate = expirationDate;
        }
        /// <summary>
        /// Identifying if a product is overdue
        /// </summary>
        /// <returns>String overdue or not</returns>
        public override string Expiry() { return (ExpirationDate <= DateTime.Now) ? "Not expired" : $"{DateTime.Now.Day - ExpirationDate.Day} days overdue"; }
        public override string ToString() 
        { 
            return $"Name: {Name}\nPrice: {Price}\nDate of production: {ProductionDate.ToLongDateString()}\n" +
                $"Expiration date: {ExpirationDate.ToLongDateString()}\nCondition: {Expiry()}\n"; 
        }
    }
}
