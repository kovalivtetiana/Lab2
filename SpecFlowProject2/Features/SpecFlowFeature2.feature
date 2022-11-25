Feature: SpecFlowFeature2
	Login to the site saucedemo.com
	Product selection
	Search operation Add to cart

@mytaj
Scenario: Search button
	Given I launch the application
	And I enter username "standard_user"
	And I enter password "secret_sauce"
	And I click login button
	When Click on the photo of the "Sauce Labs Backpack"
	Then I see a button "Add to cart"