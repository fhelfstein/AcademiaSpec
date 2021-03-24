using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaSpec.Abstracao
{
    public static class Utils
    {

        public static void screenshot(IWebDriver driver)
        {
            string sPath = Constantes.sSCREENSHOTPATH + getTimeStamp() + ".png";
            Screenshot file = ((ITakesScreenshot)driver).GetScreenshot();
            file.SaveAsFile(sPath, ScreenshotImageFormat.Png);
            Constantes.logImage.Add(sPath.Replace("Reports/", ""));
        }

        public static string getTimeStamp()
        {
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            return dateTime.ToString("yyyyMMdd_HHmmss");
        }

    }
}
