using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic.Interfaces
{
    public interface IContact
    {
        string Name { get;  }

        IList<string> Numbers { get; set; }

        void Add(string Number );
        void Add(IList<string> numbers);
    }
}