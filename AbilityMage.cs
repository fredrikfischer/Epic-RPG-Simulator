using System;

namespace OOP2
{
	class AbilityMage 
	{
		Ability? fireBall;

		//parametrar kommer senare komma från en annan datatyp t.ex charachter player
		public AbilityMage(){
			string fireBallDescription = "Launches a fire ball at the enemy";
			Ability fireBall = new Ability("Fire ball", fireBallDescription, "fire", 20, 0);
		}

        
		
	}
}
