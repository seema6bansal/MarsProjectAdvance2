Feature: ManageListings
	In order to manage Lisistings
	As a Skill Trader
    I want the feature to Update and Delete Listings on the ManageListings page

@automation
Scenario Outline: 1 Update Seller’s Listings on the ManageListings page
	Given Seller clicks on Manage Listings tab on the profile page
	When Seller updates the Listings by Title '<Title>' 
	Then Listing should be updated on the ManageListings page
Examples: 
| Title    |
| Selenium |

@automation
Scenario Outline: 2 Delete Seller’s Listings on the ManageListings page
	Given Seller clicks on Manage Listings tab on the profile page
	When Seller deletes the Listings by Title '<Title>' 
	Then Listing should be deleted from the ManageListings page
Examples: 
| Title    |
| Selenium |
