Feature: Certifications
	 In order to add Certification
	As a Seller
	I want to be able to add, update and delete the Certification on the profile page


@automation
Scenario Outline: Add Seller’s Certification on profile page
	Given Seller clicks on Certification tab on the profile page
	When Seller adds a new Certification with the following data:
	| Certificate | From     | Year  |
    | ISTQB       | India    | 2016  |
   	Then Certification should be added on the profile page

@ignore
Scenario: Cancel Seller’s added Certification on profile page
	Given Seller clicks on Certification tab on the profile page
	When Seller cancels added Certification with the following data:
	| Certificate | From     | Year  |
    | Java        | India    | 2016  |
   	Then Certification should not be added on the profile page

@ignore
Scenario: Validate Add functionality for Certification with null values
	Given Seller clicks on Certification tab on the profile page
	When Seller adds a new certification with null values
	Then Seller should get error message

@ignore
Scenario: Validate Add functionality for Certification with duplicate values
	Given Seller clicks on Certification tab on the profile page
	When Seller adds a new certification with duplicate values
	Then Seller should get duplicate error message

@automation
Scenario Outline: Update Seller’s Certification on profile page
	Given Seller clicks on Certification tab on the profile page
	When Seller updates the Certificate '<Certificate>' by updating From '<From>' and Year '<Year>' 
	Then Certificate '<Certificate>' should be updated on the profile page
Examples: 
| Certificate | From       | Year |
| ISTQB       | Wellington | 2018 |

@ignore
Scenario Outline: Cancel Seller’s updated Certification on profile page
	Given Seller clicks on Certification tab on the profile page
	When Seller cancels the Certificate '<Certificate>' by updating From '<From>' and Year '<Year>' 
	Then Certificate '<Certificate>' should not be updated on the profile page
Examples: 
| Certificate | From       | Year |
| ISTQB       | Wellington | 2019 |

@ignore
Scenario: Validate Update functionality for Certification with null values
	Given Seller clicks on Certification tab on the profile page
	When Seller updates the certification with null values
	Then Seller should get error message

@ignore
Scenario: Validate Update functionality for Certification with duplicate values
	Given Seller clicks on Certification tab on the profile page
	When Seller updates the certification with duplicate values
	Then Seller should get duplicate error message

@automation
Scenario Outline: Delete Seller’s Certification on profile page
	Given Seller clicks on Certification tab on the profile page
	When Seller deletes the Certificate '<Certificate>'
	Then Certificate '<Certificate>' should be deleted on the profile page
Examples: 
| Certificate |
| ISTQB       |


