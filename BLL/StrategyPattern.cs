using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 策略模式：它定义了算法家族，分别封装起来，让她们之间可以互相替换，此模式让算法的变化，不会影响到使用算法的客户
/// </summary>
namespace BLL.StrategyPattern
{
    /// <summary>
    /// 现金收费抽象类
    /// </summary>
    internal abstract class CashSuper
    {
        public abstract double acceptCash(double money);
    }

    /// <summary>
    /// 正常收费
    /// </summary>
    internal class CashNormal : CashSuper
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }

    /// <summary>
    /// 打折收费
    /// </summary>
    internal class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;//折扣率

        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }

        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }

    /// <summary>
    /// 返利收费
    /// </summary>
    internal class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;//满300
        private double moneyReturn = 0.0d;//返100

        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }

        public override double acceptCash(double money)
        {
            double result = money;
            if (money >= moneyCondition)
            {
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return result;
        }
    }

    public class CashContext
    {
        private CashSuper cs = null;

        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    CashNormal cs0 = new CashNormal();
                    cs = cs0;
                    break;

                case "满300返100":
                    CashReturn cs1 = new CashReturn("300", "100");
                    cs = cs1;
                    break;

                case "打8折":
                    CashRebate cs2 = new CashRebate("0.8");
                    cs = cs2;
                    break;

                default:
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
}