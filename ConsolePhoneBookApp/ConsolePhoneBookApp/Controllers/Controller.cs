using BusinessLogic;
using BusinessLogic.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsolePhoneBookApp.Controllers
{
    class Controller : IController  
    {
        private IPhoneBook _myPhoneBook;
        private IList<string> userNumbers;

        public Controller(IPhoneBook book)
        {
            _myPhoneBook = book; 
        }

        private void SaveUserInputIntoPhoneBook()
        {
            Console.Write("Enter name and number: ");
            string input = Console.ReadLine();
            IList<string> splittedInput = input.Split(' ');
            IContact person = new Contact();
            person.Name = splittedInput[0];
            userNumbers = new List<string>();
            userNumbers.Add(splittedInput[1].ToString());
            person.Numbers = userNumbers;
            _myPhoneBook.Add(person);
        }
        private void ShowNumbersList()
        {
            Console.WriteLine("Saved phone numbers: ");
            List<IContact> allNumbers = _myPhoneBook.Contacts.ToList();
            allNumbers.ForEach(item => Console.WriteLine(item));
            //foreach(string number in allNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("I can: \n1.Add new contact \n2.Show all numbers \n3.Exit \nEnter num of action.");

                int command = 0;

                int.TryParse(Console.ReadLine(), out command);


                switch (command)
                {
                    case 1:
                        SaveUserInputIntoPhoneBook();
                        break;
                    case 2:
                        ShowNumbersList();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Something went wrong, try again");
                        break;
                }
            }
        }

        public void Stop() { }
    }
}

