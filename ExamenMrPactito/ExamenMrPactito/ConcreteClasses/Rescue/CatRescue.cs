using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenMrPactito.ConcreteRecivers;
using ExamenMrPactito.Interfaces;

namespace ExamenMrPactito.ConcreteClasses.Rescue
{
    class CatRescue : ICommand
    {
        private readonly RobotRescue _robotRescue;

        public CatRescue(RobotRescue robotRescue)
        {
            _robotRescue = robotRescue;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }

        public void Finish()
        {
            throw new NotImplementedException();
        }

        public void GetWeight()
        {
            throw new NotImplementedException();
        }
    }
}
