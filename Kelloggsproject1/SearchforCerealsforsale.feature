Feature: SearchforCerealsforsale
	In order to buy some cereal
	As a kelloggs customer
	I want to be search for different types of cereals


Scenario: Search for cornflakes
	Given I navigate to Kelloggs website
	And I hover over to the search text field
	When I type in cornflakes
	And I clcik the search button
	Then the different flavours of cornflakes will be displayed on the screen


	Scenario: Search for Cocopops
	Given I navigate to Kelloggs website
	And I hover over to the search text field
	When I type in cocopops
	And I clcik the search button
	Then the different flavours of cocopops will be displayed on the screen

	Scenario: Search for Crunchy Nuts
	Given I navigate to Kelloggs website
	And I hover over to the search text field
	When I type in crunchy nuts
	And I clcik the search button
	Then the different flavours of crunchy nuts will be displayed on the screen