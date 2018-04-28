using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenMrPactito.Interfaces;

namespace ExamenMrPactito.AbstractClass.AbstractConcreteClass
{
    class AMainRobot:Invocker
    {
        public override void SetCommand(ICommand iCommand)
        {
            throw new NotImplementedException();
        }

        public override void ExecuteCommand()
        {
            throw new NotImplementedException();
        }

        public override void Undo(int task)
        {
            throw new NotImplementedException();
        }

        public override int GetCarrierWeight()
        {
            throw new NotImplementedException();
        }

        public override string GetBackUpPath()
        {
            throw new NotImplementedException();
        }
    }
}
