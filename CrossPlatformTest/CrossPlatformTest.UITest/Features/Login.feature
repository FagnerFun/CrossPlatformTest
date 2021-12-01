Feature: LoginRequirements
	Validate login Screen.
	
Background:
    Given a started app

#1
@login
Scenario: An user navigate to products screen
	Given an user at login screen
	And inform mail 'fagner.santos@ciandt.com'
	And inform password '1234'
	When he press login button
	Then he user seen products screen

#2
@login
Scenario: An user inform invalid password
	Given an user at login screen
	And inform mail 'fagner.santos@ciandt.com'
	And inform password 'senha'
	When he press login button
	Then he user seen error message
