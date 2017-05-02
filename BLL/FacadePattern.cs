using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 外观模式
/// </summary>
namespace BLL.FacadePattern
{
    #region 子系统的类

    public class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("子系统方法1");
        }
    }

    public class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("子系统方法2");
        }
    }

    public class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("子系统方法3");
        }
    }

    #endregion 子系统的类

    /// <summary>
    /// 外观类
    /// </summary>
    public class Facade
    {
        private SubSystemOne one;
        private SubSystemTwo two;
        private SubSystemThree three;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
        }

        public void MethodA()
        {
            Console.WriteLine("方法组A");
            one.MethodOne();
            two.MethodTwo();
        }

        public void MethodB()
        {
            Console.WriteLine("方法组B");
            two.MethodTwo();
            three.MethodThree();
        }
    }
}