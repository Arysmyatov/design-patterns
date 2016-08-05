using Dp_Command.Toys;

namespace Dp_Command.Commands.Robot
{
    public class StepForward : ICommand
    {
        private Dp_Command.Toys.Robot _robot;

        public StepForward(Dp_Command.Toys.Robot robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.StepForward();
        }

        public override string ToString()
        {
            return "step forward";
        }
    }
}