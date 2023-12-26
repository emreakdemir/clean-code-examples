//Bağımlılıların concrete (gerçek) nesnelerle değil soyut nesnelerle sağlanmalı.

#region BadPractice
namespace BadPractice
{
    public class ElectricEngine
    {
        public void Start()
        {
            Console.WriteLine("Electric engine started.");
        }
    }

    public class GasolineEngine
    {
        public void Start()
        {
            Console.WriteLine("Gasoline engine started.");
        }
    }

    public class Car
    {
        public void StartElectricEngine()
        {
            var electricEngine = new ElectricEngine();
            electricEngine.Start();
        }

        public void StartGasolineEngine()
        {
            var gasolineEngine = new GasolineEngine();
            gasolineEngine.Start();
        }
    }
}
#endregion

#region CleanCode
namespace GoodPractice
{
    public interface IEngine
    {
        void Start();
    }

    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Electric engine started.");
        }
    }

    public class GasolineEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Gasoline engine started.");
        }
    }

    public class Car
    {
        private readonly IEngine _engine;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void Start()
        {
            _engine.Start();
        }
    }
}
#endregion