namespace CleanCodeConsole.Principles;

public class Readability
{
    #region BadPractice
    private int a = 10;
    private int x = 120; //4 ayın gün değeri
    private bool fazlaMesaiVar = false;
    private bool HAS_OVER_TIME = false;
    private bool hasSupport = true;
    #endregion

    #region CleanCode
    private int daysInFourMonth = 120;
    private bool hasOverTime = false;
    #endregion

    #region BadPractice
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
    public void ApplyManHour(ManHourType manHourType)
    {
        if (manHourType == ManHourType.Normal)
        {
            //some code
        }
        else if (manHourType == ManHourType.Overtime)
        {
            //some code
        }
    }

    public enum ManHourType
    {
        Normal = 0,
        Overtime = 1,
    }
    #endregion

    #region BadPractice
    public double Total(double a, double tax)
    {
        return a + (a * tax);
    }
    #endregion

    #region CleanCode
    public double CalculatePriceWithTax(double price, double tax)
    {
        return price + (price * tax);
    }
    #endregion
}