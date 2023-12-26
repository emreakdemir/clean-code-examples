namespace CleanCodeConsole.Principles.SOLID;

public class InterfaceSegregationPrinciple
{
    public interface IBird
    {
        void Sound();
    }

    public interface IFly
    {
        void Fly();
    }

    public class Eagle : IBird, IFly
    {
        public void Sound()
        {
            Console.WriteLine("Sound");
        }

        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }

    public class Penguin : IBird
    {
        public void Sound()
        {
            Console.WriteLine("Sound");
        }
    }
}