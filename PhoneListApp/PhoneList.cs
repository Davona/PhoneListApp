using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneListApp
{
    class PhoneList<T> where T : PhoneNumber
    {
        public List<T> numbers;
        public PhoneList()
        {
            numbers = new List<T>();
        }
        public T FindByName(string name)
        {
            T speaker = null; ;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i].Name == name)
                    speaker = numbers[i];
            }
            return speaker;

        }
        public T FindByNumber(string number)
        {
            T speaker = null;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i].Number == number)
                    speaker = numbers[i];
            }
            return speaker;

        }
    }
}
