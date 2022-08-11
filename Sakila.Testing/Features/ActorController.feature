Feature: Actor

@1
Scenario: Given actor ID, check the first and last names are correct
	Given I am a user interacting with the database api
	When I make a get request to getActor
	Then the response status code is "200"
	And returned FirstName is "PENELOPE"
	And returned LastName is "GUINESS"

#@2
#Scenario: Check if the actor that has been added to table is deleted
#	Given I am a user interacting with the database api
#	When I make a get request to getallactors
#	Then the response status code is "200"
#	And sequence length is equals to the table

@2
Scenario: Update an actor and use its ID to check that the names in that index are now changed
	Given I am a user interacting with the database api
	When I make a put request to updateExistingActorName <originalfirstname> <originallastname> <newfirstname> <newlastname>
	#Then the response status code is "200"
	Then the first name <newfirstname> and last name <newlastname> of actor is equals to the names entered

Examples:
| originalfirstname | originallastname | newfirstname | newlastname |
| THORA             | TEMPLE           | TAYLOR       | BROMLEY     |



