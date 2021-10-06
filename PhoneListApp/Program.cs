using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneList<PhoneNumber> phoneList = new PhoneList<PhoneNumber>();
            phoneList.numbers.Add(new Friend("Aram", "09834596"));
            phoneList.numbers.Add(new Supplier("Vazgen", "52694865"));
            phoneList.numbers.Add(new Friend("Karen", "09248646"));
            phoneList.numbers.Add(new Supplier("Misak", "0202525"));
            PhoneNumber Friend = phoneList.FindByName("Aram");
            PhoneNumber Supplier = phoneList.FindByName("Vazgen");
            PhoneNumber Friend1 = phoneList.FindByName("Karen");
            Console.WriteLine(Friend.Name+" "+ Friend.Number);
            PhoneNumber Supplier1 = phoneList.FindByNumber("0202525");
            Console.WriteLine(Supplier1.Name+ " "+ Supplier1.Number);
           
        }
    }
}
