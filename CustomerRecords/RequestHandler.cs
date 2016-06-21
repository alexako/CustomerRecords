using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerRecords
{
    public class RequestHandler
    {
        Record record;

        public RequestHandler()
        {
            record = Record.getInstance();
        }

        //Return all customers on record
        public Dictionary<string, Customer> GetCustomerList { get { return record.customers; } }
        //Return all transactions on record
        public Dictionary<string, Transaction> GetTransactionsList { get { return record.transactions; } }
        //Return the Shopping Menu
        public Dictionary<string, double> GetShoppingMenu { get { return record.menuItems; } }

        //Return a customer based on a given customer_id
        public Customer getCustomer(string customer_id)
        {
            if (record.customers.ContainsKey(customer_id))
                return record.customers[customer_id];
            else
                return null;
        }

        public void addCustomerToRecords(Customer customer_to_add)
        {
            record.add(customer_to_add);
        }

        public void deleteCustomerFromRecords(Customer customer_to_delete)
        {
            record.delete(customer_to_delete);
        }

        /// <summary>
        /// Return list of transactions of a given customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public List<Transaction> getTransactions(Customer customer)
        {
            return getTransactions(customer.customer_id);
        }
        public List<Transaction> getTransactions(string customer_id)
        {
            List<Transaction> transactions = new List<Transaction>();
            foreach (var transaction in record.transactions)
            {
                if (transaction.Key.Contains(customer_id))
                    transactions.Add(transaction.Value);
            }
            return transactions;
        }

        /// <summary>
        /// Removes all transactions associated to a given customer. 
        /// Can pass a customer ID or a Customer object
        /// </summary>
        /// <param name="customer"></param>
        public void deleteTransactions(Customer customer)
        {
            if (customer == null) Console.WriteLine("Must pass a customer ID or Customer object");
            else
            {
                List<Transaction> removals = new List<Transaction>(); //Create temp list of objects for removals
                foreach (var trans in record.transactions)
                {
                    if (trans.Key.Contains(customer.customer_id))
                        removals.Add(trans.Value); //Add transaction to list of removals
                }
                //Remove transaction objects from records 
                foreach (var trans in removals) //Iterate temp list of removals
                    record.delete(trans);
            }
        }

        public Transaction createNewTransaction(Customer customer)
        {
            return new Transaction(customer.customer_id);
        }
        public Transaction createNewTransaction(string customer_id)
        {
            return new Transaction(customer_id);
        }

        public void addTransactiontoRecord(Transaction tranasction)
        {
            record.add(tranasction);
        }
    }
}