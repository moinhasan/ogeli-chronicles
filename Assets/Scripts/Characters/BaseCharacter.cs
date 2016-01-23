using UnityEngine;
using System.Collections;

public class BaseCharacter
{
	public int CharacterId{ get; set;}
	//base stats
	public int Strength{get; set;}
	public int Intelligence{get; set;}
	public int Agility{get; set;}
	public int Armor{get; set;}
	public int Health{get; set;}
	public int Mana{get; set;}

	//class
	public CharacterClass charClass{get; set;}

	public enum CharacterClass{
		MAGE,
		ROGUE,
		WARRIOR
	}

	public enum CharacterType{
		NEUTRAL,
		NPC,
		PLAYER
	}
}

