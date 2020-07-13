using MarsProjectAdvance2.Global;
using MarsProjectAdvance2.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsProjectAdvance2.FeatureSteps
{
    [Binding]
    class ChangePasswordSteps
    {
        Profile profileObj = new Profile();

        [Given(@"Seller clicks on Change Password on the profile page")]
        public void GivenSellerClicksOnChangePasswordOnTheProfilePage()
        {
            profileObj.ClickOnChangePassword();
        }

        [When(@"Seller enters valid credintals '(.*)', '(.*)', '(.*)'")]
        public void WhenSellerEntersValidCredintals(string currentPassword, string newPassword, string confirmPassword)
        {
            //Populate Profile Excel data in Collection        
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.excelPath, "ChangePassword");

            currentPassword = GlobalDefinitions.ExcelLib.ReadData(2, "CurrentPassword");
            newPassword = GlobalDefinitions.ExcelLib.ReadData(2, "NewPassword");
            confirmPassword = GlobalDefinitions.ExcelLib.ReadData(2, "ConfirmPassword");
            profileObj.EnterChangePasswordCredintals(currentPassword, newPassword, confirmPassword);
        }

        [Then(@"Sellers's password should be changed successfully")]
        public void ThenSellersSPasswordShouldBeChangedSuccessfully()
        {
            Assert.AreEqual("Password Changed Successfully", profileObj.GetPopUpMsg());
        }

    }
}
