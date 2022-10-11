using System;

namespace OOP2
{
	class Ability
	{
		string name;
		string description;
		string type;
		int damage;
		int heal;

		public Ability(string name, string description, string type, int damage, int heal)
		{
			this.name = name;
			this.description = description;
			this.type = type;
			this.damage = damage;  
			this.heal = heal;
		}

		
	}
}
