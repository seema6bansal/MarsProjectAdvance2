Feature: SignIn
	In order to Add skills
    As a Seller
    I want to be able to login to the skill trade website

@ignore
Scenario Outline: Successful Login
	Given Seller is at the Trade Skills Website 
	And Navigates to the Login Page
	When Seller enters valid '<Email_address>', '<Password>'  
	Then Seller's name should be seen on the profile page
Examples: 
| Email_address       | Password |
| seema.mvp@gmail.com | mvp@2020 |

@ignore
Scenario Outline: Unsuccessful Login
	Given Seller is at the Trade Skills Website
	And Navigates to the Login Page
	When Seller enters invalid '<Email_address>', '<Password>' 
	Then Seller should get "Send Verification Email" message on the screen
Examples: 
| Email_address       | Password |
| seema.mv@gmail.com | mmm@2020 |
