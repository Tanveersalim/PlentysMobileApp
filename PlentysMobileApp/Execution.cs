using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlentysMobileApp
{
    [TestClass]

    public class Execution
    {
        //Initialize TestContext
        public TestContext instance;

        //Create Getter and Setter Method TestContext
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"PositiveLogin.csv", "PositiveLogin#csv", DataAccessMethod.Sequential)]
        [TestCategory("Login")]
        [TestCategory("Positive")]
        public void LoginPositive()
        {
            Login log = new Login();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["pass"].ToString();
            log.Positivecase(email, pass);

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"NegativeLogin.csv", "NegativeLogin#csv", DataAccessMethod.Sequential)]
        [TestCategory("Login")]
        [TestCategory("Negative")]
        public void LoginNegative()
        {
            Login log = new Login();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["pass"].ToString();
            log.Positivecase(email, pass);

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"Register.csv", "Register#csv", DataAccessMethod.Sequential)]
        [TestCategory("Register")]
        public void Register()
        {
            Register reg = new Register();
            string name = TestContext.DataRow["name"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string phone = TestContext.DataRow["phone"].ToString();
            string pass = TestContext.DataRow["pass"].ToString();
            string confirmpass = TestContext.DataRow["confirmpass"].ToString();
            reg.register(name,email,phone,pass,confirmpass);

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"Wishlist.csv", "Wishlist#csv", DataAccessMethod.Sequential)]
        [TestCategory("Wishlist")]
        public void Wishlist()
        {
            Wishlist wili = new Wishlist();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["pass"].ToString();
            wili.WishList(email,pass);

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"productsort.csv", "productsort#csv", DataAccessMethod.Sequential)]
        [TestCategory("Productsort")]
        public void Productsort()
        {
            Productsort sort = new Productsort();
            string category = TestContext.DataRow["category"].ToString();
            string subcategory = TestContext.DataRow["subcategory"].ToString();
            string stockavailable = TestContext.DataRow["stock available"].ToString();
            string discountproduct = TestContext.DataRow["discount product"].ToString();
            string lowtohighprice = TestContext.DataRow["low to high price"].ToString();
            string hightolowprice = TestContext.DataRow["high to low price"].ToString();
            string lowratings = TestContext.DataRow["low ratings"].ToString();
            sort.productsort(category,subcategory,stockavailable,discountproduct,lowtohighprice,hightolowprice,lowratings);

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"orderplaced.csv", "orderplaced#csv", DataAccessMethod.Sequential)]
        [TestCategory("orderplaced")]
        public void Orderplaced()
        {
            Orderplaced orderplaced = new Orderplaced();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["pass"].ToString();
            string category = TestContext.DataRow["category"].ToString();
            string firstname = TestContext.DataRow["firstname"].ToString();
            string lastname = TestContext.DataRow["lastname"].ToString();
            string address = TestContext.DataRow["address"].ToString();
            string phone = TestContext.DataRow["phone"].ToString();
            string postalcode = TestContext.DataRow["postalcode"].ToString();
            string instruction = TestContext.DataRow["instruction"].ToString();
            orderplaced.orderplaced(email,pass,category,firstname,lastname,address,phone,postalcode,instruction);

        }
    }
}
