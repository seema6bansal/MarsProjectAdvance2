Feature: SearchSkills
	In order to search skills
	As a Seller
	I want to be able to search the skills by All categories, Subcategories and Filter

@automation
Scenario: Search Skills by All Categories
	When Seller clicks on search icon on the home Page
	Then All Categories's Skills should be displayed

@automation
Scenario Outline: Search Skills by Category and SubCategory
    Given Seller clicks on search icon on the home Page
	When  Seller selects category '<Category>' and subcategory '<SubCategory>'
	Then  Skills of that Category and SubCategory should be displayed
Examples:
| Category           | SubCategory       |
| Programming & Tech |  Web & Mobile App |


@automation
Scenario Outline: Search Skills by Filter
    Given Seller clicks on search icon on the home Page
	When  Seller selects Filter '<Filter>' on the search page
	Then  Skills of that Filter should be displayed 
Examples: 
| Filter  |
| ShowAll |

