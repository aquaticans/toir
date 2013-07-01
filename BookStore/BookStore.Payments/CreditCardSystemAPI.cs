using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Domain.Entities;

namespace BookStore.PaymentsService
{   // Virtual Integration With Credit Card System Like Authorize
    public class CreditCardSystemAPI
    {
        public void GetPaymentAuthorization(string type, string method, string cardnum, string expDate, decimal amount, Customer custDetails)
        {

            // TODO This will call Service Method
            Dictionary<string, string> post_values = new Dictionary<string, string>();
            // Call Authorize.Net using AIM Advanced Integration Method for Approval
            try
            {
                bool success = CallAuthorizeAPI(post_values);
            }

            catch (Exception e)
            {
                // Gracefully Handle Payment Exception.
                // If Authorize is Down try another service?? Paypal Credit Card Transaction
                // Indicate to user if they should try alternate payment method
            }
        }

        private bool CallAuthorizeAPI(Dictionary<string, string> post_values)
        {
            // Integrate with Authorize API
            return false;
        }


    }
}
