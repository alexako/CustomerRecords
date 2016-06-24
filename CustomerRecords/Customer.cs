using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRecords
{
    public class Customer : IGenerateID
    {
        string _customer_id;
        string _first_name, _last_name, _middle_initial;
        string _email, _phone_number;

        Address _address;

        public Customer(string fname, string lname, string mi, string email, string phone, Address addr)
        {
            this._customer_id = generateID(); //Generates ID based on current date and time (YYYYMMDDHHmmSS)
            this._first_name = fname;
            this._last_name = lname;
            this._middle_initial = mi;
            this._email = email;
            this._phone_number = phone;
            this._address = addr;
        }

        public string generateID()
        { //Generates ID based on current date and time (YYYYMMDDHHmmSS)
            return "C" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        public string customer_id { get { return _customer_id; } }

        public string first_name
        {
            get { return _first_name; }
            set { _first_name = value; }
        }

        public string middle_initial
        {
            get { return _middle_initial; }
            set { _middle_initial = value; }
        }

        public string last_name
        {
            get { return _last_name; }
            set { _last_name = value; }
        }

        public string phone_number
        {
            get { return _phone_number; }
            set { _phone_number = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }
    }
}
