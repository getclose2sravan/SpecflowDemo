Feature: LoginFeatureDatastep
	In order to access my account
	As a user of the website
	I want to login and logout of the website

@mytag
Scenario: Successful login with valid credentials
	Given User is at the home page
	And Navigate to appropriate login page
	When I enter my username and password
	Then Successful login message should be displayed

Scenario: Successful Logout
	When user logout from the application
	Then user should see a successful logout message