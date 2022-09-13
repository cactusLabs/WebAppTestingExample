Feature: Login

Scenarios to validate the login feature including cases:
> I can log in with known credentials
> I cannot log in with unknown username 
> I cannot log in with known username and incorrect password

@loginService
Scenario: I can log in with known credentials
Given I am on the login page
And I log in using known credentials
Then I expect to be on the landing page




