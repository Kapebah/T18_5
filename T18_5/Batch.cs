using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_5
{
    class Batch : Item
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
        /// Count of batches
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Constructors
        /// </summary>
        public Batch() { }
        public Batch(string name, double price, DateTime productionDate, DateTime expirationDate, int count) : base(name, price)
        {
            ProductionDate = productionDate; ExpirationDate = expirationDate; Count = count;
        }
        /// <summary>
        /// Calculating price
        /// </summary>
        /// <returns>Price for all</returns>
        public double PriceForAll() { return Price * Count; }
        public override string ToString()
        {
            return $"Name: {Name}\nPrice for one: {Price}\nCount: {Count}\nPrice for all: {PriceForAll()}\nDate of production: {ProductionDate.ToLongDateString()}\n" +
                $"Expiration date: {ExpirationDate.ToLongDateString()}\n";
        }
    }
}
