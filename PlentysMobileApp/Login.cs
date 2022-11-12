using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlentysMobileApp
{
    class Login : BaseClass
    {
        public void Positivecase(string email,string pass)
        {
            ConfigureDevice();
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[1] / android.widget.TextView").Click();
            Thread.Sleep(4000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[3] / android.view.ViewGroup / android.widget.ImageView").Click();
            Thread.Sleep(8000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.View / android.view.View[5] / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.widget.TextView").Click();
            Thread.Sleep(3000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.TextView").Click();
            Thread.Sleep(1000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[1] / android.widget.EditText").SendKeys(email);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[2] / android.widget.EditText").SendKeys(pass);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[3] / android.widget.Button / android.widget.TextView").Click();           
            driver.CloseApp();
           

        }
        public void NegativeCase(string email, string pass)
        {
            ConfigureDevice();
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[1] / android.widget.TextView").Click();
            Thread.Sleep(4000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[3] / android.view.ViewGroup / android.widget.ImageView").Click();
            Thread.Sleep(8000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.View / android.view.View[5] / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.widget.TextView").Click();
            Thread.Sleep(3000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.TextView").Click();
            Thread.Sleep(1000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[1] / android.widget.EditText").SendKeys(email);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[2] / android.widget.EditText").SendKeys(pass);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[3] / android.widget.Button / android.widget.TextView").Click();
            Thread.Sleep(6000);
            driver.CloseApp();


        }

    }
}
