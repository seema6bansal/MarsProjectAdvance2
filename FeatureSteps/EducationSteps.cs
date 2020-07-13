using MarsProjectAdvance2.Model;
using MarsProjectAdvance2.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MarsProjectAdvance2.FeatureSteps
{
    [Binding]
    class EducationSteps
    {
        Profile profileObj = new Profile();

        [Given(@"Seller clicks on Education tab on the profile page")]
        public void GivenSellerClicksOnEducationTabOnTheProfilePage()
        {
            profileObj.ClickOnEducationTab();

        }

        [When(@"Seller adds a new education with the following data:")]
        public void WhenSellerAddsANewEducationWithFollowingData(Table table)
        {
            var details = table.CreateSet<EducationDetails>();

            foreach (EducationDetails education in details)
            {
                profileObj.AddEducationOnProfile(education);          
            }

        }

        [Then(@"Education should be added on the profile page")]
        public void ThenEducationShouldBeAddedOnTheProfilePage()
        {
            Assert.AreEqual("Education has been added", profileObj.GetPopUpMsg());

        }

        [When(@"Seller updates the Education '(.*)' by updating University '(.*)' and Country '(.*)'")]
        public void WhenSellerUpdatesTheEducationByUpdatingUniversityAndCountry(string title, string university, string country)
        {
            profileObj.UpdateEducationOnProfile(title, university, country);
        }

        [Then(@"Education should be updated on the profile page")]
        public void ThenEducationShouldBeUpdatedOnTheProfilePage()
        {
            Assert.AreEqual("Education as been updated", profileObj.GetPopUpMsg());

        }

        [When(@"Seller deletes the Education '(.*)'")]
        public void WhenSellerDeletesTheEducation(string title)
        {
            profileObj.DeleteEducationOnProfile(title);
        }

        [Then(@"Education should be deleted on the profile page")]
        public void ThenEducationShouldBeDeletedOnTheProfilePage()
        {
            Assert.AreEqual("Education entry successfully removed", profileObj.GetPopUpMsg());

        }
    }
}
