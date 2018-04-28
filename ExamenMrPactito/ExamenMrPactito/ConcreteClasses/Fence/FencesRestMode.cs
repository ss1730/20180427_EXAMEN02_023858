using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenMrPactito.ConcreteRecivers;
using ExamenMrPactito.Interfaces;

namespace ExamenMrPactito.ConcreteClasses.Fence
{
    class FencesRestMode : ICommand
    {
        private readonly RobotFenceFixer _robotCarPainter;
        private readonly int _taskWeight;
        public FencesRestMode(RobotFenceFixer robotCarPainter, int weight)
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
