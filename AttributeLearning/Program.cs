using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeLearning
{
     
    class Program
    {
        static void Main(string[] args)
        {
            ComponentBase componentBase = new ComponentBase();
            componentBase.Name = "layout";
            var Fields = componentBase.GetType().GetFields();
            foreach (var item in Fields)
            {
                var attrInfos = Attribute.GetCustomAttributes(item);
                foreach (Attribute attrinfo in attrInfos)
                {
                    if (attrinfo is LayoutTextComponentAttribute func)
                    {
                        func.Layout();
                    }
                }
            }

            Console.WriteLine("===============================================");
       
            //循环查找当前程序集所有的自定义属性
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly assemblie in assemblies)
            {
                IEnumerable<TypeInfo> types = assemblie.DefinedTypes;
                foreach (TypeInfo type in types)
                {
                    var fields =  type.GetFields();
                    foreach (var field in fields)
                    {
                        Attribute[] attributes = Attribute.GetCustomAttributes(field, typeof(LayoutBaseComponentAttribute));
                        foreach (Attribute attribute in attributes)
                        {
                            if (attribute is LayoutBaseComponentAttribute func)
                            {
                                func.DoComponentLayout();
                            }
                        }
                    }
                }  
            }
           
            Console.Read();
        }
    }
}
