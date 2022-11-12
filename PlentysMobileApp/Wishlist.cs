using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlentysMobileApp
{
    class Wishlist : BaseClass
    {
        public void WishList(string email, string pass)
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
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup[2] / android.widget.Button / android.widget.TextView").Click();
            Thread.Sleep(2000);

            /*driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.View / android.view.View[3] / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.widget.TextView").Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[2] / android.widget.HorizontalScrollView / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.widget.ImageView").Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[1] / android.widget.HorizontalScrollView / android.view.ViewGroup / android.widget.HorizontalScrollView / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.ImageView").Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup[1] / android.view.ViewGroup / android.widget.ImageView").Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup[1] / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup[3]").Click();
            Thread.Sleep(2000);*/



            /*driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.View / android.view.View[5] / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.widget.TextView").Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[5] / android.view.ViewGroup / android.widget.TextView").Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[3] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup / android.widget.Button[1] / android.widget.TextView").Click();
            driver.Navigate().Back();
            Thread.Sleep(2000);*/


            /*var size = driver.Manage().Window.Size;
            int startx = size.Width / 2;
            int endx = size.Width / 2;
            int starty = (int)(size.Height * 0.50);
            int endy = (int)(size.Height * 0.10);
            TouchAction touchAction = new TouchAction(driver);
            touchAction.MoveTo(endx, endy).Release().Perform();*/

            /*Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[9] / android.view.ViewGroup / android.widget.TextView").Click();*/
            Thread.Sleep(4000);
            IPerformsTouchActions action = driver as IPerformsTouchActions;
            ITouchAction touchAction = new TouchAction(action)
                .Press(driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[6] / android.view.ViewGroup / android.view.ViewGroup[2]"))
                .Wait(5000)
                .MoveTo(driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[9] / android.view.ViewGroup / android.widget.TextView"),0, 1000)
                .Release();
            touchAction.Perform();
            Thread.Sleep(3000);

            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[9] / android.view.ViewGroup / android.widget.TextView").Click();
            driver.CloseApp();
           




            /*driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup[2] / android.widget.Button / android.view.ViewGroup / android.widget.ImageView").Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.widget.ScrollView / android.widget.LinearLayout / android.widget.LinearLayout / android.widget.LinearLayout[2] / android.widget.Button[1]").Click();
            Thread.Sleep(4000);
            Actions action = new Actions(driver);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.EditText").SendKeys("chocolate");
            action.Click(driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.widget.EditText"))
                .KeyUp(Keys.Control)
                .KeyUp(Keys.Enter)
                .Build()
                .Perform();
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[3] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup[1] / android.view.ViewGroup / android.widget.ImageView").Click();*/
        
        }
        public static void Swipe(IPerformsTouchActions driver, int startX, int startY, int endX, int endY, int duration)
        {
            ITouchAction touchAction = new TouchAction(driver)
            .Press(startX, startY)
            .Wait(duration)
            .MoveTo(endX, endY)
            .Release();

            touchAction.Perform();
        }
    }
}
