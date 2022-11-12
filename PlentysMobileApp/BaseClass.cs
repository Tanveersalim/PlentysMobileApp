using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlentysMobileApp
{
    public class BaseClass
    {
        public  static AppiumDriver<AndroidElement> driver;
        public static AppiumOptions caps = new AppiumOptions();


        public static void ConfigureDevice()
        {
            caps.AddAdditionalCapability("deviceName", "My Phone");
            caps.AddAdditionalCapability("udid", "192.168.1.48:35419");
            caps.AddAdditionalCapability("PlatformName", "Android");
            caps.AddAdditionalCapability("PlatformVersion", "11.0");
            caps.AddAdditionalCapability("appPackage", "com.plentys.pk.android");
            caps.AddAdditionalCapability("appActivity", "com.plentys.pk.android.MainActivity");
            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), caps);
        }
    }
}