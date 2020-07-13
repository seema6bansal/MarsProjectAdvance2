Feature: Education
	In order to add Education
	As a Seller
	I want to be able to add, update and delete the Education on the profile page

@automation
Scenario: Add Seller’s Education on profile page
	Given Seller clicks on Education tab on the profile page
	When Seller adds a new education with the following data:
	| University  | Country     | Title  | Degree    | Year |
    | Wellington  | New Zealand | B.Tech | Bachelors | 2018 |
    | Wellington1 | New Zealand | M.Tech | Masters   | 2018 |
    Then Education should be added on the profile page

@ignore
Scenario: Cancel Seller’s added Education on profile page
	Given Seller clicks on Education tab on the profile page
	When Seller cancels new added education with the following data:
	| University  | Country     | Title  | Degree    | Year |
    | Auckland    | New Zealand | B.Tech | Bachelors | 2018 |
    | Auckland1   | New Zealand | M.Tech | Masters   | 2018 |
	Then Education should not be added on the profile page

@ignore
Scenario: Validate Add functionality for Education with null values
	Given Seller clicks on Education tab on the profile page
	When Seller adds a new education with null values
	Then Seller should get error message

@ignore
Scenario: Validate Add functionality for Education with duplicate values
	Given Seller clicks on Education tab on the profile page
	When Seller adds a new education with duplicate values
	Then Seller should get duplicate error message

@automation
Scenario Outline: Update Seller’s Education on the profile page
	Given Seller clicks on Education tab on the profile page
	When Seller updates the Education '<Title>' by updating University '<University>' and Country '<Country>' 
	Then Education should be updated on the profile page
Examples: 
| Title   | University           | Country   |
| B.Tech  | Australia University | Australia |

@ignore
Scenario Outline: Cancel Seller’s updated Education on profile page
	Given Seller clicks on Education tab on the profile page
	When Seller cancels the Education '<Title>' by updating University '<University>' and Country '<Country>' 
	Then Education should not be saved on the profile page
Examples: 
| Title   | University           | Country   |
| B.Tech  | Australia University | Australia |


@ignore
Scenario: Validate Update functionality for Education with null values
	Given Seller clicks on Education tab on the profile page
	When Seller updates the education with null values
	Then Seller should get error message

@ignore
Scenario: Validate Update functionality for Education with duplicate values
	Given Seller clicks on Education tab on the profile page
	When Seller updates the education with duplicate values
	Then Seller should get duplicate error message

@automation
Scenario Outline: Delete Seller’s Education on profile page
	Given Seller clicks on Education tab on the profile page
	When Seller deletes the Education '<Title>' 
	Then Education should be deleted on the profile page
Examples: 
| Title  |
| B.Tech |
| M.Tech |
