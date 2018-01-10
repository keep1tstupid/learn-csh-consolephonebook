using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PhoneBook : IPhoneBook
    {
        private List<Contact> _contactsList = new List<Contact>(); 

        public List<Contact> ContactList
        {
            get { return _contactsList; }
        }

        //to validator
        //private bool IsUnique(string number)
        //{
        //    return !_numbers.Contains(number);
        //}

        public void Add(Contact contact)
        {
            //bool isUniqueNumber = IsUnique(number);
            _contactsList.Add(contact);
            }
        }

        //public IEnumerable<Contact> GetAll()
        //{
        //    return _contactsList;
        //}
}
