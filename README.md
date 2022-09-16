# WebAppTestingExample
Example UI test solution written in C#

This is WIP.

Aim to build: 

* UI web app example using Selenium, SpecFlow, NUnit written in C# using Page Object Model

Dependencies:

* Microsoft.NET.Test.Sdk
* NUnit
* NUnitConsole
* NUnit3TestAdapter
* Selenium Webdriver
* Selenium Support
* Selenium Webdriver ChromeDriver
* SpecFlow
* SpecFlow NUnit Runners

How to use:

The committed project was only ever intended for demonstration purposes.  It falls short in a few areas e.g. test cases need building out (it currently only tests a few login cases) and the handling of use credentials is not advised/ideal as even a mid term solution.  

With regard to setup/config... 

* register as a user with https://gearspace.com/ and validate the membership
* add your gearspace board username and password values to configs/Config.js

You should then be able to run scenarios from the test runner

Note that the 'unknown credentials' scenarios will begin to fail after 5 runs/attempts as 
Gearspace enforces a fifteen minutes wait before the scenarios will begin to pass again.  
This is an interesting test case in itself and will be considered further should this 
solution be built out further.
