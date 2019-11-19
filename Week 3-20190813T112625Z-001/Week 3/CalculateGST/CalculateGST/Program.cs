using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateGST
{
    class Item
    {
        private string _name;
        private decimal cost;

        public string Name { get; set; }

        public decimal Cost
        {
            get
            {
                return cost;
            }
            set
            {
                if (value > 0)
                    cost = value;
                else
                    throw new Exception("Cost should be a positive decimal value.");
            }
        }

        decimal CalculateGST()
        {
            return (decimal)0.08 * cost;
        }

        static void Main(string[] args)
        {
            Item item = new Item();
            Console.WriteLine("Enter Item name: ");
            item.Name = Console.ReadLine();
            Console.WriteLine("Enter Item price: ");
            try
            {
                item.Cost = decimal.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("{0}: GST = {1}", item.Name, item.CalculateGST());
            Console.Read();
        }
    }
}
