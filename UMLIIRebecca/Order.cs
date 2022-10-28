using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Rebecca
{
    public class Order
    {
        private static int counter = 0;

        public Pizza Pizza { get; set; }

        //private Pizza _pizza;

        //public Pizza Pizza
        //{
        //    get { return _pizza; }
        //    set { _pizza = value; }
        //}

        public Customer Customer { get; set; }

        public int OrderID { get; set; }

        public DateTime TimeOfOrder { get; private set; }
        public DateTime OrderReady { get; private set; }

        public Order(Pizza pizza, Customer customer)
        {
            Pizza = pizza;
            Customer = customer;
            counter++;
            OrderID = counter;
            TimeOfOrder = DateTime.Now;
            OrderReady = TimeOfOrder.AddMinutes(20);

        }

        public override string ToString()
        {
            return $"Order ID: {OrderID}\nOrdered by {Customer.Name}\nOrder created {TimeOfOrder.ToString("dd/MM/yyyy HH:mm")}\nOrder will be ready {OrderReady.ToString("dd/MM/yyyy HH:mm")}\nOrder:\n\tNumber {Pizza.PizzaNo}, {Pizza.PizzaName}, {Pizza.Price} kr";
        }
    }
}
