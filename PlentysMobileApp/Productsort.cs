using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlentysMobileApp
{
    class Productsort : BaseClass
    {
        public void productsort(string categories,string subcategory, string stockavailable,string discountprice,string lowtohigh,string hightolow,string lowrate)
        {
            ConfigureDevice();
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[1] / android.widget.TextView").Click();
            Thread.Sleep(4000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[3] / android.view.ViewGroup / android.widget.ImageView").Click();
            Thread.Sleep(8000);
            driver.FindElementByXPath(categories).Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath(subcategory).Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup[3] / android.widget.Button[1] / android.view.ViewGroup / android.widget.ImageView").Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath(stockavailable).Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup[3] / android.widget.Button[1] / android.view.ViewGroup / android.widget.ImageView").Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath(discountprice).Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup[3] / android.widget.Button[1] / android.view.ViewGroup / android.widget.ImageView").Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath(lowtohigh).Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup[3] / android.widget.Button[1] / android.view.ViewGroup / android.widget.ImageView").Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath(hightolow).Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[1] / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup[3] / android.widget.Button[1] / android.view.ViewGroup / android.widget.ImageView").Click();
            Thread.Sleep(2000);
            driver.FindElementByXPath(lowrate).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            driver.CloseApp();

        }
    }
}
