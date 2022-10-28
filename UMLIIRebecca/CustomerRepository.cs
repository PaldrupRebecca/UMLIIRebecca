using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Rebecca
{
    public class CustomerRepository
    {
        #region Instance fields
        private List<Customer> _customers;
        #endregion

        #region Constructor
        public CustomerRepository()
        {
            _customers = new List<Customer>();
        }
        #endregion

        #region Properties
        public int Count
        {
            get { return _customers.Count; }
        }
        #endregion

        #region Methods
        public void AddCustomer(Customer aCustomer)
        {
            Customer foundCustomer = LookupCustomer(aCustomer.Name);
            if (foundCustomer == null)
                _customers.Add(aCustomer);
        }

        public void DeleteCustomer(string name)
        {
            Customer c = LookupCustomer(name);
            _customers.Remove(c);

        }

        public void UpdateCustomer(string name, Customer customerToUpdate)
        {
            int i = 0;
            while (i < _customers.Count)
            {
                if (_customers[i].Name == name)
                {
                    _customers[i] = customerToUpdate;
                    break;
                }
                i++;
            }
        }
        public void PrintCustomers()
        {

            foreach (Customer c in _customers)
            {
                Console.WriteLine(c);
            }

        }

        public Customer LookupCustomer(string name)
        {
            foreach (Customer c in _customers)
            {
                if (name == c.Name)
                    return c;
            }
            return null;
        }

        #endregion
    }
}
