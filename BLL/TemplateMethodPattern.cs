using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 模板方法模式：定义一个操作中的算法的骨架，而将一些步骤延迟到子类中。模板方法使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。
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