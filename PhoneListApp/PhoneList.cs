using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneListApp
{
    class PhoneList<T> where T : PhoneContact
    {
        public List<T> numbers;
        public PhoneList()
        {
            numbers = new List<T>();
        }
        public T FindByName(string name)
        {
            T speakercontact = null; ;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i].Name == name)
                    speakercontact = numbers[i];
            }
            return speakercontact;

        }
        public T FindByNumber(string number)
        {
            T speakercontact = null;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i].Number == number)
                    speakercontact = numbers[i];
            }
            return speakercontact;

        }
    }
}
