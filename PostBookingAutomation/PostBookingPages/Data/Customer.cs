using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PostBookingPages.Data
{
    public class Customer
    {
        public string EmailAddress { get; set; }
        public string EmailConfirmAddress { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string MobileNumber { get; set; }

        public Customer()
        {
            EmailAddress = "jahangir.ali@easyjet.com";
            EmailConfirmAddress = "jahangir.ali@easyjet.com";
            Password = "password123";
            PasswordConfirm = "password123";
            Title = "Mrs";
            FirstName = "Ryu";
            Surname = "Ali";
            Address1 = "123 High Street";
            Address2 = "";
            Postcode = "LU1";
            City = "Luton";
            Country = "United Kingdom";
            MobileNumber = "0123456789";
            
        }
    }
    
}
