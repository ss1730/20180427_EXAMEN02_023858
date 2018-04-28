using System;
using ExamenMrPactito.Interfaces;

namespace ExamenMrPactito.AbstractClass.AbstractConcreteClass
{
    class ARobotCooker:Invocker
    {
        public override void SetCommand(ICommand iCommand)
        {
            throw new NotImplementedException();
        }

        public override void ExecuteCommand(int task)
        {
            throw new NotImplementedException();
        }

        public override void Undo(int task)
        {
            throw new NotImplementedException();
        }

        public override void GetCarrierWeight()
        {
            throw new NotImplementedException();
        }
    }
}
