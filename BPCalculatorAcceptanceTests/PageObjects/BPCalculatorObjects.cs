﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BPCalculatorAcceptanceTests.PageObjects
{
    class BPCalculatorObjects
    {
        //The URL of the calculator to be opened in the browser
        private const string CalculatorUrl = "https://bloodpressurecalculator.azurewebsites.net/";

        //The Selenium web driver to automate the browser
        private readonly IWebDriver _webDriver;

        //The default wait time in seconds for wait.Until
        public const int DefaultWaitInSeconds = 5;



        public BPCalculatorObjects(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void goToWebsite()
        {
            _webDriver.Navigate().GoToUrl(CalculatorUrl);

        }

        //Finding elements by ID
        private IWebElement systolicElement => _webDriver.FindElement(By.CssSelector("input[id='BP_Systolic']"));
        private IWebElement diastolicElement => _webDriver.FindElement(By.CssSelector("input[id='BP_Diastolic']"));

        private IWebElement ageElement => _webDriver.FindElement(By.CssSelector("input[id='BP_Age']"));


        private IWebElement submitButtonElement => _webDriver.FindElement(By.CssSelector("input[value='Submit']"));
        private IWebElement resultElement => _webDriver.FindElement(By.CssSelector("label[id='results']"));
        private IWebElement ResetButtonElement => _webDriver.FindElement(By.Id("reset-button"));

        private IWebElement warningElement => _webDriver.FindElement(By.CssSelector("div[class='text-danger validation-summary-errors'] > ul > li:nth-of-type(1)"));

        private IWebElement ageRangeElement => _webDriver.FindElement(By.XPath("(//label[@id='results'])[2]"));

        private IWebElement mapElement => _webDriver.FindElement(By.XPath("(//label[@id='resultsValue'])[1]"));

        private IWebElement ppElement => _webDriver.FindElement(By.XPath("(//label[@id='resultsValue'])[2]"));


        public void enterSystolicNumber(string number)
        {
            //Clear text box
            systolicElement.Clear();
            //Enter text
            systolicElement.SendKeys(number);
        }

        public void clearSystolicNumber()
        {
            //Clear text box
            systolicElement.Clear();


        }

        public void enterDiastolicNumber(string number)
        {
            //Clear text box
            diastolicElement.Clear();
            //Enter text
            diastolicElement.SendKeys(number);
        }

        public void clearDiastolicNumber()
        {
            //Clear text box
            diastolicElement.Clear();

        }


        public void enterAgeNumber(string number)
        {
            //Clear text box
            ageElement.Clear();
            //Enter text
            ageElement.SendKeys(number);
        }

        public void clickSubmitButton()
        {
            //Click the add button
            submitButtonElement.Click();
        }

        public string getResults()
        {
            return resultElement.Text;
        }

        public string getInvalidMessage(String value)
        {
            IWebElement warningMessage;
            if (value.Equals("Systolic"))
            {
                warningMessage = _webDriver.FindElement(By.CssSelector("span[id='BP_Systolic-error']"));
            }
            else
            {
                warningMessage = _webDriver.FindElement(By.CssSelector("span[id='BP_Diastolic-error']"));
            }
            return warningMessage.Text;
        }

        public string getWarningMessage()
        {
            return warningElement.Text;
        }



        public string getMAPMessage()
        {
            return mapElement.Text;
        }


        public string getPPMessage()
        {
            return ppElement.Text;
        }

        public string getAgeRangeMessage()
        {
            return ageElement.Text;
        }



        public void EnsureCalculatorIsOpenAndReset()
        {
            //Open the calculator page in the browser if not opened yet
            if (_webDriver.Url != CalculatorUrl)
            {
                _webDriver.Url = CalculatorUrl;
            }
            //Otherwise reset the calculator by clicking the reset button
            else
            {
                //Click the rest button
                ResetButtonElement.Click();

                //Wait until the result is empty again
                WaitForEmptyResult();
            }
        }

        public string WaitForNonEmptyResult()
        {
            //Wait for the result to be not empty
            return WaitUntil(
                () => resultElement.GetAttribute("value"),
                result => !string.IsNullOrEmpty(result));
        }

        public string WaitForEmptyResult()
        {
            //Wait for the result to be empty
            return WaitUntil(
                () => resultElement.GetAttribute("value"),
                result => result == string.Empty);
        }


        /// <summary>
        /// Helper method to wait until the expected result is available on the UI
        /// </summary>
        /// <typeparam name="T">The type of result to retrieve</typeparam>
        /// <param name="getResult">The function to poll the result from the UI</param>
        /// <param name="isResultAccepted">The function to decide if the polled result is accepted</param>
        /// <returns>An accepted result returned from the UI. If the UI does not return an accepted result within the timeout an exception is thrown.</returns>
        private T WaitUntil<T>(Func<T> getResult, Func<T, bool> isResultAccepted) where T : class
        {
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(DefaultWaitInSeconds));
            return wait.Until(driver =>
            {
                var result = getResult();
                if (!isResultAccepted(result))
                    return default;

                return result;
            });

        }
    }
}
