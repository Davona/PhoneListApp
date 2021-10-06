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
            PhoneList<PhoneContact> phoneList = new PhoneList<PhoneContact>();
            phoneList.numbers.Add(new FriendContact("Aram", "09834596"));
            phoneList.numbers.Add(new SupplierContact("Vazgen", "52694865"));
            phoneList.numbers.Add(new FriendContact("Karen", "09248646"));
            phoneList.numbers.Add(new SupplierContact("Misak", "0202525"));
            PhoneContact Friend = phoneList.FindByName("Aram");
            PhoneContact Supplier = phoneList.FindByName("Vazgen");
            PhoneContact Friend1 = phoneList.FindByName("Karen");
            Console.WriteLine(Friend.Name+" "+ Friend.Number);
            PhoneContact Supplier1 = phoneList.FindByNumber("0202525");
            Console.WriteLine(Supplier1.Name+ " "+ Supplier1.Number);
           
        }
    }
}
