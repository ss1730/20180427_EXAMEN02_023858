﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenMrPactito.Interfaces;

namespace ExamenMrPactito.ConcreteClasses
{
    class NonCommand:ICommand
    {
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

        public int GetWeight()
        {
            throw new NotImplementedException();
        }
    }
}
