using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Item
{
	public GameObject LockableTarget;
	public Sprite sprite;

	void Awake (){
		base.ID = 1;
		base.Name = "Key";
		base.IMG = Resources.Load<Sprite>("Items/key_sprite"); 
	}
}
