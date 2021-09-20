using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

namespace APIApplication
{
    public static class Reporter
    {
        public static ExtentReports extendReports;
        public static ExtentReports extent;
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentTest textCase;

        public static void SetUpExtentReport(string reportName, string  documentTitle, dynamic path)
        {
            htmlReporter = new ExtentHtmlReporter(path);
            htmlReporter.Config.Theme = Theme.Dark;
            htmlReporter.Config.DocumentTitle = documentTitle;
            htmlReporter.Config.ReportName = reportName;


            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extendReports = extent;





        }

    }
}
