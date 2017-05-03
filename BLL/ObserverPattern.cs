using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 观察者模式：定义了一种一对多的依赖关系，让多个观察者对象同时监听某一个主题对象。这个主题对象在状态发生变化时，会通知所有观察者对象，使它们能够自动更新自己。
/// </summary>
namespace BLL.ObserverPattern
{
    /// <summary>
    /// 抽象通知者
    /// </summary>
    public abstract class Subject
    {
        private IList<Observer> observers = new List<Observer>();

        /// <summary>
        /// 增加观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// 减少观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }
    }

    /// <summary>
    /// 具体通知者
    /// </summary>
    public class ConcreteSubject : Subject
    {
        private string subjectState;

        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }

    /// <summary>
    /// 抽象观察者类
    /// </summary>
    public abstract class Observer
    {
        public abstract void Update();
    }

    /// <summary>
    /// 具体观察者
    /// </summary>
    public class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("观察者{0}的新状态是{1}", name, observerState);
        }

        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}