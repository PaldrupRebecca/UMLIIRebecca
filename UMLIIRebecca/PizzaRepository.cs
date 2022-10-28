using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Rebecca
{
    public class PizzaRepository
    {
        #region Instance fields
        private Dictionary< int, Pizza> _pizzas;
        #endregion

        #region Constructor
        public PizzaRepository()
        {
            _pizzas = new Dictionary<int, Pizza>();
        }
        #endregion

        #region Properties
        public int Count
        {
            get { return _pizzas.Count; }
        }
        #endregion

        #region Methods
        public void AddPizza(Pizza aPizza)
        {
            if (!_pizzas.ContainsKey(aPizza.PizzaNo))
                _pizzas.Add(aPizza.PizzaNo, aPizza);
        }
        public void DeletePizza(int pizzano)
        {
            if (_pizzas.ContainsKey(pizzano))
                _pizzas.Remove(pizzano);
        }

        public void UpdatePizza(int pizzano, Pizza pizzaToUpdate)
        {
            if (_pizzas.ContainsKey(pizzano))
                _pizzas[pizzano] = pizzaToUpdate;
        }

        public void PrintPizzas()
        {

            foreach (Pizza pizza in _pizzas.Values)
            {
                Console.WriteLine(pizza.ToString());
            }
        }

        public Pizza LookupPizza(int pizzano)
        {
            if (_pizzas.ContainsKey(pizzano))
                return _pizzas[pizzano];
            return null;
        }
        #endregion
    }
}
