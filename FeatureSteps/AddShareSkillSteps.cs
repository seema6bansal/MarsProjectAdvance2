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
    class AddShareSkillSteps
    {
        ShareSkillDetails addSkillObj = new ShareSkillDetails();

        [Given(@"Seller clicks on Shareskill button on the profile page")]
        public void GivenSellerClicksOnShareskillButtonOnTheProfilePage()
        {
            Profile profileObj = new Profile();
            profileObj.ClickOnShareSkill();
        }

        [When(@"Seller adds Shareskill details on the Shareskill page")]
        public void WhenSellerAddsShareskillDetailsOnTheShareskillPage()
        {
            //Populate ShareSkill Excel data in Collection
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.excelPath, "ShareSkill");
           
            addSkillObj.Title = GlobalDefinitions.ExcelLib.ReadData(2, "Title");
            addSkillObj.Description = GlobalDefinitions.ExcelLib.ReadData(2, "Description");
            addSkillObj.Category = GlobalDefinitions.ExcelLib.ReadData(2, "Category");
            addSkillObj.SubCategory = GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory");
            addSkillObj.Tags = GlobalDefinitions.ExcelLib.ReadData(2, "Tags");
            addSkillObj.ServiceType = GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType");
            addSkillObj.LocationType = GlobalDefinitions.ExcelLib.ReadData(2, "LocationType");
            addSkillObj.StartDate = GlobalDefinitions.ExcelLib.ReadData(2, "StartDate");
            addSkillObj.EndDate = GlobalDefinitions.ExcelLib.ReadData(2, "EndDate");
            addSkillObj.SelectDay = GlobalDefinitions.ExcelLib.ReadData(2, "SelectDay");
            addSkillObj.StartTime = GlobalDefinitions.ExcelLib.ReadData(2, "StartTime");
            addSkillObj.EndTime = GlobalDefinitions.ExcelLib.ReadData(2, "EndTime");
            addSkillObj.SkillTrade = GlobalDefinitions.ExcelLib.ReadData(2, "SkillTrade");
            addSkillObj.SkillExchange = GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange");
            addSkillObj.Active = GlobalDefinitions.ExcelLib.ReadData(2, "Active");

            ShareSkill shareSkillObj = new ShareSkill();
            shareSkillObj.AddShareSkillDetails(addSkillObj);

        }

        [Then(@"Shareskill details should be added")]
        public void ThenShareskillDetailsShouldBeAdded()
        {
            ManageListings manageListingsObj = new ManageListings();
            Assert.AreEqual(addSkillObj.Title, manageListingsObj.GetTitle());
        }

    }
}
