using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 模板方法模式
/// </summary>
namespace BLL.TemplateMethodPattern
{
    public abstract class AbstractClass
    {
        public abstract void F1();

        public abstract void F2();

        public void TemplateMethod()
        {
            F1();
            F2();
            Console.WriteLine("哈哈");
        }
    }

    public class ConcreteClassA : AbstractClass
    {
        public override void F1()
        {
            Console.WriteLine("A类实现了方法F1");
        }

        public override void F2()
        {
            Console.WriteLine("A类实现了方法F2");
        }
    }

    public class ConcreteClassB : AbstractClass
    {
        public override void F1()
        {
            Console.WriteLine("B类实现了方法F1");
        }

        public override void F2()
        {
            Console.WriteLine("B类实现了方法F2");
        }
    }
}