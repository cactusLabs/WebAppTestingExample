@loginService
Feature: Login

Scenarios to validate the login feature including cases:
> I can log in with known credentials
> I cannot log in with unknown username 
> I cannot log in with known username and incorrect password

Scenario: I can log in with known credentials
Given I am on the login page
When I log in using known credentials
Then I expect to be logged in as that user

Scenario: I cannot log in with unknown username
Given I am on the login page
When I log in using an unknown username
Then I do not expect to be logged in

Scenario: I cannot log in with known username and incorrect password
Given I am on the login page
When I log in using known username and incorrect password
Then I do not expect to be logged in
