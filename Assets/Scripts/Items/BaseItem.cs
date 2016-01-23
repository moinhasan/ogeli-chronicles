using UnityEngine;
using System.Collections;

public class BaseItem {

	public string ItemName{ get; set;}
	public string ItemDescription{ get; set;}
	public int ItemId{ get; set;}

	public enum ItemTypes {
		HELM,
		WEAPON,
		CHEST,
		PANTS,
		CONSUMABLE
	}

	public ItemTypes ItemType;

}

