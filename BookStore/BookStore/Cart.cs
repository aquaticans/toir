using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Domain.Entities
{
    public class Cart
    {

        private int _cartId;

        public int CartId
        {
            get { return _cartId; }
            set { _cartId = value; }
        }
        private int _customerID;

        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        private List<BookOrder> _bookorder;

        public List<BookOrder> Bookorder
        {
            get { return _bookorder; }
            set { _bookorder = value; }
        }
        private decimal subTotal;

        public decimal SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }
        private decimal shipping;

        public decimal Shipping
        {
            get { return shipping; }
            set { shipping = value; }
        }
        private decimal taxes;

        public decimal Taxes
        {
            get { return taxes; }
            set { taxes = value; }
        }
        private decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
    }

    public class BookOrder
    {
        private Book book;

        public Book Book
        {
            get { return book; }
            set { book = value; }
        }
        private decimal orderPrice;

        public decimal OrderPrice
        {
            get { return orderPrice; }
            set { orderPrice = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private decimal subTotal;

        public decimal SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }

    }

}
