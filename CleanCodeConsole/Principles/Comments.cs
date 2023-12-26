namespace CleanCodeConsole.Principles;

public class Comments
{
    #region BadPractices
    //Bu satır toplam değeri 10 olarak atar.
    private int Total = 10;
    
    //Adam saat tipine göre ücret uygulaması yapar.
    //tip 0 normale denk gelirken tip 1 fazla mesai demektir.
    public void Apply(int type)
    {
        if (type == 0)
        {
            //some code
        }
        else if (type == 1)
        {
            //some code
        }
    }
    
    #endregion

    #region CleanCode
    // TODO: Bu kısım daha sonra optimize edilmelidir.
    // BUG: Bu kısımda bilinen x açığı bulunmakta.
    public void ProcessData()
    {
        // ...
    }
    
    // Bu algoritma, Recursive method çağırımı tekniği kullanarak Fibonacci sayılarını hesaplar.
    public int Fibonacci(int n)
    {
        // ...
        return 0;
    }

    /// <summary>
    /// Calculates the factorial of a given number.
    /// </summary>
    /// <param name="n">The number to calculate the factorial of.</param>
    /// <returns>The factorial of the given number. If the given number is less than 0, returns 0.</returns>
    public int Factorial(int n)
    {
        // ...
        return 0;
    }
    
    #endregion
}