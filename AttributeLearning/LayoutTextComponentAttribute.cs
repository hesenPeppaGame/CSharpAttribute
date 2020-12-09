using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeLearning
{
    /// <summary>
    /// 属性可以继承 可以重写
    /// </summary>
    internal sealed class LayoutTextComponentAttribute : LayoutBaseComponentAttribute
    {
        public LayoutTextComponentAttribute(string componentName) : base(componentName)
        {
        }

        public override void DoComponentLayout()
        {
            Console.WriteLine($"Child Layout[{ComponentName}]");
        }
    }
}
