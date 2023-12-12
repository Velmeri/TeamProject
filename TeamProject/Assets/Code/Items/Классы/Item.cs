using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[SerializableAttribute]
public abstract class Item : MonoBehaviour
{
    public int ID { get; set; }
    public string Name { get; set; }
    public Sprite IMG { get; set; }

    public Item()
    {
        ID = 0;
        Name = "Nothing";
        IMG = null;
    }

	public Item(int id, string name, Sprite img)
	{
		ID = id;
		Name = name;
		IMG = img;
	}
}