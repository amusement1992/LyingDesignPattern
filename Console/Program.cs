using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DecoratorPattern;
using BLL.ProxyPattern;

namespace Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ////装饰模式
            //ConcreteComponent c = new ConcreteComponent();
            //ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            //ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            //d1.SetComponent(c);
            //d2.SetComponent(d1);
            //d2.Operation();

            SchollGirl mm = new SchollGirl();
            mm.Name = "敏敏";

            Proxy p = new Proxy(mm);

            p.GiveDolls();
            p.GiveChocolate();
            p.GiveFlowers();

            System.Console.Read();
        }
    }
}