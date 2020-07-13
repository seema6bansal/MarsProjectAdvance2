Feature: ProfileDetails
      In order to update my profile details
	  As a Skill Trader
      I want to be able to Add my Avialablity, Hours, Earn Target and Description 
      

@automation
Scenario Outline: 1 Add Seller’s Availability on the profile page
	Given Seller is on the profile page 
	When Seller adds the Availability '<Availability>'
	Then Availability should be added on the profile page
Examples: 
| Availability |
| Full Time    |

@automation
Scenario Outline: 2 Add Seller’s Hours on the profile page
	Given Seller is on the profile page 
	When Seller adds the Hours '<Hours>'
	Then Hours should be added on the profile page
Examples: 
| Hours                      |
| Less than 30hours a week   |

@automation
Scenario Outline: 3 Add Seller’s Earn Target on the profile page
	Given Seller is on the profile page 
	When Seller adds the Earn Target '<Earn Target>'
	Then Earn Target should be added on the profile page
Examples: 
| Earn Target               |
| Less than $500 per month  |


@automation
Scenario Outline: 4 Add Seller’s Description on the profile page
	Given Seller is on the profile page 
	When Seller adds the Description '<Description>' 
	Then Description should be added on the profile page
Examples: 
| Description        |
| I am Test Analyst  |
