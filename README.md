# GDIM32 In Class Activities

## Devlogs
### W1
#### Activity 1
Going to office hour and ask questions, even you don't have any questions do your homework outside the office once you have a question you can just going in and ask for help, or maybe you don't have questions just letting professor help you do a play test, I think this is very very helpful. Table 5.
#### Activity 2
1. 10
2. 2
3. everytime you have a new thing, in Debug.Log will show "hello world".
4. MonoBehaviour
5. In these lines it introduce the Start method, and the method include PrintMessage(10) is a definition, inside this define  "x = " is string so these line will show x = 10 which made PrintMessage become a method.
6. 10 is a parameter. ("x = " + 10) is a agruement.
7. Transform.Translate(_direction); is wrong. we called the class name.
8. change Transform to _playerTransform.
#### Activity 3
[Activity 3 breakdown Google doc](https://docs.google.com/document/d/15_HFzD7qHn72CA-2sku_BtfdMzhq6NBtRONPqSFgEHI/edit?tab=t.0)

### W2
#### Activity 1
![IMG_0554](https://github.com/user-attachments/assets/5a59f0f9-168c-4990-95b2-3cbe6f1b45bf)

#### Activity 2
[MG2](https://github.com/UCI-GDIM32-W25/mg2-EW1028/commit/44f2885354db45fc5e37a116bdc72bf781ad118a)

I finished the player scriptc my game object can jump now. Also I started my UI.

### W3
#### Activity 0 - 2
Jamin Pinson

#### Activity 3
![IMG_0759](https://github.com/user-attachments/assets/5d912865-35ea-4779-9598-3450a44726da)

### W4
#### Activity 0
Marcelo Tolosa

#### Activity 1
Only one locator component will show up in the gameobject, becasue it is a singleton.

#### Activity 2
![IMG_0990](https://github.com/user-attachments/assets/e8ac50a6-ed58-47e2-9a5c-61e14b57ad2b)

#### Activity 3
[MG4](https://github.com/EW1028/HW4/commit/2ff19bf4772b18715faf4d7375ceba22b05b0ad1)
I make the HW4 project, and I make the player and some script. I am putting the UI/sprite inside the unity.

### W5
#### Activity 1
I think the design using an abstract class and an interface is effective becasue Item abstract class ensures all items can be used, while the IBreakable iterface is only applied to items that can actually break, such as the Axe and Torch. This keeps the code organized and avoids unnecessary duarability logic on items like the ElvenSword. If I were building a larger project, I would basically keep this design, but I would consider putting the damaged logic in a common class to reduce duplicate code. Inaddition, this design is simple, flexible and easy to expand.

#### Activity 2
In W5_Demo2, the Model consists of a ScriptableObject of ItemW5Demo2 and a list<ItemW5Demo2> held by the player. These componts are solely responsible for storing and defining data for game items, without containing any display or input logic. The View comprises InventoryUI and SpriteRender, which are only responsible for visualizing the data, such as displaying the item list and the player character's appearance on the screen, without directly modifying the data. The Controller is PlayerW5Demo2, which recives player input, controls character behavior, and passes model data to the UI at appropriate times, thus coordinatng the interaction between the Model and View, adhering to the separation of responsibility design priciple of MVC

#### Activity 3

##### Scenario 1
There are need be have a sprite, prefab, scriptable, organzing data for a rhythm game.

##### Scenario 2
All of the character, there ability caring out the ability that causing damage to other player, and UI actviting all the ability.

##### Scenario 3

View:InventoryIU, DialogueUI, animation, SFX.

Control:Player NPC Object(plant, stone)

Model:Items, NPC, Object (ScriptableObject)

Singleton: GameController (sent event)

The stay of the seed of growth, steammachine

#### Activity 4:

Attendance: Ruichen Ma, Chengxi Jiang, Eric Wei

Proposal:[Final Project Proposal First Draft](https://docs.google.com/document/d/1xih16oloKwzPrgx0m7rAdHD8XQO2XJP5otpn2PSakoM/edit?tab=t.0#heading=h.y4j3q551ojs1)

### W6
#### Activity 1:
We have questions about why the game is playing so slow, we can use performance profiling to check which methods performance a issue. Gizmos to see the boundary of the colliders. So in our game we probably going to use collider to detect the where is the enemies.

#### Activity 2:
Attendance: Ruichen Ma, Chengxi Jiang, Eric Wei

Proposal:[Final Project Proposal Final Draft](https://docs.google.com/document/d/1xih16oloKwzPrgx0m7rAdHD8XQO2XJP5otpn2PSakoM/edit?tab=t.0#heading=h.y4j3q551ojs1)

### W7
#### Activity 1:
In thd demo, we used a finite state machine to control the duck the NPC with teo states, wandering and pursuing. The duck uses raycast to check if it can see the player, it switches to the pursue state and moves toward the player using normalized vectors, rotation, and time.detlatime. if it does not see the player, it wanders in a random direction and uses a spherecast to avoid items that block the way.

#### Activity 2:
Attendance: Ruichen Ma, Chengxi Jiang, Eric Wei

#### Activity 3:
![Final Breakdown](https://github.com/user-attachments/assets/313bf285-c90e-40b9-8c6b-319477e1a421)

#### Activity 4:
Breakdown:[Final Breakdown](https://trello.com/b/CdYH9Ffo/gdim-32-final-project-list)

#### Activity 5:
Final:[Final](https://github.com/EW1028/GDIM32-Final/commit/dbd40649d14edf5a8f213736e1b8f153c1c65fd3)
We created a simple background and a sample player. We created the scripts and all the files, and we are working on the movement.

### W8
#### Activity 1:
In the demo, the rendering pipeline controls how a game is drawn to the screen, and it's important to check whether the project uses built in, URP, or HDRP because assets must match the correct pipline. Post processing effects are the full screen shaders, like bloom and color grading, that improve the overall bisual style and the theme of the game. To set it up in hte build in pipline, the post processign package, added a post process layer to the camera, created a global post process volume, and adjusted the effect settings.

#### Activity 2:
Attendance: Ruichen Ma, Chengxi Jiang, Eric Wei

#### Activity 3:
The movement is a little bit slow, need to follow what player moves. When player is moving the gun should move as the player moves. Clear on the final target or goal. Add a crosshair to aim the target.

#### Activity 4:
I will do the different kinds of lights, and 2 unique 3D animations on ememies and the NPC, also I will do the aduio track for background music.

#### Activity 5:
I am working on the game controller and the sfx. but the code are not wroking yet, I will fix it later.
Final:[Final](https://github.com/EW1028/GDIM32-Final)

### W9
#### Activity 1:
In the demo, single dialogue, the duck NPC stores dialogue lines in an array and shows two player reply options that trigger methods like ClickGoodOption() or ClickedBadoption(). This system works for the simple conversations but does not scale well because adding more options would require writting more code and UI buttons. In the second demo, dialogue is stored in, ScriptableObjects called DialogueNode, which contain NPC lines, player reply options, and references to the next dialogue nodes to create branching conversations.

#### Activity 2:
Attendance: Ruichen Ma, Chengxi Jiang, Eric Wei

#### Activity 3:
During playtest testing, the playtester said our game's movement has improved a lot compared with the last version. They suggested we can adjust the reload cooldown, as they think the current reload time is too long and feels clunky. They also pointed out that the pistol having 100 bullets in our test build is a bit unreasonable. So, we should add NPC dialogue to guide new players, since some players who are new to FPS games tried to shoot with the Space key instead of the left mouse button. We also need to optimize the terrain, because the current map looks a bit plain. We think our progress is still better than expected. Moving on, we will adjust the reload cooldown, balance the ammo amount, add player guidance through NPC dialogue, optimize the terrain and decorations, improve some code, add models for enemies and NPCs, and add more interactive elements in the level.

#### Activity 4:
We made some change on the shooting animations for game characters from last week. Players can now shoot and get hit feedback. We also added BGM and basic sound effects, such as shooting sounds and reloading sounds, which make the game has more basic interactions. We improved the map as well, adding terrain and trees and so on. Finally, we wrote code for NPCs but haven't added them to the game yet. We think our progress is better than expected. We still need to optimize the terrain and decorations, improve some code, and add NPC dialogue scripts to the game. We also plan to add models for enemies and NPCs, and include more interactive elements in the level.

#### Activity 5:
We are working on the enemies and shooting. We also talks about what are we going to do next.
Final:[Final New Vision](https://github.com/EW1028/GDIM32-Final/commit/d62c888b79d44cbc6c77aba274d41712bfeada4e)