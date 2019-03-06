Feature: SpecFlowFeature1

Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then The result should be 120 on the screen

Scenario: Add three numbers
	Given I have entered 20 into the calculator
	And I have entered 30 into the calculator
	And I have entered 100 into the calculator
	When I press add
	Then The result should be 150 on the screen

Scenario: Multiply two numbers
	Given I have entered 2 into the calculator
	And I have entered 10 into the calculator
	When I press multiply
	Then The result should be 20 on the screen