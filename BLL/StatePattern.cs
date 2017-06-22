﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 状态模式：
/// </summary>
namespace BLL.StatePattern
{
    public abstract class State
    {
        public abstract void Handle(Context context);
    }

    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }

    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }

    public class Context
    {
        private State state;

        public Context(State state)
        {
            this.state = state;
        }

        public State State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("当前状态：" + state.GetType().Name);
            }
        }
        public void Request()
        {
            state.Handle(this);
        }
    }

}
