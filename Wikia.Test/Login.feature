Feature: Login
	In order to use the QM Homework portal 
	As an applicant 
	I want to be able to login with my username and password


@Browser:Chrome
Scenario:Login into the QM Homework wikia
	Given I am on the QM Homework wikia
	And I am not logged in 
	When I hover over over the Sign In button 
	And I enter "saswatpatnaik" into the username column 
	And I enter "P@ssword-1" into the password column
	And I click the Log In button
	Then I should be logged in to the system
	And I should not be able to see the sign in label
	