using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeLearning
{
    /// <summary>
    /// 组件基类
    /// </summary>
    public class ComponentBase
    {
        [LayoutBaseComponent("自定义名称")]
        public string Name;

        [LayoutTextComponent("我爱你")]
        public string UserDef;
    }
}
