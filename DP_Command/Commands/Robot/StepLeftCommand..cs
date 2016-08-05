
namespace Dp_Command.Commands.Robot
{
    public class StepLeft : ICommand
    {
        private Dp_Command.Toys.Robot _robot;


        public StepLeft(Dp_Command.Toys.Robot robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.StepLeft();
        }

        public override string ToString()
        {
            return "step left";
        }
    }
}