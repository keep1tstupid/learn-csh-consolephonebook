using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PhoneBook : IPhoneBook
    {
        private List<Contact> _contacts = new List<Contact>();

        public IEnumerable<Contact> Contacts
        {
            get { return _contacts; }
        }

        public void Add(Contact contact)
        {
            //bool isUniqueNumber = IsUnique(number);

            _contacts.Add(contact);
        }

    }

}

    // >> to validator
    //private bool IsUnique(string number)
    //{
    //    return !_numbers.Contains(number);
    //}


    //public IEnumerable<Contact> GetAll()
    //{
    //    return _contactsList;
    //}

