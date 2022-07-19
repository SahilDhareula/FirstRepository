Feature: Employee Feature

 As a TurnUp Portal Admin
 I would like to create, edit and delete Employees 
 So that I can manage Employee  Records

@tag1
Scenario: Create an Employee
	Given Logged in successfully into Turnup Portal
	When I go Employees Page
	When I create a new employee record
	Then New Employee should be created successfully


	
@tag2
Scenario: Edit an Employee
	Given Logged in successfully into Turnup Portal
	When I go Employees Page
	When I edit created employee record
	Then Created Employee should be edited successfully


@tag3
Scenario: Delete an Employee
	Given Logged in successfully into Turnup Portal
	When I go Employees Page
	When I delete a new employee record
	Then Employee should be deleted successfully