Welcome to Slime Attack! This project is an interactive game. 
Players choose from a list of options that determine the character's actions.
text-based artwork helps add more immersion to the experience. 

Features include:

A master loop - see Menu.cs for details.
The title menu and the game menu both allow players to enter commands.

Implement a log that records errors, invalid inputs, or other important events - see Program.cs for details.
A try-catch block is used to detect an error in the event that a user is unable to open the project in the desired width or height.
An error message is written to the console when this happens, and the user is able to continue without the program terminating.
You can test this by increasing the desired width or height (changing the desired width on line 10 to 310 for example).

Calculate and display data based on external factors - see Game.cs for details.
Both player health and enemy health are re-calculated based on player choices.
These values are then displayed each turn that either ATTACK or ITEM is selected.