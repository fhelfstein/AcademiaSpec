using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaSpec.Abstracao
{
    public class Constantes
    {
        public const string sBROWSER = "Chrome";
        public const int iTIMEOUT = 20;
        public const string sURL = "http://automationpractice.com/index.php";
        public const string sREPORTPATH = "./Report";
        public const string sSCREENSHOTPATH = "./Screenshots/";

        public static ExtentReports _extent;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;
        public static IList<string> logInfo = new List<string>();
        public static IList<string> logImage = new List<string>();

    }
}
