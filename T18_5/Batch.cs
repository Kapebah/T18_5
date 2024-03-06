using System;
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
        public Batch()
        { }

        public Batch(string name, double price, DateTime productionDate, DateTime expirationDate, int count) : base(name, price)
        {
            ProductionDate = productionDate; ExpirationDate = expirationDate; Count = count;
        }

        /// <summary>
        /// Calculating price
        /// </summary>
        /// <returns>Price for all</returns>
        public double PriceForAll()
        { return Price * Count; }

        /// <summary>
        /// Identifying if a product is overdue
        /// </summary>
        /// <returns>String overdue or not</returns>
        public override string Expiry()
        { return (ExpirationDate >= DateTime.Now) ? "Not expired" : $"{DateTime.Now.Day - ExpirationDate.Day} days overdue"; }

        /// <summary>
        /// Overriden method for output all info
        /// </summary>
        /// <returns>Info about batch</returns>
        public override string ToString()
        {
            return $"Name: {Name}\nPrice for one: {Price}\nCount: {Count}\nPrice for all: {PriceForAll()}\nDate of production: {ProductionDate.ToLongDateString()}\n" +
                $"Expiration date: {ExpirationDate.ToLongDateString()}\nCondition: {Expiry()}";
        }

        /// <summary>
        /// Input info about product
        /// </summary>
        /// <returns>Inputed info</returns>
        public static Batch Input()
        {
            Write("Enter the batch's name: ");
            string name = ReadLine();
            Write("Enter the price for one product: ");
            double price = Convert.ToDouble(ReadLine());
            Write("Enter the count of products: ");
            int count = Convert.ToInt32(ReadLine());
            Write("Enter the date of production: ");
            DateTime productionDate = DateTime.Parse(ReadLine());
            Write("Enter the expiration date: ");
            DateTime expirationDate = DateTime.Parse(ReadLine());
            return new Batch(name, price, productionDate, expirationDate, count);
        }
    }
}