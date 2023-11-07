using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door4Level : MonoBehaviour
{
    public Sprite DoorOpen;
    public Sprite ChestOpened;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Chest").GetComponent<SpriteRenderer>().sprite == ChestOpened)
        {
            GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite = DoorOpen;
        }

    }
}
