//-------------------------------------------------------------------
//							CONTACT INFO
//-------------------------------------------------------------------

Email: 							thwartski@gmail.com
ThwartskiHUD Project Page: 		http://code.google.com/p/thwartski-tf2-hud/
ThwartskiHUD Steam Group:		http://steamcommunity.com/groups/thwartskihud


//-------------------------------------------------------------------
//						 	  ABOUT ME
//-------------------------------------------------------------------

I'm a professional game designer who plays a decent amount of TF2.
I don't play comp except really lowlevel stuff, but I'm working on it.

I try to play every class as much as I can, especially for testing stuff like this.
My current main is soldier, but originally was pyro, then sniper, then spy.


//-------------------------------------------------------------------
//						 ABOUT THE SWAPPER
//-------------------------------------------------------------------

I put together this combination of weapon swapping and crosshair swapping so 
that I could finally turn off my viewmodels and be less distracted while playing. 
It worked out perfectly for me, and I think everyone should give it a try =)


//-------------------------------------------------------------------
//							HOW IT WORKS
//-------------------------------------------------------------------

It's silly to mess with scroll wheels and number keys in a game with so few 
weapon slots. Every class has only three weapons, aside from two classes with 
PDAs (which can be handled elsewhere). 

With three weapons, there is always one active and only two are possible options
to switch to at any given time. 

This means only 2 buttons are required for perfect weaponswapping.

I repurpose the "lastwep" button TF2 already has to switch between the first 
two weapons, and add another swap button to move between the second two weapons.

For each weapon that is swapped to, the script also swaps in custom crosshairs 
and visibility settings. 


//-------------------------------------------------------------------
//						  SOLDIER EXAMPLE
//-------------------------------------------------------------------

Rocket launcher is selected automatically at spawn.
Hitting Q repeatedly cycles between rocket launcher and shotgun (same as valve).
Hitting E swaps to equalizer.
Hitting E repeatedly cycles between equalizer and shotgun.
Hitting Q swaps back to rocket launcher.
etc.


//-------------------------------------------------------------------
//						  HOW TO INSTALL
//-------------------------------------------------------------------

1. 
	Rename your config folder to back it up.

	It should be something like: 
	C:\Program Files (x86)\Steam\steamapps\[YOU]\team fortress 2\tf\cfg\

2. 
	Drag the thwartski-weaponswap folder into your \team fortress 2\tf\ folder.
	
3. 
	Rename the thwartski-weaponswapper folder to "cfg".

4. 
	Restart the game and play around with the swapper.
	
5. 
	If you like it, You can merge it with your old config folder.

	I've removed as much as possible to separate config files, so there's
	as little as possible to paste into your configs such as autoexec and spy.cfg.

6. 
	Send me feedback! 

	A.	thwartski@gmail.com
	B.	http://steamcommunity.com/groups/thwartskihud
		This group is also where I'll be releasing my custom HUD soon.
	
	
//-------------------------------------------------------------------
//						 HOW TO CUSTOMIZE
//-------------------------------------------------------------------

1. 
	In thwartski_weaponswap.cfg, rebind the 2 swap keys if you wish. 
	
	By default, they are bound to Q and E.
	
2.
	In thwartski_crosshairs.cfg, modify the crosshairs and viewmodels if you wish.
	
	By default, viewmodels are turned off for everything except melee, but it can 
	be easier to learn the system with them turned on if you play a lot of classes.

3.
	In thwartski_weapons_[class].cfg, modify the primary/secondary/tertiary
	weapon definitions for each class, if you wish.
	
	I leave the Valve definitions there by default, but leave comments with my own 
	recommendations (these are the settings I've been using the past few months). 
	
	Demo, Medic, and Spy are the three classes I recommend changing. 
	
4.
	In thwartski_crosshairs.cfg and thwartski_weapons_[class].cfg, modify the 
	crosshair category for each	weapon if you wish. 
	
	I use the following four groupings:
	
	A.	Valve defaults for medigun, sapper, minigun, stickies, rockets, flames.
	B.	"Precise" for sniper, pistols, revolver.
	C.	"Spread" for shotguns, needles, smg, grenades.
	D.	"Melee" for melee.
	
5.
	In thwartski_weapons_pyro.cfg and thwartski_weapons_medic.cfg, modify the 
	two weapons that have optional tracer effects:
	
	A.	Medigun has the heal beam connecting the medic to the heal target
		visible by default.
	B.	Flamethrower has its flames invisible by default. 
	

//-------------------------------------------------------------------
//						   KNOWN ISSUES
//-------------------------------------------------------------------

There are two types of situation in which the crosshair switcher can become
unsynchronized from the actual weapon equipped.


//-------------------------------------------------------------------
//					  UNSYNCHED CROSSHAIRS 1
//-------------------------------------------------------------------

Problem:
	Because game doesn't actually inform the scripting language which weapon is
	equipped, it is possible to tell the weaponswap system to swap crosshhairs 
	when the weapon can't actually keep up. 

Examples: 
	Trying to swap to another weapon while the heavy's minigun is still spun up.
	Trying to swap to a weapon that is on a cooldown (eg jarate, mad milk).
	Trying to swap to a slot with no true weapon in it (eg razorback, gunboats).
	Trying to swap to any weapon that is out of ammo.
	Trying to swap to any weapon while dead.
	Trying to swap to any weapon while taunting.
	Trying to swap to any weapon while stunned.
	Trying to swap to any weapon while bonking.
	Trying to swap to any weapon during humiliation (if you lost).
	
Solution:
	Just hit either swap button once (under valid conditions) to correctly 
	update the system. Being careful during death and cooldowns prevent most 
	problems.
	
	Some bad conditions (such as wearing gunboats) persist indefinitely.
	Keeping your loadout in mind while playing is very important anyway, 
	so this shouldn't be a problem for experienced players.
	
	
//-------------------------------------------------------------------
//					   UNSYNCHED CROSSHAIRS 2
//-------------------------------------------------------------------

Problem:
	Because class configs execute only once per class and not each spawn,
	changing loadout while still alive can change weapons without updating
	your crosshair.

Example: 
	You are in the spawn with your equalizer equipped, then change loadouts.
	TF2 forces you back to your primary weapon on loadout change, while your 
	crosshair still indicates equalizer.

Solution:
	Just hit either swap button once to correctly update it.