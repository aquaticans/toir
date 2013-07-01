using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Domain.Entities
{
    public class Customer
    {

        private int customerId;

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        private string emailAddress;

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string middleInitial;

        public string MiddleInitial
        {
            get { return middleInitial; }
            set { middleInitial = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string billAddressLine1;

        public string BillAddressLine1
        {
            get { return billAddressLine1; }
            set { billAddressLine1 = value; }
        }
        private string billAddressLine2;

        public string BillAddressLine2
        {
            get { return billAddressLine2; }
            set { billAddressLine2 = value; }
        }
        private string billCity;

        public string BillCity
        {
            get { return billCity; }
            set { billCity = value; }
        }
        private string billState;

        public string BillState
        {
            get { return billState; }
            set { billState = value; }
        }
        private string billZipPostal;

        public string BillZipPostal
        {
            get { return billZipPostal; }
            set { billZipPostal = value; }
        }
        private int billCountryId;

        public int BillCountryId
        {
            get { return billCountryId; }
            set { billCountryId = value; }
        }
        private string billCountry;

        public string BillCountry
        {
            get { return billCountry; }
            set { billCountry = value; }
        }

        private string shipAddressLine1;

        public string ShipAddressLine1
        {
            get { return shipAddressLine1; }
            set { shipAddressLine1 = value; }
        }
        private string shipAddressLine2;

        public string ShipAddressLine2
        {
            get { return shipAddressLine2; }
            set { shipAddressLine2 = value; }
        }
        private string shipCity;

        public string ShipCity
        {
            get { return shipCity; }
            set { shipCity = value; }
        }
        private string shipState;

        public string ShipState
        {
            get { return shipState; }
            set { shipState = value; }
        }
        private string shipZipPostal;

        public string ShipZipPostal
        {
            get { return shipZipPostal; }
            set { shipZipPostal = value; }
        }
        private int shipCountryId;

        public int ShipCountryId
        {
            get { return shipCountryId; }
            set { shipCountryId = value; }
        }
        private string shipcountry;

        public string Shipcountry
        {
            get { return shipcountry; }
            set { shipcountry = value; }
        }

        #region Methods

        public decimal CalculateShippingFees(decimal subTotal)
        {
            // TODO Calculate Shipping Based on Location
            decimal percentageShipFees = 2.9m;

            return subTotal * percentageShipFees / 100;
        }

        public decimal CalculateTaxes(decimal subTotal)
        {
            // TODO Calculate Taxes Based on Location
            decimal percentageTaxFees = 2.9m;
            return subTotal * percentageTaxFees / 100;
        }

        #endregion

    }
}
