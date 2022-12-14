# Survival
Unity Game Application

## NEW update log 10/11/22 Gun Working + Enemy take Damage :
+ Player movement is now using new rotation as discussed before 
+ Pressing "Fire1" now creates a bullet sprite it now can do 20 damage towards enemys
+ Taking 100+ damage to the enemy now destroys a enemey sprite in the Game
+ Teleportation rework made.

Bug Fixes 
- Fixed Fire1 not spawning bullets 
- Fixed player not effecting damage but destroying bullets not occuring a damage intake to the enemy
- Fixed Player Rotation Swapping firepoint sides
- Fixed Player rotational firepoints for both sides. 

Removed Content 
- Logs

Bugs - 
1. Movement is now Tap only as in you cant hold down the button to go forward but have to tap. (Slowly)



## NEW update log 3/11/22  Small Health + Shooting Update:

+ Added Working Health Indicator into all rooms 
+ Added Working Shoot script (Pressing "Fire1" or Left mouse click shoots a bullet out of the survivor capsule
+ Added Working Side to side shooting 
+ Shooting also means if shot at a 2D Capsule the bullet will destroy (this to intake damage which will be added later)


Bug fixes 
- Fixed "Droopy" shooting (shots would fall flat to the floor instead of going in a straight line
- Fixed Shooting only one direction 
- Fixed Shooting would cause the player to spin 360 degrees in the rooms 
- Fixed Player gravity by Freezing Z axis 
- Fixed Shooting button not refering to "Fire1" from WhenMousebuttonPress to WhenButtonPress
- Fixed Health Sliders
- Removed Weapon Asset as it was deemed unusuable and added just a firepoint to simplfy work
- Fixed Shooting Not destroying on Collision with 2D Sprite colliders 


Removed Content
- Weapon Placeholder
- Unsuable Movement system and replaced with a older previous build 

Bugs - 
1. Movement is now Tap only as in you cant hold down the button to go forward but have to tap. (Slowly)


## NEW Update Log 31/10/22 The Bug Fix Update:

+ Added New Scenes "HouseTest2" and "TestHouseFlip" (HouseTest2 is a exstension to the level and TestHouseFlip being a Shortcut fix for a new script)
+ Added HeatlhBar to Main character when loading In "HouseTest" (needs to be added to other scenes later)
+ Added Healthbar Script (can be used to function and operate and indicate to players how much health they have)
+ Modified some scripts to help fix some borderline game breaking glitches.
+ Teleporters added (switches between new room "HouseTest2" and returns to old room "TestHouseFlip")


Bug Fixes
- Fixed Player being shown in Menu
- Fixed Player creating copies of itself when teleporting
- Teleporting now switches scenes as a small bug was found looping scenes together
- Fixed inability to listen to Music since scene would load to "Quickly" (Scene would auto-load consistantly inbetween scenes)
- Player speed fix (too slow again)
- Player Health fix being over 100 or below (was 93.78)
- Renamed scripts to stop scripts clashing and causing internal expectations
- Fixed Teleporters not remebering save positons when loading to another scene
- Health bar causing speed to reset float to 0f causing inability to move player
- Fixed Scene transitoning being too slow with background/middleground/foreground tags now readjusting this. 
- Fixed Healthbar Not showing in other Scenes ("HouseTest2" and "TestHouseFlip")
- Fixed Teleporters not loading scenes and actually loading wrong scenes (Main Menu For Example)
- Fixed Player Inability to be killed by removing DontDestroyonLoad (Reason: Nonfunctional anymore and causing script errors)
- Fixed ESC script where it will now kill the game in any scene Listed : ( "HouseTest", "HouseTest2" and "TestHouseFlip" ) 
- Removed ESC script from main menu since it was deemed redundant
- Removed Debug message for ESC script since Void update would constantly spam the console (still on the script is just // out)
- Fixed RenderPipeline Bug (causing materials to go missing) 
- Fixed Gravitaional Pull by removing lack of Gravity in game. 
- Renamed Scripts to fit scene transitions with teleporters. 

Removed Content
- None


# Update Prior

## Update Log 25/10/22

+ Added new scene "HouseTest"
+ Added background images to "HouseTest"
+ Added Player (capsule) and added "PlayerMovement" script to said capsule
+ Added "Esc" script which allows the player to press a key on the keyboard to warp them back to the MainMenu scene. 
+ Added Render pipeline Package (URP)
+ Added more debug logs to help explain scripts usage
+ Added interaction boxes into "HouseTest" to be used later
+ Added Teleport boxes into "HouseTest" to be used later

Bug Fixes
- BGM (background Music) will know destroy when loading into a new scene
- Player clipping through walls in "HouseTest"
- Player speed being to slow to move 
- Player gravitational pull fixed
- Start loads into a actual scene to replace "StartGame" with "HouseTest"


Removed Content

- Removed Comp1.avi (Rain video) - Reason : Too large file size (110mb)
