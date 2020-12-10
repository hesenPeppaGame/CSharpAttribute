using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableLearning
{
    public class ClassPlayers
    {
        private List<string> userNames = new List<string>();

        public void Add(string name)
        {
            userNames.Add(name);
        }

        public string this[int index]
        {
            get
            {
                return userNames[index];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new UserCustomerEnumerator(userNames);
        }
    }
}
