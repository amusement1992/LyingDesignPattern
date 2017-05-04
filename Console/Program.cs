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
using BLL.FacadePattern;
using BLL.BuilderPattern;
using BLL.ObserverPattern;
using BLL.AbstractFactoryPattern;
using BLL.Delegate_Event;

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

            ////模板方法模式
            //AbstractClass c;
            //c = new ConcreteClassA();
            //c.TemplateMethod();

            //c = new ConcreteClassB();
            //c.TemplateMethod();
            ////c.F1();
            ////c.F2();

            ////外观类
            //Facade facade = new Facade();
            //facade.MethodA();
            //facade.MethodB();

            ////建造者模式
            //Director director = new Director();
            //Builder b1 = new ConcreteBuilder1();
            //Builder b2 = new ConcreteBuilder2();

            //director.Construct(b1);
            //Product p1 = b1.GetResult();
            //p1.Show();

            //director.Construct(b2);
            //Product p2 = b2.GetResult();
            //p2.Show();

            ////观察者模式
            //ConcreteSubject s = new ConcreteSubject();
            //s.Attach(new ConcreteObserver(s, "X"));
            //s.Attach(new ConcreteObserver(s, "Y"));
            //s.Attach(new ConcreteObserver(s, "Z"));

            //s.SubjectState = "abc";
            //s.Notify();

            ////抽象工厂模式
            //User user = new User();
            //IUser iu = DataAccess.CreateUser();
            //iu.Insert(user);
            //iu.GetUser(1);

            //委托、事件
            Cat c = new Cat("Tom");
            Mouse m1 = new Mouse("Jerry");
            Mouse m2 = new Mouse("Jack");

            c.CatShout += new Cat.CatShoutEventHandler(m1.Run);
            c.CatShout += new Cat.CatShoutEventHandler(m2.Run);

            c.Shout();

            System.Console.Read();
        }
    }
}