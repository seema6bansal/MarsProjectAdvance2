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
    class SearchSkillsSteps
    {
        HomeSearch homeSearchObj = new HomeSearch();

        [When(@"Seller clicks on search icon on the home Page")]
        public void WhenSellerClicksOnSearchIconOnTheHomePage()
        {
            homeSearchObj.SearchByAllCategories();
        }

        [Then(@"All Categories's Skills should be displayed")]
        public void ThenAllCategoriesSSkillsShouldBeDisplayed()
        {
            Assert.IsTrue(homeSearchObj.GetSearchResult().Length > 0);
        }

        [Given(@"Seller clicks on search icon on the home Page")]
        public void GivenSellerClicksOnSearchIconOnTheHomePage()
        {
            homeSearchObj.SearchByAllCategories();
        }

        [When(@"Seller selects category '(.*)' and subcategory '(.*)'")]
        public void WhenSellerSelectsCategoryAndSubcategory(string category, string subCategory)
        {
            homeSearchObj.SearchByAllCategories();
            homeSearchObj.SearchByCategory(category, subCategory);

        }

        [Then(@"Skills of that Category and SubCategory should be displayed")]
        public void ThenSkillsOfThatCategoryAndSubCategoryShouldBeDisplayed()
        {
            Assert.IsTrue(homeSearchObj.GetSearchResult().Length > 0);
        }

        [When(@"Seller selects Filter '(.*)' on the search page")]
        public void WhenSellerSelectsFilterOnTheSearchPage(string filter)
        {
            homeSearchObj.SearchByFilter(filter);
        }

        [Then(@"Skills of that Filter should be displayed")]
        public void ThenSkillsOfThatFilterShouldBeDisplayed()
        {
            Assert.IsTrue(homeSearchObj.GetSearchResult().Length > 0);
        }

    }
}
