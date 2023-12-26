namespace CleanCodeConsole.Principles.SOLID;

public class LiskovSubstitutionPrinciple
{
    #region BadPractice
    public interface IBird
    {
        void Sound();

        void Fly();
    }

    public class Eagle : IBird
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

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}