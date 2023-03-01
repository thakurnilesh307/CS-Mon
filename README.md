# CS-Mon
Code repo and unity colloboration workspace for CS'mon

Updated version of proposal
To make gamers of P6 Special Topics to play a game they can relate to and enjoy playing, but also make money, generate revenue, create sequels, and expand the franchise!
Two user scenarios
Key: Decision vs Outcome	
Story 1: Choose Nilesh as Starter -> Encounter wild Andrew -> Choose Run -> Escape 
Story 2: Choose Evan as Starter -> Encounter wild Andrew -> Choose Attack -> Andrew’s HP decreases -> Andrew’s attack misses -> Use CS’Ball -> Obtain Andrew. 
Functional and non-functional requirements
Functional: Battle options (inventory, attack, run). Progressing to new rooms. 
Non-functional: FPS - 30. Inventory List. Obtained CS’Mon List. Be able to scale the game up or down. Must be maintainable.
Design/Architecture
CS’Mon object variables:
Name
Level (0-100)
Max HP (0-1)
HP (>0)
Attack (0-1)
Speed (0-1)
Type (Fire, Water, or Grass)
Accuracy (0-100)
Crit Chance (0-100)

Rooms:
Room 1: choose  CS’Mon between Nilesh, Bijou, or Evan. These will be level 5. All obtained CS’Mon will be placed in a list of CS’Mon.
Room 2-10: Control player avatar, starting at top of room and exit to the next room at bottom of room. Items will randomly spawn which can be picked up and added to an inventory list. Periodically, run into a random wild CS’Mon and be transported to Room 11, the Battle Room. With each new room, the levels of the wild CS’Mon will increase, maxing out at level 70, although the player can level their CS’Mon up to level 100. 
Room 11 (Battle Room): The UI for the CS'Mon battle room is a crucial part of the battle experience, providing trainers with the information they need to make strategic decisions and control their CS'Mon during the battle. The UI typically includes several key components:
Trainer Information: The UI displays the name and icon of the user in the battle, along with their current level and other relevant information.
CS'Mon Information: The UI displays information about each CS'Mon in the battle, including their name, level, type, health bar, and status condition. It may also show the CS'Mon's attack and defense stats, as well as any special abilities or moves that they possess.
Battle Options: The UI provides a set of battle options for each side, allowing the user to choose which CS'Mon to use, select an attack or move, use an item, switch out their CS'Mon, or flee from the battle.
Time and Turn Counter: The UI displays a timer that shows how much time is left in the battle, as well as a turn counter that indicates which trainer's turn it is.
Coding Architecture for Room 11:
2 CS’Mon Processor objects, one for the player’s CS’Mon and the other for whatever enemy CS’Mon brought the player to the battle room. The player’s Processor object will use and access the variables of the first item in the obtained CS’Mon list, and the enemy Processor object will use the variables of the enemy CS’Mon. 
Each turn, the player can choose one of three options with a press of a button:
Run- returns the player to the previous room. 
Inventory- allows the player to access the Inventory List and use an item. 
Switch- causes the player's Processor object to start using variables of another CS’Mon in the obtained CS’Mon list instead. 
Attack- allied CS’Mon attempts to use its unique move. 
Battle Mechanics Flowchart


(Battle Mechanics cont.)
If current allied CS’Mon HP goes below 1, Processor will switch to another CS’Mon in the obtained list. If all CS’Mon in the obtained List have HP Values below 1, the player will return to Room 2 with all obtained CS’Mon having their HP values set to CS’Mon.Max Hp*Lvl. If enemy CS’Mon HP goes below 1, obtained CS’Mon Lvl will increase. 
Each ‘turn’, the player’s chosen option goes into effect before the enemy CS’Mon’s move, unless the Attack option is chosen. Then, whichever CS’Mon has the higher Speed*Lvl value will go first. If the slower CS’Mon’s HP goes below 1 before it gets to attack, its attack will not take effect. When a CS’Mon attacks, a random int from 0-100 will be generated and if it is below the CS’Mon’s accuracy value, the move will take effect. Another random int from 0-100 will be generated to determine if the attack is ‘critical’. The opposing CS’Mon’s HP will then reduce by CS’Mon.attack*Lvl*(1.5 if critical)*(1.5 if Type Advantage (ie. this CS’Mon is water type and opposing CS’Mon is fire type))*(0.5 if Type Disadvantage (ie. opposite of previous)).

Design decisions, concerns, limitations
How to implement attacks that are especially unique 
How to efficiently add over 30 CS’Mon
How to make every CS’Mon unique and interesting 
Resources we’ve found that we plan to use on our project
Unity will be our game engine
Attendance sheet to create CS’Mon sprites and Adobe Photoshop to polish said sprites.
Excel sheet that students have the option of filling out that will help us come up with their CS’Mon’s moveset
Plans for next Sprint
Finish Battle Mechanics
Start adding in more CS’Mon


