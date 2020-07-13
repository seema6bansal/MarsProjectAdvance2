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
    class CertificationsSteps
    {
        private string AddedCertificate;
        Profile profileObj = new Profile();

        [Given(@"Seller clicks on Certification tab on the profile page")]
        public void GivenSellerClicksOnCertificationTabOnTheProfilePage()
        {
            profileObj.ClickOnCertificationTab();
        }

        [When(@"Seller adds a new Certification with the following data:")]
        public void WhenSellerAddsANewCertificationWithTheFollowingData(Table table)
        {
            var details = table.CreateSet<CertificateDetails>();

            foreach (CertificateDetails certificate in details)
            {
                profileObj.AddCertificationOnProfile(certificate.Certificate, certificate.From, certificate.Year);
                AddedCertificate = certificate.Certificate;
                
            }
        }

        [Then(@"Certification should be added on the profile page")]
        public void ThenCertificationShouldBeAddedOnTheProfilePage()
        {
            Assert.AreEqual(AddedCertificate + " has been added to your certification", profileObj.GetPopUpMsg());
            profileObj.ClosePopUp();

        }

        [When(@"Seller updates the Certificate '(.*)' by updating From '(.*)' and Year '(.*)'")]
        public void WhenSellerUpdatesTheCertificateByUpdatingFromAndYear(string certificate, string from, int year)
        {
            profileObj.UpdateCertificationOnProfile(certificate, from, year);
        }

        [Then(@"Certificate '(.*)' should be updated on the profile page")]
        public void ThenCertificateShouldBeUpdatedOnTheProfilePage(string certificate)
        {
            Assert.AreEqual(certificate + " has been updated to your certification", profileObj.GetPopUpMsg());
            profileObj.ClosePopUp();

        }

        [When(@"Seller deletes the Certificate '(.*)'")]
        public void WhenSellerDeletesTheCertificate(string certificate)
        {
            profileObj.DeleteCertificationOnProfile(certificate);

        }

        [Then(@"Certificate '(.*)' should be deleted on the profile page")]
        public void ThenCertificateShouldBeDeletedOnTheProfilePage(string certificate)
        {
            Assert.AreEqual(certificate + " has been deleted from your certification", profileObj.GetPopUpMsg());
            profileObj.ClosePopUp();

        }

    }
}
