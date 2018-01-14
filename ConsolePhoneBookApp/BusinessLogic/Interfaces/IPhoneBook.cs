using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic.Interfaces
{ 
    public interface IPhoneBook
    {
        IEnumerable<Contact> Contacts { get; } 
        void Add(Contact contact);
        //IEnumerable<Contact> GetAll();
    }
}


