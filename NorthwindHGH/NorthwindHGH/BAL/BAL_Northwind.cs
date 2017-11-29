using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthwindHGH.Data;

namespace NorthwindHGH.BAL
{
    public class BAL_Northwind
    {

        //my code
        public List<string> getCountries()
        {
            using (var Context = new NorthWindDataContext())
            {
                List<string> myList = (from data in Context.Customers select data.Country).Distinct().ToList();
                return myList;
            }

        }

        public List<Customer> getAllCustomer( string Country)
        {
            using (var Context = new NorthWindDataContext())
            {
                List<Customer> allCustomers = (from data in Context.Customers
                                               where data.Country == Country
                                               select data).ToList();

                return allCustomers;

                                              
            }
        }
    }
}
