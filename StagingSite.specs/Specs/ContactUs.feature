@contactUs
Feature: Contact Us Page
  As an end user
  I want a contact us page
  So that I can find out more about QAWorks exciting services

Background: 
	Given I am on the QAWorks Staging Site

Scenario: Valid Submission
# When part was missing in the origional acceptance test quideline
# Table header was missing
    When I fill in contactus form with the following information

		| field	  | value									  |
		| name    | j.Bloggs         6                        |
		| email   | j.Bloggs@qaworks.com                      |
		| message | please contact me I want to find out more |
		And I click the send button
    
	Then I should be able to contact QAWorks with the following information

		| field	  | value									  |
		| name    | j.Bloggs         6                        |
		| email   | j.Bloggs@qaworks.com                      |
		| message | please contact me I want to find out more |
      
