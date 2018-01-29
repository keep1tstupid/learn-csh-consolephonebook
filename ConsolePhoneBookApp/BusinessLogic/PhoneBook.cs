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
        private List<IContact> _contacts = new List<IContact>();

        public IList<IContact> Contacts
        {
            get { return _contacts; }
        }

        public void Add(IContact contact)
        {
            List<IContact> founded = _contacts.FindAll(item => item.Name == contact.Name);
            if (founded.Count == 0)
            {
                _contacts.Add(contact);
            }

            else
            {
                founded[0].Add(contact.Numbers);
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

