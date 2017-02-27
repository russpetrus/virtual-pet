# virtual-pet
This virtual pet solution is comprised of two parts: 
1. the class VirtualPet with its associated fields, constructors, properties, and methods. 
2. the user interface which is in the main method of the program.
When the user launches the program, a random numbers are generated that will be used upon instantiation of their virtual pet. 
The user is then asked to choose a pet type from a list and to give the pet a name. 
Once the user chooses these, a new object "userPet" is instantiated and the fields assigned accordingly using properties 
(rather than constructors, since the properties are set to constain values for int fields between 0 and 100).

The "game begins" once the object is instantiated. 
The user is given the current state of the pet (using the DisplayStatus method) and asked what s/he would like to do.
There are several methods the user can choose from: to feed the pet, give it water, play with it, cuddle with it, and let it go to the bathroom. 
Each method has a direct impact on the field that it is most closely associated with (e.g. the Feed method greatly reduces hunger) and
impacts other related fields (e.g. the Feed method also increases thirst). Those methods are called upon depending upon the user's entry. 

This code runs in a loop (do while) until the Property PetSatisfaction is equal to or greater than 90. The PetSatisfaction property is the calculated by
taking the average of all the animals needs (fields) and subtracting that average from 100. 

once the user reaches 90 satisfaction or higher a message is displayed congratulating the user and the console closes. 

