using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableLearning
{
    public class UserCustomerEnumerator : IEnumerator
    {
        private List<string> userNames = new List<string>();
        private int curIndex = -1;

        public UserCustomerEnumerator(List<string> userNames)
        {
            this.userNames = userNames;
        }

        public object Current => userNames[curIndex];

        public bool MoveNext()
        {
            curIndex++;
            if (curIndex < userNames.Count)
            {
                return true;
            }

            return false;
        }

        public void Reset()
        {
            curIndex = -1;
        }
    }
}
