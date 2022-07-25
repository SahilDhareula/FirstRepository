Feature: TM Feature

As a TurnUp Portal Admin
I would like to create, edit and delete Time and Material Records


@tag1
Scenario: Create a Material Record with valid details
	Given Logged in successfully into Turnup Portal
	When I go To Time and Material Page
	When I create a new material
	Then Then Record should be created successfully

@tag2
Scenario Outline: Edit Material Record
	Given Logged in successfully into Turnup Portal
	When I go To Time and Material Page
	When I update '<Code>','<Description>' and '<Price>' of an existing material record 
	Then Record should have '<Code>','<Description>' and '<Price>' updated

    Examples:  
	 | Code      | Description | Price   |
	 | Vodafone  | Mobile      | $50.00  |
	 | 2 Degrees | Wifi        | $100.00 |


