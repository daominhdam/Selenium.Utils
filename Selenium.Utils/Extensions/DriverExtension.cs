﻿using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Selenium.Utils.Extensions
{
    public static class DriverExtensions
    {
        public static void TakeScreenshot(this IWebDriver driver, string testName)
        {
            var screenshotProvider = driver as ITakesScreenshot;
            if (screenshotProvider != null)
            {
                Screenshot ss = screenshotProvider.GetScreenshot();
                ss.SaveAsFile($"{testName}_{DateTime.Now:yyyy-MM-dd-hh-mm-ss}.acceptance-exception.png",
                    ScreenshotImageFormat.Png); //use any of the built in image formating
            }
        }

        public static void DoubleClick(this IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).DoubleClick().Build().Perform();
        }
    }
}
