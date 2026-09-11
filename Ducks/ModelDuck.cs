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
    internal class ModelDuck : Duck
    {
        public ModelDuck()
        {
            QuackBehavior = new MuteQuack();
            FlyBehavior = new FlyNoWay();
            SwimBehavior = new Float();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Model Duck");
        }
    }
}
