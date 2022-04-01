My LouisvilleHikes Project was created on version .NET6 and provides a search tool for hiking trail information for selected parks within the city.  This console app will generate a menu asking the user to search for a hiking trail based on the following - 

1.Park

2.Difficulty

3.Time 

4.Distance

The user will then enter a 1-4 number based on the factor of the trail they're interested in.  Inside the menu options the user will have the opportunity to narrow down to a particular trail that meets their needs.  For example, there are easy, moderate, and strenuous hikes, or a trail that would only take an hour to complete.  Once narrowed down, the complete hiking trail information will appear.  The trail name, which park, diffculty, time, and distance will be generated. The user can then press any key to be returned to the main menu. 

Program Requirements: 

This console app completes all the requirements for Code Louisville Software Development I course including the following from the Feature List - 

*Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program.

	-The user is directed to a main menu where they can narrow down hiking trails by park, difficulty, time, and Distance.  
Once completed, the user can return to the main menu or exit. 

*Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program.

	-A list of trail detail information was created under Trails.cs.

*Use a LINQ query to retrieve information from a data structure (such as a list or array) or file.

	-The LINQ quere was used to pull particular trail data and to generate through the main menu options. 
