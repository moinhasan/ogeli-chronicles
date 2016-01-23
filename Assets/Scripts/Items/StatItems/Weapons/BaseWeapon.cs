using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem {

	public int Damage { get ; set;}
	public WeaponTypes weaponType{ get; set;}

	public enum WeaponTypes {
		SWORD,
		STAFF,
		DAGGER,
		BOW,
		SHIELD,
		POLEARM
	}
}