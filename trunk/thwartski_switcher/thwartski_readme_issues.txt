	
//-------------------------------------------------------------------
//						   KNOWN ISSUES
//-------------------------------------------------------------------

There are two types of situations in which the crosshair switcher can become
unsynchronized from the actual weapon equipped.

//-------------------------------------------------------------------
//					   UNSYNCHED CROSSHAIRS 1
//-------------------------------------------------------------------

Problem:  	Because game doesn't actually inform the scripting language which weapon is
			equipped, it is possible to tell the weaponswap system to swap crosshhairs 
			when the weapon can't actually keep up. 

Examples: 	1. 	Swapping to a weapon that is on a cooldown (eg jarate, mad milk).
			2. 	Swapping to a weapon with a weapon that is out of ammo.
			3. 	Swapping to a slot with no equippable weapon in it (eg razorback, gunboats).
			4. 	Swapping weapons while in third-person view (eg taunting, stunned, bonking, humiliation).
			5. 	Swapping to another weapon while the heavy's minigun is still spun up.
			6. 	Swapping to another weapon while the heavy's minigun is still spun up.
	
Solution:	Once normal conditions resume, just hit any number key, scroll wheel, 
			or swap button to correctly update the system. 
			
			Being aware of your weapons during death and cooldowns prevent most problems.
			
			Some conditions (such as wearing gunboats) persist indefinitely.
			Keeping your loadout in mind while playing is very important anyway, 
			so this shouldn't be a problem for experienced players.
	
//-------------------------------------------------------------------
//					  UNSYNCHED CROSSHAIRS 2
//-------------------------------------------------------------------

Problem:	Because TF2 only executes class configs once per class and not each spawn,
			changing loadout while still alive can change weapons without updating
			your crosshair.

Example: 	You are in the spawn with your equalizer equipped, then change loadouts.
			TF2 forces you back to your primary weapon on loadout change, while your 
			crosshair still indicates equalizer.

Solution:	Just hit any number key, scroll wheel, or swap button to correctly 
			update the system.
	
	