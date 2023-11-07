using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject MainCharacter;
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer MCspriteRenderer;
    public SpriteRenderer TipRenderer;
    public Sprite OpenedChest;
    public Sprite ClosedChest;
    public Sprite KeyFound;
    public Sprite KeyNotFound;
    public Sprite ClosedChestText;
    public Sprite OpenedDoor;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (GameObject.Find("Chest").GetComponent<SpriteRenderer>().sprite == ClosedChest && GameObject.Find("Closet2").GetComponent<SpriteRenderer>().sprite == KeyFound)
        {
            GameObject.Find("Chest").GetComponent<SpriteRenderer>().sprite = OpenedChest;

            GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite = OpenedDoor;
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (GameObject.Find("Chest").GetComponent<SpriteRenderer>().sprite == ClosedChest && GameObject.Find("Closet2").GetComponent<SpriteRenderer>().sprite == KeyNotFound)
        {
            GameObject.Find("Chest").GetComponent<SpriteRenderer>().sprite = OpenedChest;
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {

    }
}
