using System.Collections.Generic;
using ExamenMrPactito.Interfaces;

namespace ExamenMrPactito.AbstractClass.AbstractConcreteClass
{
    class ARobotCarPainter:Invocker
    {
        private readonly int _carrierWeight;
        private readonly string _pathResotre;
        private readonly List<ICommand> _commands;

        public ARobotCarPainter()
        {
            
            _carrierWeight = 10;
            _commands = new List<ICommand>(_carrierWeight);
            _pathResotre = "";
        }

        public override void SetCommand(ICommand iCommand)
        {
            _commands.Add(iCommand);
        }

        public override void ExecuteCommand()
        {
            foreach (ICommand t in _commands)
            {
                t.Execute();
            }
        }

        public override void Undo(int task)
        {
                _commands[task].Undo();
        }

        public override int GetCarrierWeight()
        {
            return _carrierWeight;
        }

        public override string GetBackUpPath()
        {
            return _pathResotre;
        }
    }
}
