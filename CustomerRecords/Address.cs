using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRecords
{
    public class Address
    {
        string _addr1,
            _addr2,
            _city,
            _province,
            _country;

        public Address (string address1, string address2, string city, string  province, string country)
        {
            this._addr1 = address1;
            this._addr2 = address2;
            this._city = city;
            this._province = province;
            this._country = country;
        }

        public string addr1
        {
            get { return _addr1; }
            set { _addr1 = value; }
        }

        public string addr2
        {
            get { return _addr2; }
            set { _addr2 = value; }
        }

        public string city
        {
            get { return _city; }
            set { _city = value; }
        }

        public string province
        {
            get { return _province; }
            set { _province = value; }
        }

        public string country
        {
            get { return _country; }
            set { _country = value; }
        }
    }
}
