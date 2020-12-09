using System;

namespace AttributeLearning
{
    /// <summary>
    /// 自定义Layout组件
    /// <para>使用属性<see cref="AttributeUsage"/>来限制属性可以设置的范围</para>
    /// <para>构造函数可以接受定义标签时传值</para>
    /// <para>属性可以继承 可以重写</para>
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Class | AttributeTargets.Method)]
    internal class LayoutBaseComponentAttribute : Attribute
    {
        private readonly string componentName;

        public LayoutBaseComponentAttribute(string componentName)
        {
            this.componentName = componentName;
        }

        public override string ToString()
        {
            return componentName;
        }

        public void Layout()
        {
            Console.WriteLine($"Layout Component Name =>{componentName}");
        }

        public virtual void DoComponentLayout()
        {
            Console.WriteLine($"Base Layout[{componentName}]");
        }

        public string ComponentName => componentName;
    }
}
