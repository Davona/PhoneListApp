using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneListApp
{
    class PhoneList<T> where T : PhoneContact
    {
        public List<T> contacts;
        public PhoneList()
        {
            contacts = new List<T>();
        }
        public T FindByName(string name)
        {
            T speakercontact = null; ;
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].Name == name)
                    speakercontact = contacts[i];
            }
            return speakercontact;

        }
        public T FindByNumber(string number)
        {
            T speakercontact = null;
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].Number == number)
                    speakercontact = contacts[i];
            }
            return speakercontact;

        }
    }
}
