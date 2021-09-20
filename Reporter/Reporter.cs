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
        public static ExtentTest testCase;

        public static void SetUpExtentReport(string reportName, string  documentTitle, dynamic path)
        {
            htmlReporter = new ExtentHtmlReporter(path);
            htmlReporter.Config.Theme = Theme.Standard;
            htmlReporter.Config.DocumentTitle = documentTitle;
            htmlReporter.Config.ReportName = reportName;


            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extendReports = extent;

        }

        public static void CreateText(string testName)
        {
            testCase = extendReports.CreateTest(testName);
        }

        public static void LogToReport(Status status,string message)
        {
            testCase.Log(status,message);
        }

        public static void FlushReport()
        {
            extendReports.Flush();
        }

        public static void TestStatus(string status)
        {
            if (status.Equals("Pass"))
            {
                testCase.Pass("Test case is passed");
            }
            else
            {
                testCase.Fail("Test case is failed");

            }
        }
    }
}
