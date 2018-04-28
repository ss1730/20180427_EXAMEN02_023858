using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenMrPactito.AbstractClass.AbstractConcreteClass;
using ExamenMrPactito.ConcreteRecivers;
using ExamenMrPactito.AbstractClass;
using ExamenMrPactito.ConcreteClasses;
using ExamenMrPactito.ConcreteClasses.Car;
using ExamenMrPactito.ConcreteClasses.Cook;
using ExamenMrPactito.Interfaces;

namespace ExamenMrPactito
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotRescue robotRescue = new RobotRescue();
            RobotCarPainter robotCarPainter = new RobotCarPainter();
            RobotFenceFixer robotFenceFixer = new RobotFenceFixer();
            RobotCooker robotCooker = new RobotCooker();

            Invocker robotRescueInvocker = new ARobotCarPainter();

            robotRescueInvocker.SetCommand(new BackUpList(new List<ICommand> { new CarGiveToUser(robotCarPainter,3),new CarPutInOven(robotCarPainter,1),new CookRareBurger(robotCooker,4)}));
            robotRescueInvocker.ExecuteCommand();


           
        }
    }
}
