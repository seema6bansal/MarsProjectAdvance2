Feature: Languages
	In order to add Languages
	As a Seller
	I want to be able to add, update and delete the Languages on the profile page

@automation
Scenario Outline: 1 Add Seller’s Languages on the profile page
	Given Seller clicks on Languages tab on the profile page
	When Seller adds a new Language '<Language>' and Level '<Level>' 
	Then Language '<Language>' should be added on the profile page
Examples: 
| Language  | Level  |
| English   | Basic  |
| Hindi     | Basic  |

@ignore
Scenario Outline: Cancel Seller’s added Languages on profile page
	Given Seller clicks on Languages tab on the profile page
	When Seller cancels added new Language '<Language>' and  Level '<Level>' 
	Then Language '<Language>' should not be added on the profile page
Examples: 
| Language | Level |
| Bengali  | Basic |
| Chinese  | Basic |

@ignore
Scenario: Validate Add functionality for Language with null values
	Given Seller clicks on Languages tab on the profile page
	When Seller adds a new language with null values
	Then Seller should get error message

@ignore
Scenario: Validate Add functionality for duplicate Language
	Given Seller clicks on Languages tab on the profile page
	When Seller adds a new language with duplicate values
	Then Seller should get duplicate error message 

@automation
Scenario Outline: 2 Update Seller’s Language on the profile page
	Given Seller clicks on Languages tab on the profile page
	When Seller updates the Language '<Language>' by updating Level '<Level>' 
	Then Language '<Language>' should be updated on the profile page
Examples: 
| Language  | Level  |
| English   | Fluent |
| Hindi     | Fluent |

@ignore
Scenario Outline: Cancel Seller’s updated Language on the profile page
	Given Seller clicks on Languages tab on the profile page
	When Seller cancels the Language '<Language>' by updating Level '<Level>' 
	Then Language '<Language>' should not be updated on the profile page
Examples: 
| Language  | Level |
| English   | Basic |
| Hindi     | Basic |

@ignore
Scenario: Validate Update functionality for Language with null values
	Given Seller clicks on Languages tab on the profile page
	When Seller updates the language with null values
	Then Seller should get error message

@ignore
Scenario: Validate Update functionality for duplicate Language 
	Given Seller clicks on Languages tab on the profile page
	When Seller updates the language with duplicate values
	Then Seller should get duplicate error message

@automation
Scenario Outline: 3 Delete Seller’s Language on profile page
	Given Seller clicks on Languages tab on the profile page
	When Seller deletes the language '<Language>'  
	Then Language '<Language>' should be deleted on the profile page
Examples: 
| Language |
| English  |
| Hindi    |

