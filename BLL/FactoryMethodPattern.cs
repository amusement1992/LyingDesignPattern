using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 工厂方法模式：定义一个用于创建对象的接口，让子类决定实例化哪一个类。工厂方法使一个类的实例化延迟到其子类。
/// </summary>
namespace BLL.FactoryMethodPattern
{
    public class LeiFeng
    {
        public void Sweep()
        {
            Console.WriteLine("扫地");
        }

        public void Wash()
        {
            Console.WriteLine("洗衣");
        }

        public void BuyRice()
        {
            Console.WriteLine("买米");
        }
    }

    /// <summary>
    /// 学雷锋的大学生
    /// </summary>
    internal class Volunteer : LeiFeng
    {
    }

    /// <summary>
    /// 学雷锋的社区志愿者
    /// </summary>
    internal class Undergraduate : LeiFeng
    {
    }

    public interface IFactory
    {
        LeiFeng CreateLeiFeng();
    }

    /// <summary>
    /// 学雷锋的大学生工厂
    /// </summary>
    public class UndergraduateFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Undergraduate();
        }
    }

    /// <summary>
    /// 社区志愿者工厂
    /// </summary>
    public class VolunteerFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Volunteer();
        }
    }
}