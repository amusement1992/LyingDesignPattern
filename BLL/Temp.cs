using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace BLL
{
    public class B
    {
        public void Method()
        {
            //Thread th = new Thread(ComOp);

            ////th.IsBackground = true;
            //th.Start(5);

            //Console.WriteLine(1);

            //Console.WriteLine(1);
            //ThreadPool.QueueUserWorkItem(ComOp, 5);
            //Console.WriteLine(2);
            ////Thread.Sleep(10000);
            //Console.WriteLine(3);

    

        }

        private static void ComOp(Object state)
        {
            //Thread.Sleep(10000);
            Console.WriteLine(state);
        }
    }

    public interface aaa
    {
        int a();
        string b();
    }

    public class bbb : aaa,ccc
    {
        public int a()
        {
            throw new NotImplementedException();
        }

        public int a(int a)
        {
            throw new NotImplementedException();
        }

        public string b()
        {
            throw new NotImplementedException();
        }
    }

    public interface ccc
    {
        int a();
    }
}
