using System;

namespace OOP2
{
	class Spell
	{
		string type;
		string name;
		int dmg;

		//parametrar kommer senare komma från en annan datatyp t.ex charachter player
		public Spell(string type, string name, int dmg){
			this.type = type;
			this.name = name;
			this.dmg = dmg;
			
		}
	}
}
