using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenMrPactito.Interfaces;

namespace ExamenMrPactito.AbstractClass
{
    abstract class Invocker
    {
         public abstract void SetCommand(ICommand iCommand);
         public abstract void ExecuteCommand();
         public abstract void Undo(int task);
         public abstract int GetCarrierWeight();
        public abstract string GetBackUpPath();
    }
}
