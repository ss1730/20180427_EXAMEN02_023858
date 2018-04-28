using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMrPactito.Interfaces
{
    interface ICommand
    {
        void Execute();
        void Undo();
        void Finish();
        int GetWeight();
    }
}
