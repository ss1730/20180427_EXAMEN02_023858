using ExamenMrPactito.Interfaces;

namespace ExamenMrPactito.AbstractClass.AbstractConcreteClass
{
    class ARobotCarPainter:Invocker
    {
        private readonly int _carrierWeight;
        private readonly string _pathResotre;

        public ARobotCarPainter()
        {
            _carrierWeight = 10;
            _pathResotre = "";
        }



        public override void SetCommand(ICommand iCommand)
        {
            throw new System.NotImplementedException();
        }

        public override void ExecuteCommand(int task)
        {
            throw new System.NotImplementedException();
        }

        public override void Undo(int task)
        {
            throw new System.NotImplementedException();
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
