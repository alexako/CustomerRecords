using CustomerRecords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRecords
{
    public class Transaction : IGenerateID
    {
        string _trans_id;
        string _customer_id;
        string _date_of_trans;
        Dictionary<string, int> _shopping_cart; // Key: item name | Value: item quantity

        public Transaction(string customer_id)
        {
            _customer_id = customer_id;
            _trans_id = generateID(); //Generates ID based on current date and time + the corresponding customer's ID
            _date_of_trans = DateTime.Now.ToString();
            _shopping_cart = new Dictionary<string, int>();
        }

        public string trans_id { get { return _trans_id; } }
        public string date_of_trans { get { return _date_of_trans; } }
        public Dictionary<string, int> shopping_cart { get { return _shopping_cart; } }

        public string generateID()
        { //Generates ID based on current date and time + the corresponding customer's ID
            return "T" + DateTime.Now.ToString("yyyyMMddHHmmss") + _customer_id;
        }

    }
}
