using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlentysMobileApp
{
    class Register : BaseClass
    {
        public void register(string name,string email,string phone,string pass,string confirmpass)
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
            Thread.Sleep(2000);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup[2] / android.view.ViewGroup / android.widget.TextView[1]").Click();
            Thread.Sleep(5000);
            driver.HideKeyboard();
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[3] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[1] / android.widget.EditText").SendKeys(name);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[3] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[2] / android.widget.EditText").SendKeys(email);
            driver.FindElementByAccessibilityId("Telephone input").SendKeys(phone);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[3] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[4] / android.widget.EditText").SendKeys(pass);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[3] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[5] / android.widget.EditText").SendKeys(confirmpass);
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[3] / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup / android.view.ViewGroup[2] / android.view.ViewGroup / android.widget.ScrollView / android.view.ViewGroup / android.view.ViewGroup[7] / android.widget.Button / android.widget.TextView").Click();
            Thread.Sleep(6000);

        }
       

    }
}
