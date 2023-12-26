namespace CleanCodeConsole.Principles.SOLID;

public class SingleResponsibilityPrinciple
{
    #region BadPractice
    public class Report
    {
        public void GenerateReport()
        {
            /* ... */
        }

        public void SaveToFile()
        {
            /* ... */
        }
    }
    #endregion

    #region CleanCode
    public class Reporter
    {
        public void Generate()
        {
            /* ... */
        }
    }

    public class FileSaver
    {
        public void Save()
        {
            /* ... */
        }
    }

    public class ReportManager
    {
        public void Generate()
        {
            var report = new Reporter();
            report.Generate();
            var fileSaver = new FileSaver();
            fileSaver.Save();
        }
    }
    #endregion
}