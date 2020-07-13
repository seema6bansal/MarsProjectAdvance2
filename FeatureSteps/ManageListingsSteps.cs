using MarsProjectAdvance2.Global;
using MarsProjectAdvance2.Model;
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
    class ManageListingsSteps
    {
        private string updatedTitle;
        private string deleteTitle;
        Profile profileObj = new Profile();
        ManageListings manageListingsObj = new ManageListings();

        [Given(@"Seller clicks on Manage Listings tab on the profile page")]
        public void GivenSellerClicksOnManageListingsTabOnTheProfilePage()
        {
            profileObj.ClickOnManageListings();
        }

        [When(@"Seller updates the Listings by Title '(.*)'")]
        public void WhenSellerUpdatesTheListingsByTitle(string title)
        {
            //Populate UpdateManageListings Excel data in Collection
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.excelPath, "UpdateManageListings");
            updatedTitle = title;
            manageListingsObj.UpdateServiceListings(title);

            ShareSkillDetails updateSkillObj = new ShareSkillDetails();
            updateSkillObj.Title = title;
            updateSkillObj.Description = GlobalDefinitions.ExcelLib.ReadData(2, "Description");
            updateSkillObj.Category = GlobalDefinitions.ExcelLib.ReadData(2, "Category");
            updateSkillObj.SubCategory = GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory");
            updateSkillObj.Tags = GlobalDefinitions.ExcelLib.ReadData(2, "Tags");
            updateSkillObj.ServiceType = GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType");
            updateSkillObj.LocationType = GlobalDefinitions.ExcelLib.ReadData(2, "LocationType");
            updateSkillObj.StartDate = GlobalDefinitions.ExcelLib.ReadData(2, "StartDate");
            updateSkillObj.EndDate = GlobalDefinitions.ExcelLib.ReadData(2, "EndDate");
            updateSkillObj.SelectDay = GlobalDefinitions.ExcelLib.ReadData(2, "SelectDay");
            updateSkillObj.StartTime = GlobalDefinitions.ExcelLib.ReadData(2, "StartTime");
            updateSkillObj.EndTime = GlobalDefinitions.ExcelLib.ReadData(2, "EndTime");
            updateSkillObj.SkillTrade = GlobalDefinitions.ExcelLib.ReadData(2, "SkillTrade");
            updateSkillObj.SkillExchange = GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange");
            updateSkillObj.Active = GlobalDefinitions.ExcelLib.ReadData(2, "Active");

            ShareSkill shareSkillObj = new ShareSkill();
            shareSkillObj.AddShareSkillDetails(updateSkillObj);

        }

        [Then(@"Listing should be updated on the ManageListings page")]
        public void ThenListingShouldBeUpdatedOnTheManageListingsPage()
        {
            Assert.AreEqual(updatedTitle, manageListingsObj.GetTitle());
        }

        [When(@"Seller deletes the Listings by Title '(.*)'")]
        public void WhenSellerDeletesTheListingsByTitle(string title)
        {
            deleteTitle = title;
            manageListingsObj.DeleteServiceListings(title);
        }

        [Then(@"Listing should be deleted from the ManageListings page")]
        public void ThenListingShouldBeDeletedFromTheManageListingsPage()
        {
            Assert.AreEqual((deleteTitle + " has been deleted"), manageListingsObj.GetPopUpMsg());
        }

    }
}
