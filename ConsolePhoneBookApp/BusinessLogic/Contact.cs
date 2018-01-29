using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Contact: IContact    
    {
        //private string _name;
        private IList <string> _numbers = new List<string>();  

        public string Name { get; set; }
        //public string TempNumber { get; set; } 
        
        // tempopary soluton not to update controller.cs 
        // in the future controller will recieve string and put it into the PhoneBook 
        // PhoneBook will validate this string and decide: put in the list new Contact or update existing one. 

        public IList<string> Numbers
        { get { return _numbers; }
          set { _numbers = value; }
        }

        public Contact() { }

        public Contact(string name, string number) { }

        public Contact(string name, IList<string> numbers) { }

        public void Add (string Number)
        {
            _numbers.Add(Number);
        }
        public void Add(IList<string> numbers)
        {
            _numbers.Concat(numbers);
        }



        public override string ToString()
        {
            string displayNumbers = string.Join(" ", Numbers);
            return $"Someone with name {Name} has numbers {displayNumbers}"; //https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/interpolated-strings
        }
    }
}
