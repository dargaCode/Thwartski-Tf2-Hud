//-------------------------------------------------------------------
//						   CONTACT INFO
//-------------------------------------------------------------------

Email: 							thwartski@gmail.com
ThwartskiHUD Project Page: 		http://code.google.com/p/thwartski-tf2-hud/
ThwartskiHUD Steam Group:		http://steamcommunity.com/groups/thwartskihud
Youtube: 						http://www.youtube.com/user/ThwartskiTF2

//-------------------------------------------------------------------
//						  HOW TO INSTALL
//-------------------------------------------------------------------

[These steps assume you've never edited a config before, but if you have, 
saving a copy of your CFG folder will save your configs from being overwritten.]

1.  Find your TF2 folder. It will be something like: 
	C:\Program Files (x86)\Steam\steamapps\[YOURNAME]\team fortress 2\tf\

2.  Copy the CFG folder from this folder into your TF folder. Confirm that 
	you want to merge with your existing CFG folder and overwrite all the files. 
	
3.  Copy the SCRIPTS folder from this folder into your TF folder. There is only
	one file in it and it probably won't need to be overwritten.
	
4. 	Load the game and rebind your call for medic key if it was on E before.
	The system uses Q and E by default to swap weapons. To change that, see FAQ.
	
5.  Start playing!

//-------------------------------------------------------------------
//						  ABOUT THWARTSKI
//-------------------------------------------------------------------

I'm a professional game designer who plays a decent amount of TF2. My comp ability
is still low, but believe I know enough to design for high level comp players.

I try to play all nine classes so I can tailor things to each of them. My current 
main is soldier. It was originally pyro, then engie, then sniper, then spy.

//-------------------------------------------------------------------
//						 ABOUT THE SWAPPER
//-------------------------------------------------------------------

The goal of this system is to get you playing TF2 without the distraction of viewmodels, 
while remaining fully confident in which weapon you have equipped. 

This works in three steps: 

1. 	Getting you used to having a distinct crosshair for each class's weapon slot, which you
	will recognize as a shorthand for that weapon.

2.	Enabling you to control all weapon selection with only two keys, removing the need
	for fumbling with scroll wheels or number keys. 
	
3.	Allowing you to begin turning off the viewmodels for certain crosshairs, until you
	have hidden the viewmodels for all weapons (or for all but melee if you choose).
	
Using the two-button swapper system and hiding viewmodels is optional. However, after 
three months using this system myself, I can say it has improved my game a lot.

//-------------------------------------------------------------------
//						TWO-BUTTON SWAPPING
//-------------------------------------------------------------------

In a game with only three main weapons per class, there are only two weapons to
switch to at any given time. This means only two buttons are required for perfect
weapon swapping. 

I repurpose the "lastwep" button TF2 already has to switch between the first 
two weapons, and add another swap button to move between the second two weapons.

For each weapon that is swapped to, the script also swaps in custom crosshairs 
and visibility settings, if they've been defined for that class. 

[Spies and Engineers have an extra slot or two to deal with, but I put in some
special-casing to update the swapper when a PDA is selected.]

//-------------------------------------------------------------------
//						  SOLDIER EXAMPLE
//-------------------------------------------------------------------

You can think of it in terms of cycling weapons: 

	Q always cycles between Rocket Launcher and Shotgun, starting with Rocket Launcher.	
	E always cycles between Equalizer and Shotgun, starting with Equalizer.

Or it might be easier to think of it in terms of keys bound to weapons:

	Rocket Launcher is always equipped by hitting Q.
	Equalizer is always equipped by hitting E.
	Shotgun is always equipped by hitting Q or E a second time.
	
	