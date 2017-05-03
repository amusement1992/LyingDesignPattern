using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 装饰模式：动态地给一个对象添加一些额外的职责，就增加功能来说，装饰模式比生成子类更为灵活。
/// </summary>
namespace BLL.DecoratorPattern
{
    public abstract class Component
    {
        public abstract void Operation();
    }

    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.Write("具体操作对象的操作");
        }
    }

    public abstract class Decorator : Component
    {
        private Component c = null;

        public void SetComponent(Component c1)
        {
            this.c = c1;
        }

        public override void Operation()
        {
            if (c != null)
            {
                c.Operation();
            }
        }
    }

    public class ConcreteDecoratorA : Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "new state";
            Console.WriteLine("具体装饰对象A的操作");
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具体装饰对象B的操作");
        }

        private void AddedBehavior()
        {
            Console.WriteLine("AddedBehavior");
        }
    }
}