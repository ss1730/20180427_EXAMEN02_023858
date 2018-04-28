using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenMrPactito.Interfaces;

namespace ExamenMrPactito.ConcreteClasses
{
    class BackUpList:ICommand
    {
        private readonly List<ICommand> _commands;

        public BackUpList(List<ICommand> commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            _commands.Reverse();
            foreach (var commad in _commands)
            {
                commad.Undo();
            }
        }

        public void Finish()
        {
            throw new NotImplementedException();
        }

        public int GetWeight()
        {
            throw new NotImplementedException();
        }
    }
}
