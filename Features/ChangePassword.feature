Feature: ChangePassword
	In order to Add skills
	As a Seller
    I want to be able to change my password on the Profile page

@automation
Scenario Outline: Change password on the Profile page
	Given Seller clicks on Change Password on the profile page
	When Seller enters valid credintals '<Current Password>', '<New Password>', '<Confirm Password>' 
	Then Sellers's password should be changed successfully
Examples:
| Current Password | New Password | Confirm Password |
|                  |              |                  |

