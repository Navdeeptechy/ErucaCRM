//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErucaCRM.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Address
    {
        public Address()
        {
            this.Invoices = new HashSet<Invoice>();
            this.Invoices1 = new HashSet<Invoice>();
            this.Quotes = new HashSet<Quote>();
            this.Quotes1 = new HashSet<Quote>();
            this.Contacts = new HashSet<Contact>();
            this.Accounts = new HashSet<Account>();
            this.Accounts1 = new HashSet<Account>();
            this.Users = new HashSet<User>();
            this.SalesOrders = new HashSet<SalesOrder>();
            this.SalesOrders1 = new HashSet<SalesOrder>();
            this.Leads = new HashSet<Lead>();
        }
    
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public Nullable<int> CountryId { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Invoice> Invoices1 { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
        public virtual ICollection<Quote> Quotes1 { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Account> Accounts1 { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders1 { get; set; }
        public virtual ICollection<Lead> Leads { get; set; }
    }
}
