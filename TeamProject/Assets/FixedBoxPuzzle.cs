using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedBoxPuzzle : MonoBehaviour
{
    public int BoxCount = 6;
    public Sprite BoxFalse;
    public Sprite BoxTrue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   /* private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject.Find("Button").GetComponent<SpriteRenderer>().sprite = PressedButton;
        GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite = OpenDoor;
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        GameObject.Find("Button").GetComponent<SpriteRenderer>().sprite = PressedButton;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        GameObject.Find("Button").GetComponent<SpriteRenderer>().sprite = DefaultButton;
        GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite = CloseDoor;
    }*/
}
