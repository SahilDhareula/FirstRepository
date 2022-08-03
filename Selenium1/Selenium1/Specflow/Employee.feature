Feature: Employee Feature

As a TurnUp Portal Admin
I would like to create, edit and delete Employee Records

@tag1
Scenario: Create an Employee Record with Valid details
	Given Log in successfully into Turnup Portal
	When I go To Employee Page
	When I create a new employee record
	Then New Employee Record Should be created successfully

@tag2
Scenario Outline:Edit an Employee Record
	Given Log in successfully into Turnup Portal
	When I go To Employee Page
	When I update '<Name>','<Username>' and '<Contact>' of an existing employee record 
	Then Employee Record should have '<Name>','<Username>' and '<Contact>' updated

Examples: 
| Name | Username | Contact    |
| Asus | Ben      | 0217653765 |

@tag3
Scenario:Delete an existing Employee Record
	Given Log in successfully into Turnup Portal
	When I go To Employee Page
	When I delete an existing Employee Record and click on OK to confirm
	Then Employee record should be deleted sucessfully