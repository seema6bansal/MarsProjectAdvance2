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
    class LanguagesSteps
    {
        Profile profileObj = new Profile();

        [Given(@"Seller clicks on Languages tab on the profile page")]
        public void GivenSellerClicksOnLanguagesTabOnTheProfilePage()
        {
            profileObj.ClickOnLanguageTab();
        }

        [When(@"Seller adds a new Language '(.*)' and Level '(.*)'")]
        public void WhenSellerAddsANewLanguageAndlevel(string language, string level)
        {
            profileObj.AddLanguageOnProfile(language, level);
        }

        [Then(@"Language '(.*)' should be added on the profile page")]
        public void ThenLanguageShouldBeAddedOnTheProfilePage(string language)
        {
            Assert.AreEqual(language + " has been added to your languages", profileObj.GetPopUpMsg());
            profileObj.ClosePopUp();
        }

        [When(@"Seller updates the Language '(.*)' by updating Level '(.*)'")]
        public void WhenSellerUpdatesTheLanguageByUpdatingLevel(string language, string level)
        {
            profileObj.UpdateLanguageOnProfile(language, level);
        }

        [Then(@"Language '(.*)' should be updated on the profile page")]
        public void ThenLanguageShouldBeUpdatedOnTheProfilePage(string language)
        {
            Assert.AreEqual(language + " has been updated to your languages", profileObj.GetPopUpMsg());
            profileObj.ClosePopUp();

        }

        [When(@"Seller deletes the language '(.*)'")]
        public void WhenSellerDeletesTheLanguage(string language)
        {
            profileObj.DeleteLanguageOnProfile(language);
        }

        [Then(@"Language '(.*)' should be deleted on the profile page")]
        public void ThenLanguageShouldBeDeletedOnTheProfilePage(string language)
        {
            Assert.AreEqual(language + " has been deleted from your languages", profileObj.GetPopUpMsg());
            profileObj.ClosePopUp();

        }

    }
}
