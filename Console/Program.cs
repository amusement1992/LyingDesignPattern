using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DecoratorPattern;
using BLL.ProxyPattern;
using BLL.FactoryMethodPattern;
using BLL.PrototypePattern;
using BLL.TemplateMethodPattern;

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

            ////代理模式
            //SchollGirl mm = new SchollGirl();
            //mm.Name = "敏敏";

            //Proxy p = new Proxy(mm);

            //p.GiveDolls();
            //p.GiveChocolate();
            //p.GiveFlowers();

            ////工厂方法模式
            //IFactory factory = new UndergraduateFactory();
            //LeiFeng student = factory.CreateLeiFeng();

            //student.BuyRice();
            //student.Sweep();
            //student.Wash();

            ////原型模式
            //Resume a = new Resume("张三");
            //a.SetPersonalInfo("男", "19");
            //a.SetWorkExperience("2001-1-2", "aa公司");

            //Resume b = (Resume)a.Clone();
            //b.SetWorkExperience("2001-1-3", "bb公司");

            //Resume c = (Resume)a.Clone();
            //c.SetPersonalInfo("男", "20");
            //c.SetWorkExperience("2001-1-4", "cc公司");

            //a.Display();
            //b.Display();
            //c.Display();

            //模板方法模式
            AbstractClass c;
            c = new ConcreteClassA();
            c.TemplateMethod();

            c = new ConcreteClassB();
            c.TemplateMethod();
            //c.F1();
            //c.F2();

            System.Console.Read();
        }
    }
}