using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic.Interfaces
{ 
    public interface IPhoneBook
    {
        IList<IContact> Contacts { get; } 
        void Add(IContact contact);
        //IEnumerable<Contact> GetAll();
    }
}


