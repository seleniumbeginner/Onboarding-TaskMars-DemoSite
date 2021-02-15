Feature: BDD with Selenium and Specflow verifications

Scenario Outline: verify user can login to portal 
Given I am on home page 
When I click login button I navigate to login page 
And enter user credentials '<Email>','<Password>' and click login 
Then user is able to login 

Examples: 
| Email               | Password |
| mailgodar@gmail.com |12345456  |
|  limpdon@hotmail.com   | BASANTA|
