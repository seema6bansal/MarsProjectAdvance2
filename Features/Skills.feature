Feature: Skills
	In order to add Skills
	As a Seller
	I want to be able to add, update and delete the Skills on the profile page

@automation
Scenario Outline: Add Seller’s Skills on profile page
	Given Seller clicks on Skills tab on the profile page
	When Seller adds a new Skill '<Skill>' and Level '<Level>' 
	Then Skill '<Skill>' should be added on the profile page
Examples: 
| Skill  | Level    |
| Java   | Beginner |
| C#     | Beginner |

@ignore
Scenario Outline: Cancel Seller’s added Skills on profile page
	Given Seller clicks on Skills tab on the profile page
	When Seller cancels added new Skill '<Skill>' and Level '<Level>'
	Then Skill '<Skill>' should not be added on the profile page
Examples: 
| Skill  | Level    |
| API    | Beginner |
| Docker | Beginner |

@ignore
Scenario: Validate Add functionality for Skill with null values
	Given Seller clicks on Skills tab on the profile page
	When Seller adds a new skill with null values
	Then Seller should get error message

@ignore
Scenario: Validate Add functionality for Skill with duplicate values
	Given Seller clicks on Skills tab on the profile page
	When Seller adds a new skill with duplicate values
	Then Seller should get duplicate error message

@automation
Scenario Outline: Update Seller’s Skills on profile page
	Given Seller clicks on Skills tab on the profile page
	When Seller updates the Skill '<Skill>' by updating Level '<Level>' 
	Then Skill '<Skill>' should be updated on the profile page
Examples: 
| Skill  | Level        |
| Java   | Intermediate |
| C#     | Intermediate |

@ignore
Scenario Outline: Cancel Seller’s updated Skills on profile page
	Given Seller clicks on Skills tab on the profile page
	When Seller cancels the Skill '<Skill>' by updating Level '<Level>' 
	Then Skill '<Skill>' should not be updated on the profile page
Examples: 
| Skill  | Level  |
| Java   | Expert |
| C#     | Expert |

@ignore
Scenario: Validate Update functionality for Skill with null values
	Given Seller clicks on Skills tab on the profile page
	When Seller updates the skill with null values
	Then Seller should get error message

@ignore
Scenario: Validate Update functionality for Skill with duplicate values
	Given Seller clicks on Skills tab on the profile page
	When Seller updates the skill with duplicate values
	Then Seller should get duplicate error message

@automation
Scenario Outline: Delete Seller’s Skills on profile page
	Given Seller clicks on Skills tab on the profile page
	When Seller deletes the Skill '<Skill>'
	Then Skill '<Skill>' should be deleted on the profile page
Examples: 
| Skill |
| Java  |
| C#    |

