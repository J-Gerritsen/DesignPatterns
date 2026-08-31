using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal abstract class Duck
    {
        protected FlyBehavior FlyBehavior;

        protected QuackBehavior QuackBehavior;

        protected SwimBehavior SwimBehavior;

        public abstract void Display();

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }
        public void PerformSwim()
        {
            SwimBehavior.Swim();
        }
    }
}
