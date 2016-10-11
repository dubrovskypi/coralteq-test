using System.Collections.Generic;

namespace Cor.Models
{
    public class NewUser
    {
        public string Salutation { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string ConfirmEmail { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }

        public UserAddress Address { get; set; }

        public List<string> BusinessArea { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public override string ToString()
        {
            string s = "";
            s = Salutation + " | " +
            FName + " | " +
            //MName  + " | " +
            LName  + " | " +
            Company  + " | " +
            Title  + " | " +
            Email  + " | " +
            ConfirmEmail  + " | " +
            Phone + " | " +
            //Fax  + " | " +
            //Mobile  + " | " +
            Address.Country +" | " +
            Address.City + " | " +
            Address.State+ " | " +

            ((BusinessArea!=null)?BusinessArea.ToString():"null") + " | " +

            Password + " | " +
            ConfirmPassword;

            return s;
        }
    }

    public class UserAddress
    {
        public string Country { get; set; }
        public string OfficeName { get; set; }
        public string Address { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}