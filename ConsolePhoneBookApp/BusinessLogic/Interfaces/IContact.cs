using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic.Interfaces
{
    public interface IContact
    {
        string Name { get; set; }
        IEnumerable<string> Numbers { get; }

        void Add( string Number );

    }
}