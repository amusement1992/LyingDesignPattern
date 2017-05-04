using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 委托、事件
/// </summary>
namespace BLL.Delegate_Event
{
    //有一只猫（Tom），有2只老鼠（Jerry、Jack），Tom只要叫一声‘瞄，我是Tom’，两只老鼠就说‘老猫来了，快跑’。

    public class Cat
    {
        private string name;

        public Cat(string name)
        {
            this.name = name;
        }

        public delegate void CatShoutEventHandler();

        public event CatShoutEventHandler CatShout;

        public void Shout()
        {
            Console.WriteLine("瞄，我是" + name);

            if (CatShout != null)
            {
                CatShout();
            }
        }
    }

    public class Mouse
    {
        private string name;

        public Mouse(string name)
        {
            this.name = name;
        }

        public void Run()
        {
            Console.WriteLine("老猫来了，快跑");
        }
    }
}