using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassPlayers classPlayers = new ClassPlayers();
            classPlayers.Add("张三1");
            classPlayers.Add("张三2");
            classPlayers.Add("张三3");
            classPlayers.Add("张三4");

            foreach (var item in classPlayers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
