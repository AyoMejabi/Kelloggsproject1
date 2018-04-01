Feature: SearchforDIstributors
	In order to find different distributors in a particular country
	As a kelloggs customer
	I want to be search for the distributors in my locsal environment


Scenario: Search for Distributors in the UK
	Given I navigate to Kelloggs website
	And I hover over to the search text field
	When I type in distributors
	And I click on the country drop down list
	And I scroll down to the UK
	And I select UK
	And I clcik the search button
	Then the different distributors of Kellogs products in the UK will be displayed on the screen


	Scenario: Search for Distributors in Spain
	Given I navigate to Kelloggs website
	And I hover over to the search text field
	When I type in distributors
	And I click on the country drop down list
	And I scroll down to the Spain
	And I select Spain
	And I clcik the search button
	Then the different distributors of Kellogs products in Spain will be displayed on the screen