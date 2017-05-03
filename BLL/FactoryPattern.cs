using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 工厂模式：用一个单独的类来做这个创造实例的过程，这就是工厂。
/// </summary>
namespace BLL.FactoryPattern
{
    /// <summary>
    /// 运算类
    /// </summary>
    public class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    /// <summary>
    /// 加法类
    /// </summary>
    internal class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }

    /// <summary>
    /// 减法类
    /// </summary>
    internal class OperationSub : Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }

    /// <summary>
    /// 乘法类
    /// </summary>
    internal class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }

    /// <summary>
    /// 除法类
    /// </summary>
    internal class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
            {
                throw new Exception("除数不能为0！");
            }
            return NumberA / NumberB;
        }
    }

    /// <summary>
    /// 工厂类
    /// </summary>
    public class OperationFactory
    {
        public static Operation createOperate(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;

                case "-":
                    oper = new OperationSub();
                    break;

                case "*":
                    oper = new OperationMul();
                    break;

                case "/":
                    oper = new OperationDiv();
                    break;

                default:
                    break;
            }
            return oper;
        }
    }
}