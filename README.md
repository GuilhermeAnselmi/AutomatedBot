# AutomatedBot

Management panel and manipulation of automated bot routines.
With this project, you can simulate keyboard and mouse as a routine dynamically and easily, in addition to keyboard and mouse you can also send console commands, do conditional checks and do color checks that lead to other routines.

# Requirements
* .NET Core v6.0
* KlusterG.AutoGui v1.2.0
* Newtonsoft.Json v13.0.1

# Where to start?
## Git Clone
* Clone the repository.
* Open with Visual Studio 2022 or higher.
* Run the AutomatedBot project (this is the routines management panel).
* When the routine is assembled, run AutomatedBot.Engine to interpret and execute the routine (note that the FileJson folder that is next to the dll's must be in the same folder as the engine executable).

# Functions
## SimpleClick
* 
Makes a simple mouse click.
 
## DoubleClick
* Double-click the mouse.

## RightClick
* Right-click.

## Write
* Writes simulating the keyboard (can be set to use any of the input parameters).

## ClickKey
* Click on a key and then release it.

## PressKey
* Press one to three keys.

## ReleaseKey
* Release the pressed key.

## WaitColor
* Waits for a position to be the same color; (the timeout can be set, which after a while calls another routine).

## WaitColorCondition
* Checks up to 3 different positions and their colors. The first position that matches the respective color calls another routine defined by you (or you can continue the flow in the same routine); (the timeout can be set, which after a while calls another routine).

## Condition
* Checks a condition based on parameters defined at routine initialization.

## CommandLine
* Run a console command.
