using BusinessLogic;
using ConsolePhoneBookApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsolePhoneBookApp
{
    class Program
    { 
        static void Main(string[] args)
        {
            PhoneBook kek = new PhoneBook();
            Controller controller = new Controller(kek);
            
            controller.Start();
        }
    }
}
