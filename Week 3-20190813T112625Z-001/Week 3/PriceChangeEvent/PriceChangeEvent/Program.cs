using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceChangeEvent
{
    public delegate void PriceChangedEventHandler();
    class Item
    {
        private string itemName;
        private double itemPrice;
        public event PriceChangedEventHandler onPriceChange;

        public double price
        {
            get
            {
                return itemPrice;
            }
            set
            {
                //Console.WriteLine("Changing the price of {0} from {1} to {2}", itemName, itemPrice, value);
                itemPrice = value;
                if (onPriceChange != null)
                {
                    onPriceChange();
                }
            }
        }

        public void changeDetected()
        {
            Console.WriteLine("Price of {0} has been changed to {1}", this.itemName, this.itemPrice);
        }

        static void Main(string[] args)
        {
            Item obj = new Item();
            Console.WriteLine("Enter Item Name: ");
            obj.itemName = Console.ReadLine();
            Console.WriteLine("Enter Item Price: ");
            string temp = Console.ReadLine();
            double.TryParse(temp, out obj.itemPrice);

            obj.onPriceChange += obj.changeDetected;

            obj.price = obj.price+1;
            Console.Read();
            obj.price = obj.price + 1;
            Console.Read();
            Console.Read();
        }
    }
    
}
