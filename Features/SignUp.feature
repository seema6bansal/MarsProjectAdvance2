Feature: SignUp
	In order to Add skills
    As a Seller
    I want to be able to Resgister to the skill trade website

@ignore
Scenario: Successful Resgistration
	Given Seller is at the Trade Skills Website 
	And Navigates to the Join Page
	When Seller adds valid credentials with the following data:
	| First name | Last name | Email address   | Password  | Confirm Password |
	| Seema      | Bansal    | seema1.mvp@2020 | mvp1@2020 | mvp1@2020        |
	Then Seller should be registered to the skill trade website


@ignore
Scenario Outline: Unsuccessful Resgistration
	Given Seller is at the Trade Skills Website 
	And Navigates to the Join Page
	When Seller adds invalid credentials with the following data:
	| First name | Last name | Email address   | Password  | Confirm Password |
	| Seema      | Bansal    | seema1@2020     | mvp1      | mvp1             |
	Then Seller should not be registered to the skill trade website

