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
using DataTaimeList = System.Collections.Generic.List<System.DateTime>;
using System.Globalization;
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;
using BLL.StatePattern;

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

            ////委托、事件
            //Cat c = new Cat("Tom");
            //Mouse m1 = new Mouse("Jerry");
            //Mouse m2 = new Mouse("Jack");

            //c.CatShout += new Cat.CatShoutEventHandler(m1.Run);
            //c.CatShout += new Cat.CatShoutEventHandler(m2.Run);

            //c.Shout();

            ////状态模式
            //Context c = new Context(new ConcreteStateA());
            //c.Request();
            //c.Request();
            //c.Request();
            //c.Request();

            new BLL.B().Method();

            System.Console.Read();
            return;

            var d = new DataTaimeList();
            d.Add(DateTime.Now);
            d.Add(DateTime.Now);
            d.Add(DateTime.Now);
            d.Add(DateTime.Now);

            //Func<Object, ArgumentException> fn1 = null;
            //Func<string, Exception> fn2 = fn1;
            //Exception e = fn2("3");

            SimpleType st = new SimpleType();
            st.Dispose();

            IDisposable dd = st;
            dd.Dispose();

            System.Console.WriteLine("{0}:\t 所占字节数: {1}\t 最小值:{2}\t 最大值:{3}\n",
                                typeof(char).Name, sizeof(char), char.MinValue, char.MaxValue);
            Char a = 'a';
            ((IConvertible)65).ToChar(null);

            string str = "Hi" + Environment.NewLine + "there";
            CultureInfo ci = new CultureInfo("de-DE");
            String.Compare("A", "B", false, ci);

            StringInfo si = new StringInfo();
            decimal dec = 123456.789m;
            var t = dec.ToString("G");

            //Color[] colors = (Color[])Enum.GetValues(typeof(Color));
            Color[] colors = GetEnumVlues<Color>();
            foreach (var item in colors)
            {
                System.Console.WriteLine("{0:D}\t{0:G}", item);
            }

            string file = Assembly.GetEntryAssembly().Location;


            FileAttributes fa = File.GetAttributes(file);


            string[] names = new[] { "a", "b" };
            var names2 = new[] { "a", "b" };

            string[] sdf = new string[100];
            object[] oa = sdf;
            oa[5] = "jeff";

            int[] arr1 = new int[100];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = i;
            }
            int[] arr2 = new int[100];
            Array.ConstrainedCopy(arr1, 10, arr2, 10, arr1.Length - 10);

            Func<string> f = () => "aa";
            Func<int, string> f2 = (int n) => n.ToString();
            var abc = f2.Invoke(3);
            

            StaticDelegateDemo();

            System.Console.WriteLine(Enum.Format(typeof(Color), 1, "G"));

            

            System.Console.Read();
        }

        public delegate TResult Func<in T, out TResult>(T arg);

        public static List<TBase> CLa<T, TBase>(IList<T> list) where TBase : T
        {
            List<TBase> list2 = new List<TBase>();
            return list2;
        }

        public enum Color
        {
            white = 0,
            red = 1,
        }

        public static TEnum[] GetEnumVlues<TEnum>() where TEnum : struct
        {
            return (TEnum[])Enum.GetValues(typeof(TEnum));
        }


        private static void StaticDelegateDemo()
        {
            System.Console.WriteLine("------静态委托--------");
            //Counter(1, 3, null);

            Counter(1, 3, new Feedback(FeedbackToConsole));
        }
        private static void Counter(int from, int to, Feedback fb)
        {
            for (int i = from; i < to; i++)
            {
                fb?.Invoke(i);
            }
        }
        private static void FeedbackToConsole(int value)
        {
            System.Console.WriteLine("Item=" + value);
        }
    }
    internal delegate void Feedback(int value);

    public struct sss<T> where T : class, new()
    {
        public static T ff(T t)
        {
            t = null;
            return new T();
        }
    }
}

[flag]
internal sealed class SimpleType : IDisposable

{
    internal void Dispose()
    {
        System.Console.WriteLine("Dispose");
    }

    void IDisposable.Dispose()
    {
        System.Console.WriteLine("IDisposable.Dispose");
    }
}

[AttributeUsage(AttributeTargets.Class)]
internal class flagAttribute : Attribute
{
    public override string ToString()
    {
        if (this.GetType().IsDefined(typeof(FlagsAttribute), false))
        {

        }
        else
        {

        }
        return "";
    }
}

/// <summary>
/// 测试代码消耗时长
/// </summary>
public class AutoStopWatch : System.Diagnostics.Stopwatch, IDisposable
{
    public AutoStopWatch()
    {
        Start();
    }

    public void Dispose()
    {
        Stop();
        System.Console.WriteLine("Elapsed: {0}", this.ElapsedMilliseconds);
    }
}
