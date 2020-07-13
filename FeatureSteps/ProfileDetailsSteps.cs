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
    class ProfileDetailsSteps
    {
        Profile profileObj = new Profile();

        [Given(@"Seller is on the profile page")]
        public void GivenSellerIsOnTheProfilePage()
        {
            profileObj.ClickOnProfileTab();
        }

        [When(@"Seller adds the Availability '(.*)'")]
        public void WhenSellerAddsTheAvailability(string availability)
        {
              profileObj.EditAvailabilityOnProfile(availability);
        }

        [Then(@"Availability should be added on the profile page")]
        public void ThenAvailabilityShouldBeAddedOnTheProfilePage()
        {
            Assert.AreEqual("Availability updated", profileObj.GetPopUpMsg());
            profileObj.ClosePopUp();

        }
           
        [When(@"Seller adds the Hours '(.*)'")]
        public void WhenSellerAddsTheHours(string hours)
        {
            profileObj.EditHoursOnProfile(hours);
        }

        [Then(@"Hours should be added on the profile page")]
        public void ThenHoursShouldBeAddedOnTheProfilePage()
        {
            Assert.AreEqual("Availability updated", profileObj.GetPopUpMsg());
            profileObj.ClosePopUp();
        }

        [When(@"Seller adds the Earn Target '(.*)'")]
        public void WhenSellerAddsTheEarnTarget(string earnTarget)
        {
            profileObj.EditEarnTargetOnProfile(earnTarget);
        }

        [Then(@"Earn Target should be added on the profile page")]
        public void ThenEarnTargetShouldBeAddedOnTheProfilePage()
        {
            Assert.AreEqual("Availability updated", profileObj.GetPopUpMsg());
            profileObj.ClosePopUp();
        }

        [When(@"Seller adds the Description '(.*)'")]
        public void WhenSellerAddsTheDescription(string description)
        {
            profileObj.EditdescriptionOnProfile(description);
        }

        [Then(@"Description should be added on the profile page")]
        public void ThenDescriptionShouldBeAddedOnTheProfilePage()
        {
            Assert.AreEqual("Description has been saved successfully", profileObj.GetPopUpMsg());
            profileObj.ClosePopUp();
        }


    }
}
