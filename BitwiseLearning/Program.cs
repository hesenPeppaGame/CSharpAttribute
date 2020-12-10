using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseLearning
{
    /// <summary>
    /// https://docs.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators?f1url=%3FappId%3DDev16IDEF1%26l%3DZH-CN%26k%3Dk(%7C_CSharpKeyword);k(TargetFrameworkMoniker-.NETFramework,Version%253Dv4.7.2);k(DevLang-csharp)%26rd%3Dtrue
    /// 一元 ~（按位求补）运算符
    /// 二进制 <<（向左移位）和 >>（向右移位）移位运算符
    /// 二进制 &（逻辑 AND）、|（逻辑 OR）和 ^（逻辑异或）运算符
    /// 这些运算符是针对 int、uint、long 和 ulong 类型定义的。 如果两个操作数都是其他整数类型（sbyte、byte、short、ushort 或 char），它们的值将转换为 int 类型，这也是一个运算的结果类型。 如果操作数是不同的整数类型，它们的值将转换为最接近的包含整数类型。 有关详细信息，请参阅 C# 语言规范的数值提升部分。
    /// &、| 和 ^ 运算符也是为 bool 类型的操作数定义的。 有关详细信息，请参阅布尔逻辑运算符。
    /// 位运算和移位运算永远不会导致溢出，并且不会在已检查和未检查的上下文中产生相同的结果。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ////~补位操作符
            uint a = 0b_1111_0000;
            uint b = ~a;
            Console.WriteLine(a);
            Console.WriteLine(Convert.ToString(a, toBase: 2));
            Console.WriteLine(b);
            Console.WriteLine(Convert.ToString(b, toBase: 2));
            Console.WriteLine(int.MaxValue / 2);
            //输出结果是正数变为负数
            //相当于 以Int为例子   补位操作符可以取(124)，补位后就是(-124)
            Console.WriteLine("==============================");






            ////左移位运算符 <<
            ////<< 运算符将其左侧操作数向左移动右侧操作数定义的位数。
            ////左移运算会放弃超出结果类型范围的高阶位，并将低阶空位位置设置为零，如以下示例所示：
            int x = 0b_0000_0000_0000_0000_0000_0000_0000_0001;
            Console.WriteLine(x);
            Console.WriteLine($"Before: {Convert.ToString(x, toBase: 2)}");
            int y = x << 3;
            Console.WriteLine(y);
            Console.WriteLine($"After:  {Convert.ToString(y, toBase: 2)}");
            //1
            //Before: 1
            //8
            //After: 1000
            Console.WriteLine("==============================");




            //& 运算符计算其整型操作数的位逻辑 AND：取位最小值
            //^ 运算符计算其整型操作数的位逻辑 OR：取位最大值
            int aa = 0b_1111_1000;
            int bb = 0b_1001_1101;
            int c = bb & aa;
            Console.WriteLine(aa);
            Console.WriteLine(bb);
            Console.WriteLine(c);
            Console.WriteLine(Convert.ToString(c, toBase: 2));
            //248
            //157
            //152
            //10011000
            Console.WriteLine("==============================");


             

            //枚举类应用
            Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
            Console.WriteLine(meetingDays);
            //Monday, Wednesday, Friday
            Console.WriteLine("==============================");

            Console.Read();
        }
    }

    [Flags]
    public enum Days
    {
        None = 0b_0000_0000,  // 0
        Monday = 0b_0000_0001,  // 1
        Tuesday = 0b_0000_0010,  // 2
        Wednesday = 0b_0000_0100,  // 4
        Thursday = 0b_0000_1000,  // 8
        Friday = 0b_0001_0000,  // 16
        Saturday = 0b_0010_0000,  // 32
        Sunday = 0b_0100_0000,  // 64
        Weekend = Saturday | Sunday
    }
}
