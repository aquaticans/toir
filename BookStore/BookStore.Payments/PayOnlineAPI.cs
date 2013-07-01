using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Domain.Entities;

namespace BookStore.PaymentsService
{

    // Virtual Integration with Paypal Like Service
    public class PayOnlineAPI
    {

        public void GetPaymentAuthorization(string payerId, decimal subtotal, Customer custDetails)
        {
            // TODO This will call Service Method
            decimal taxes = 9.9m; // Calculate From Customer Details
            decimal shipping = 1.9m;
            decimal total = taxes + shipping + subtotal;

            // Call Paypal Like Service to Execute
            try
            {
                string token = GetPaymentAuthorization(payerId, subtotal, taxes, shipping, total);
            }

            catch (Exception e)
            {

                // If Service Down Handle
            }
        }

        public void FinalizePayment(string payerId, decimal subtotal, Customer custDetails, string paymentToken)
        {

            // TODO This will call Service Method
            decimal taxes = 9.9m; // Calculate From Customer Details
            decimal shipping = 1.9m;
            decimal total = taxes + shipping + subtotal;
            // Call Paypal Like Service to Execute
            try
            {
                bool success = ExecutePayment(payerId, subtotal, taxes, shipping, total, paymentToken);
            }
            catch (Exception e)
            {
                //Hanlde Temporary Failyre in Paypal Like SErvice
            }
        }

        public string GetPaymentAuthorization(string payerId, decimal subtotal, decimal taxes, decimal shipping, decimal total)
        {
            string paymentToken = string.Empty; // Obtained From Paypal
            return paymentToken;
        }


        public bool ExecutePayment(string payerId, decimal subtotal, decimal taxes, decimal shipping, decimal total, string paymentToken)
        {
            // Previous Authorized Token
            return false;
        }
    }
}
