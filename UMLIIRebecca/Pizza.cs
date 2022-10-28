using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Rebecca
{
    public class Pizza
    {
        private int _pizzano;
        private string _pizzaname;
        private int _price;
        private string _ingredients;
        public int PizzaNo
        {
            get { return _pizzano; }
            set { _pizzano = value; }
        }

        public string PizzaName
        {
            get { return _pizzaname; }
            set { _pizzaname = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public Pizza(int pizzano, string pizzaname, int price, string ingredients)
        {
            _pizzano = pizzano;
            _pizzaname = pizzaname;
            _price = price;
            _ingredients = ingredients;
        }

        public override string ToString()
        {
            return $"Number {_pizzano}, {_pizzaname}, {_price} kr \n\t{_ingredients}";
        }
    }
}
