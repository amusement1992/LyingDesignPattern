using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 原型模式：用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象。
/// </summary>
namespace BLL.PrototypePattern
{
    /// <summary>
    /// 工作经历类
    /// </summary>
    public class WorkExperience : ICloneable
    {
        private string workDate;

        public string WorkDate
        {
            get { return workDate; }
            set { workDate = value; }
        }

        private string company;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }

    /// <summary>
    /// 简历类
    /// </summary>
    public class Resume : ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private WorkExperience work;

        public Resume(string name)
        {
            this.name = name;
            work = new WorkExperience();
        }

        private Resume(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
        }

        public void SetPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExperience(string workDate, string company)
        {
            work.WorkDate = workDate;
            work.Company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", name, sex, age);
            Console.WriteLine("工作经历：{0} {1}", work.WorkDate, work.Company);
        }

        public object Clone()
        {
            //return MemberwiseClone();//浅复制

            Resume obj = new Resume(this.work);//深复制
            obj.name = this.name;
            obj.sex = this.sex;
            obj.age = this.age;
            return obj;
        }
    }
}