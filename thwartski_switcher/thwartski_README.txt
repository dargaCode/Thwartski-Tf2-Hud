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

1.  Copy all these files from this folder to your cfg folder, replacing what was there. 
	If you've created any custom configs, you should back them up first. 

	[C:\Program Files (x86)\Steam\steamapps\[YOU]\team fortress 2\tf\cfg\]
	
    [If you're super hardcore about one class and never play the others, you can
	delete the class-specific configs you don't want and the system will still work.]

2.  Load the game and start playing!

//-------------------------------------------------------------------
//						  ABOUT THWARTSKI
//-------------------------------------------------------------------

I'm a professional game designer who plays a decent amount of TF2. My comp ability
is still low, but believe I know enough to design for high level comp play.

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
	
//-------------------------------------------------------------------
//						 HOW TO CUSTOMIZE
//-------------------------------------------------------------------

As you edit your settings, you don't have to restart the game for them to take effect.
Just save your config files and change classes to reset the system with your new changes.

Each config has the sections that contain customization options marked with: **EDIT ME!**

[If you've never edited a .cfg file before, you'll have to tell your operating system
that you want to use Notepad to open it.]

1. 	Use thwartski_wepswapper.cfg to rebind the two-button weaponswap keys. 
	
	By default, they're bound to Q and E.
	
	
2.	Use thwartski_wepswapper_[classname].cfg to modify the primary/secondary/tertiary
	weapon definitions for each class.
	
	For example, I recommend using medigun as medic's primary, and sticky launcher as demo's
	primary. Any changes will apply to swapper buttons, number keys, and the scroll wheel.

	
3.  Use thwartski_crosshairs.cfg to modify the crosshairs and viewmodels.
	
	By default, viewmodels are turned on, so you can get used to the crosshairs and 
	weapon swapping first. I recommend turning them off for all weapons but melee.

	
4.  Use thwartski_crosshairs.cfg and thwartski_wepswapper_[classname].cfg to modify the 
	crosshair category for each	weapon. 
	
	I use the following four groupings:
	
		A.	"Valve" for medigun, sapper, minigun, stickies, rockets, flames.
		B.	"Precise" for sniper, pistols, revolver.
		C.	"Spread" for shotguns, needles, smg, grenades.
		D.	"Melee" for melee.
	
	
5. 	If you turn off viewmodels, use thwartski_wepswapper_pyro.cfg and thwartski_wepswapper_medic.cfg
	to turn on and off their optional tracer effects: 
	
		A.	Healing beam connecting the medigun to the heal target (visible by default). 	
		B.	Flamethrower flames (visible by default). 
	
6. 	Change spy.cfg to point to thwartski_wepswapper_spy_advanced.cfg, if you're a spy who wants to 	
	to things like hide the amby during reloading and disguise the crosshair growth. You know who you are.  
	
	