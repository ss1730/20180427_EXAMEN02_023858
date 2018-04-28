using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMrPactito.ConcreteRecivers
{
    class RobotCarPainter
    {



        public void Finish()
        {
            Console.WriteLine("Ya Termine");
        }

        public void Start()
        {
            Console.WriteLine("Ya Inicie");
        }

        public void Wait()
        {
            Console.WriteLine("Ya estoy esperando");
        }

        public void Rest()
        {
            Console.WriteLine("Ya estoy descansando");
        }
    }
}
