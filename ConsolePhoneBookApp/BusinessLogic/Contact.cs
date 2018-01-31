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
        
        private IList <string> _numbers = new List<string>();  

        public string Name { get; private set; }
        

        public IList<string> Numbers
        { get { return _numbers; }
          set { _numbers = value; }
        }

        public Contact(string name, string number): this(name, new List<string>(){ number }) { } //updated

        public Contact(string name, IList<string> numbers) {
            Name = name;
            _numbers = numbers;
        }

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
