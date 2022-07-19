Feature: Tm Feature

 As a TurnUp Portal Admin
 I would like to create, edit and delete Time and Material Records
 So that I can manage Employee Time and Material Records

@tag1
Scenario: Create a Material Record with valid details
	Given Logged in successfully into Turnup Portal
	When I go ToTime and Material Page
	When I create a new material record
	Then Record should be created successfully

@tag2
Scenario: Edit a Material Record
	Given Logged in successfully into Turnup Portal
	When I go ToTime and Material Page
	When I edit a created material record
	Then record should be edited successfully

@tag3
Scenario: Delete a Material Record
	Given Logged in successfully
	When I go ToTime and Material Page
	When I delete a created material record
	Then record should be deleted successfully