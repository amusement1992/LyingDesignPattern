using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 代理模式：为其他对象提供一种代理以控制对这个对象的访问。
/// </summary>
namespace BLL.ProxyPattern
{
    /// <summary>
    /// 被追求者
    /// </summary>
    public class SchollGirl
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    /// <summary>
    /// 代理接口
    /// </summary>
    internal interface IGiveGift
    {
        void GiveDolls();

        void GiveFlowers();

        void GiveChocolate();
    }

    /// <summary>
    /// 追求者
    /// </summary>
    internal class Pursuit : IGiveGift
    {
        private SchollGirl mm;

        public Pursuit(SchollGirl mm)
        {
            this.mm = mm;
        }

        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + " 送你洋娃娃！");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(mm.Name + " 送你鲜花！");
        }

        public void GiveChocolate()
        {
            Console.WriteLine(mm.Name + " 送你巧克力！");
        }
    }

    /// <summary>
    /// 代理类
    /// </summary>
    public class Proxy : IGiveGift
    {
        private Pursuit gg;

        public Proxy(SchollGirl mm)
        {
            gg = new Pursuit(mm);
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }

        public void GiveDolls()
        {
            gg.GiveDolls();
        }

        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }
    }
}