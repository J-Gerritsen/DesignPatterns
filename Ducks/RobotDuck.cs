using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    class RobotDuck : Duck
    {
        public RobotDuck()
        {
            QuackBehavior = new MuteQuack();
            FlyBehavior = new FlyNoWay();
            SwimBehavior = new Sink();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Robot Duck");
        }
    }
}
