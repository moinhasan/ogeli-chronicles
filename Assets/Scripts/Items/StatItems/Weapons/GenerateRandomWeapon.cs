using UnityEngine;
using System.Collections;

public class GenerateRandomWeapon : MonoBehaviour
{
	private BaseWeapon weapon;

	void Start(){
		GenerateWeapon ();
		Debug.Log (weapon.WeaponType);
	}

	public BaseWeapon GenerateWeapon() {
		weapon = new BaseWeapon ();
		weapon.WeaponType = EnumeratorHelpers.GetRandomEnum<BaseWeapon.WeaponTypes> ();
		return weapon;
	}

}

