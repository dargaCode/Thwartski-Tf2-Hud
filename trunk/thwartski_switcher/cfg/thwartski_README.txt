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

[These steps assume you've never edited your configs before, but if you have, 
you should first save a backup copy of your cfg folder before replacing it.]

1.  Find your TF2 folder. It will be something like: 
	C:\Program Files (x86)\Steam\steamapps\[YOURNAME]\team fortress 2\tf\

2.  Copy the CFG folder from this folder into your TF folder. Confirm that 
	you want to merge with your existing CFG folder and overwrite all the files. 
	
3.  Copy the SCRIPTS folder from this folder into your TF folder. There is only
	one file in it and it probably won't need to be overwritten.
	
4. 	You may want to rebind your keys from the defaults I have set (see FAQ).
	
5.  Have fun!

//-------------------------------------------------------------------
//						  	 THANK YOU
//-------------------------------------------------------------------

I was inspired by Aron's Crosshair Switcher quite a bit, and learned a lot about how
Valve's crosshair system works from looking at his configs: 
http://tinyurl.com/7xzb6sk

Feedback from Saberreap, Zeldajunki, AndyJ, and Lane helped me fix a lot of things
that were confusing, broken, or unclear. 	

I got some good ideas from Stabby's spy scripts, which I used in the advanced spy config:
http://tinyurl.com/78gjvk7

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
	
3.	Allowing you to turning off the viewmodels for all weapons, or all weapons except 
	melee (which I recommend due to melee timing differences between classes).
	
Using the two-button swapper system and hiding viewmodels is optional. However, after 
several months using this system myself, I can say it has improved my game a lot.

//-------------------------------------------------------------------
//						TWO-BUTTON SWAPPING
//-------------------------------------------------------------------

In a game with only three main weapons per class, there are only two weapons to
switch to at any given time. This means only two buttons are required for perfect
weapon swapping. 

I repurpose the "lastwep" button TF2 already has to switch between the first 
two weapons, and add another swap button to move between the second two weapons.

For each weapon that is swapped to, the script also swaps in custom crosshairs 
and viewmodel visibility settings, if they've been defined for that class. 

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
	
//-------------------------------------------------------------------
//						  ABOUT THWARTSKI
//-------------------------------------------------------------------

I'm a professional game designer who loves TF2 and tinkering with stuff like this.
My comp career is nothing impressive, but I know enough to design for comp play.

I'm one of those people who has jumped around a lot between classes. My main is 
soldier (pocket), but I originally mained pyro, then engie, then sniper, then spy.

