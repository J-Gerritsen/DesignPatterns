using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck robotDuck = new RobotDuck();
            ModelDuck modelDuck = new ModelDuck();


            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.PerformSwim();

            redheadDuck.Display();
            redheadDuck.PerformFly();
            redheadDuck.PerformQuack();
            redheadDuck.PerformSwim();

            decoyDuck.Display();
            decoyDuck.PerformFly();
            decoyDuck.PerformQuack();
            rubberDuck.PerformSwim();

            rubberDuck.Display();
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();
            rubberDuck.PerformSwim();

            robotDuck.Display();
            robotDuck.PerformFly();
            robotDuck.PerformQuack();
            robotDuck.PerformSwim();

            modelDuck.Display();
            
            modelDuck.PerformFly();
            modelDuck.SetFlyBehavior(new FlyWithRocket());
            modelDuck.PerformFly();

            modelDuck.PerformQuack();
            modelDuck.SetQuackBehavior(new Squeak());
            modelDuck.PerformQuack();

            modelDuck.PerformSwim();
            modelDuck.SetSwimBehavior(new Sink());
            modelDuck.PerformSwim();
        }
    }
}