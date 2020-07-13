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
    class SkillsSteps
    {
        Profile profileObj = new Profile();

        [Given(@"Seller clicks on Skills tab on the profile page")]
        public void GivenSellerClicksOnSkillsTabOnTheProfilePage()
        {
            profileObj.ClickOnSkillTab();
        }

        [When(@"Seller adds a new Skill '(.*)' and Level '(.*)'")]
        public void WhenSellerAddsANewSkillAndLevel(string skill, string level)
        {
            profileObj.AddSkillOnProfile(skill, level);
        }

        [Then(@"Skill '(.*)' should be added on the profile page")]
        public void ThenSkillShouldBeAddedOnTheProfilePage(string skill)
        {
            Assert.AreEqual(skill + " has been added to your skills", profileObj.GetPopUpMsg());
            profileObj.ClosePopUp();

        }

        [When(@"Seller updates the Skill '(.*)' by updating Level '(.*)'")]
        public void WhenSellerUpdatesTheSkillByUpdatingLevel(string skill, string level)
        {
            profileObj.UpdateSkillOnProfile(skill, level);
        }

        [Then(@"Skill '(.*)' should be updated on the profile page")]
        public void ThenSkillShouldBeUpdatedOnTheProfilePage(string skill)
        {
            Assert.AreEqual(skill + " has been updated to your skills", profileObj.GetPopUpMsg());
            profileObj.ClosePopUp();

        }

        [When(@"Seller deletes the Skill '(.*)'")]
        public void WhenSellerDeletesTheSkill(string skill)
        {
            profileObj.DeleteSkillOnProfile(skill);
        }

        [Then(@"Skill '(.*)' should be deleted on the profile page")]
        public void ThenSkillShouldBeDeletedOnTheProfilePage(string skill)
        {
            Assert.AreEqual(skill + " has been deleted", profileObj.GetPopUpMsg());
            profileObj.ClosePopUp();

        }

    }
}
