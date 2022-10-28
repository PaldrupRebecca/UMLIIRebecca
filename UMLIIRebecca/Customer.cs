using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Rebecca
{
    public class Customer
    {
        private static int counter = 0;
        private int _cid;
        private string _name;
        private string _email;
        private string _address;

        public int CID
        { 
            get { return _cid; }
            set { _cid = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        //public int CID { get; set; }
        //public string Name { get; set; }
        //public string Email { get; set; }
        //public string Address { get; set; }

        public Customer(string name, string email, string address)
        {
            counter++;
            _cid = counter;
            _name = name;
            _email = email;
            _address = address;

        }

        public override string ToString()
        {
            return $"Customer ID: {_cid} \nName: {_name} \nEmail: {_email} \nAddress: {_address}";
        }
    }
}
