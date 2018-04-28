using System;
using ExamenMrPactito.ConcreteRecivers;
using ExamenMrPactito.Interfaces;

namespace ExamenMrPactito.ConcreteClasses.Cook
{
    class CookWellDoneBurger : ICommand
    {
        private readonly RobotCooker _robotCarPainter;
        private readonly int _taskWeight;
        public CookWellDoneBurger(RobotCooker robotCarPainter, int weight)
        {
            _robotCarPainter = robotCarPainter;
            _taskWeight = weight;
        }

        public void Execute()
        {
            _robotCarPainter.Start();
        }

        public void Undo()
        {
            _robotCarPainter.Rest();
        }

        public void Finish()
        {
            _robotCarPainter.Finish();
        }

        public int GetWeight()
        {
            return _taskWeight;
        }
    }
}
