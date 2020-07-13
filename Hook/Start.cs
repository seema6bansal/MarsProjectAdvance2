using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using MarsProjectAdvance2.Global;
using MarsProjectAdvance2.Model;
using MarsProjectAdvance2.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Bindings;

namespace MarsProjectAdvance2.Hook
{
    [Binding]
    public sealed class Start
    {
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        private ScenarioContext scenarioContextCurrent;
        private static string isLogin = "true";

        public Start(ScenarioContext scenarioContext)
        {
            scenarioContextCurrent = scenarioContext;
        }

        public static void InitializeReport()
        {
            var htmlReporter = new ExtentHtmlReporter(Base.reportsPath);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [BeforeTestRun]
        public static void SetUp()
        {
            //Initialize the Extent Report
            InitializeReport();

            //Define driver
            GlobalDefinitions.driver = new ChromeDriver();

            //Maximaize the Window
            GlobalDefinitions.driver.Manage().Window.Maximize();

            //Login to the application if user is already registered
            if (isLogin == "true")
            {
                //Populate SignIn Excel data in Collection
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.excelPath, "SignIn");

                //Get Base Url from Excel
                GlobalDefinitions.driver.Navigate().GoToUrl(GlobalDefinitions.ExcelLib.ReadData(2, "Url"));

                SignIn loginObj = new SignIn();
                loginObj.LoginStep(GlobalDefinitions.ExcelLib.ReadData(2, "UserName"), GlobalDefinitions.ExcelLib.ReadData(2, "Password"));
            }
            else
            {
                //Register to the application if user is not registered
                //Populate SignUp Excel data in Collection
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.excelPath, "SignUp");

                //Get Base Url from Excel
                GlobalDefinitions.driver.Navigate().GoToUrl(GlobalDefinitions.ExcelLib.ReadData(2, "Url"));

                SignUpDetails signUpDetailsObj = new SignUpDetails();
                signUpDetailsObj.FirstName = GlobalDefinitions.ExcelLib.ReadData(2, "FirstName");
                signUpDetailsObj.LastName = GlobalDefinitions.ExcelLib.ReadData(2, "LastName");
                signUpDetailsObj.EmailAddress = GlobalDefinitions.ExcelLib.ReadData(2, "EmailAddress");
                signUpDetailsObj.Password = GlobalDefinitions.ExcelLib.ReadData(2, "Password");
                signUpDetailsObj.ConfirmPassword = GlobalDefinitions.ExcelLib.ReadData(2, "ConfirmPassword");

                SignUp joinObj = new SignUp();
                joinObj.JoinStep(signUpDetailsObj);
                Assert.AreEqual("Registration successful", joinObj.GetPopUpMsg());
                SignIn loginObj = new SignIn();
                loginObj.LoginStep(GlobalDefinitions.ExcelLib.ReadData(2, "EmailAddress"), GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            }
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {

            featureName = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);

        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            scenario = featureName.CreateNode<Scenario>(scenarioContextCurrent.ScenarioInfo.Title);
        }

        [AfterStep]
        public void InsertReportingSteps()
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType;
            if (scenarioContextCurrent.TestError == null)
            {
                if (stepType == StepDefinitionType.Given)
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (stepType == StepDefinitionType.When)
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (stepType == StepDefinitionType.Then)
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                }

            }
            else if (scenarioContextCurrent.TestError != null)
            {
                if (stepType == StepDefinitionType.Given)
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContextCurrent.TestError.Message);
                }
                else if (stepType == StepDefinitionType.When)
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContextCurrent.TestError.Message);
                }
                else if (stepType == StepDefinitionType.Then)
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContextCurrent.TestError.Message);
                }
            }

        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            //Close all the Browsers open by Selenium
            GlobalDefinitions.driver.Quit();

            //Calling Flush to write everything to the Report
            extent.Flush();

        }
    }
}
