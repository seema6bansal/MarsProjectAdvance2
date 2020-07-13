Feature: ShareSkills
	In order to add Shareskill
	As a Skill Trader
    I want the feature to add shareskill deatils on the shareskill page
    so that the people seeking for some skills can look into my details

@automation
Scenario: Add Seller’s Shareskills on the shareskill page
	Given Seller clicks on Shareskill button on the profile page
	When Seller adds Shareskill details on the Shareskill page
	Then Shareskill details should be added
