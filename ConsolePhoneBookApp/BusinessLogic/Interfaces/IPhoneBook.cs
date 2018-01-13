using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic.Interfaces
{ 
    public interface IPhoneBook
    {
        List<Contact> ContactList { get; } //не Enumerable потому что forEach
        void Add(Contact contact);
        //IEnumerable<Contact> GetAll();
    }
}
