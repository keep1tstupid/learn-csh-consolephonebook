using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Contact
    {
        private string _name;
        private string _number;
    
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public override string ToString()
        {
            return $"Someone with name {_name} has number {_number}"; //https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/interpolated-strings
        }
    }
}
