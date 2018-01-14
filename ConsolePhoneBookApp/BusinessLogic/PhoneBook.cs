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
            

            List<Contact> found = _contacts.FindAll(item => item.Name == contact.Name);
            if (found.Count == 0)
            {
                contact.Add(contact.TempNumber);
                _contacts.Add(contact);
            }

            else
            {
                found[0].Add(contact.TempNumber);
            }

        }

    }

}

// >> to validator
//private bool IsUnique(string number)
//{
//    return !_numbers.Contains(number);
//}


//bool isUniqueNumber = IsUnique(number);

//public IEnumerable<Contact> GetAll()
//{
//    return _contactsList;
//}

